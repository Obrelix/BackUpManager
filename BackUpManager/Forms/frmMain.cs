using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace BackUpManager
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 
        /// Variables From BackUpPersonalFiles Form Start
        /// </summary>
        
        string myPic, myVid, myMus, myDoc, myDL, myDesk;
        string dirToPaste;
        string empty = string.Empty;
        string files;
        string copiedFiles;
        int countPic, countVid, countMus, countDoc = 0, countDL, countDesk;
        int count;
        string newDest;
        int countCopied; //This is the interger number that on update show us how much files copied.
        int b;
        Thread th;
        ArrayList folderName;

        /// <summary>
        /// 
        /// Variables From BackUpPersonalFiles Form End
        /// </summary>

        /// <summary>
        /// 
        /// Variables From BackUpTimer Form Start
        /// </summary>

        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        FolderBrowserDialog fromPath = new FolderBrowserDialog();
        FolderBrowserDialog toPath = new FolderBrowserDialog();
        string pathFrom = string.Empty, pathTo = string.Empty;
        public static List<BackUp> backUpList = new List<BackUp>();
        public static int listIndex;
        List<ListId> cbxList = new List<ListId>();


        static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BackUpManager";
        static string saveFile = savePath + "\\BackupSaves.json";


        /// <summary>
        /// 
        /// Variables From BackUpTimer Form End
        /// </summary>
        

        public frmMain()
        {
            InitializeComponent();

            ///
            /// Initialize for BackUpPersonalFiles Form Controls/Vars Start
            ///

            Name = "BackUpMe";
            myPic = KnownFolders.GetPath(KnownFolder.Pictures);
            myVid = KnownFolders.GetPath(KnownFolder.Videos);
            myMus = KnownFolders.GetPath(KnownFolder.Music);
            myDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDL = KnownFolders.GetPath(KnownFolder.Downloads);
            myDesk = KnownFolders.GetPath(KnownFolder.Desktop);
            th = new Thread(checkWhatCopy);
            folderName = new ArrayList();
            foreach (string know in Directory.GetDirectories(myDoc))
            {
                folderName.Add(know);

            }


            b = folderName.Count;
            countPic = Directory.GetFiles(myPic, "*.*", SearchOption.AllDirectories).Length;
            countVid = Directory.GetFiles(myVid, "*.*", SearchOption.AllDirectories).Length;
            countMus = Directory.GetFiles(myMus, "*.*", SearchOption.AllDirectories).Length;
            countDL = Directory.GetFiles(myDL, "*.*", SearchOption.AllDirectories).Length;
            countDesk = Directory.GetFiles(myDesk, "*.*", SearchOption.AllDirectories).Length;

            for (int i = 0; i < b; i++)
            {
                if ((folderName[i].ToString() != myDoc + "\\My Music") && (folderName[i].ToString() != myDoc + "\\My Pictures") && (folderName[i].ToString() != myDoc + "\\My Videos"))
                {
                    countDoc += Directory.GetFiles(folderName[i].ToString(), "*.*", SearchOption.AllDirectories).Length;
                }

            }
            count = countPic + countDesk + countVid + countDL + countMus;

            ///
            /// Initialize for BackUpPersonalFiles Form End
            ///

            ///
            /// Initialize for BackUpTime Form Controls/Vars Start
            /// 

            cbxList.Add(new ListId(0, "Weeks"));
            cbxList.Add(new ListId(1, "Days"));
            cbxList.Add(new ListId(2, "Hours"));
            cbxList.Add(new ListId(3, "Minutes"));
            cbxList.Add(new ListId(4, "Seconds"));
            cbxList.Add(new ListId(5, "Manual"));
            cbx_Mode.DataSource = cbxList;
            cbx_Mode.DisplayMember = "Descr";
            cbx_Mode.ValueMember = "Mode";
            cbx_Mode.SelectedIndex = 5;


            dtgrdvDisplay.ColumnCount = 5;
            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //dtgrdvDisplay.Columns.Add(chk);
            //chk.HeaderText = "Check Data";
            //chk.Name = "chk";
            dtgrdvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdvDisplay.Columns[0].Name = "Backup Job Name";
            dtgrdvDisplay.Columns[1].Name = "Origin";
            dtgrdvDisplay.Columns[2].Name = "Destination";
            dtgrdvDisplay.Columns[3].Name = "Schedule";
            dtgrdvDisplay.Columns[4].Name = "Last Run";
            dtgrdvDisplay.Font = new Font(FontFamily.GenericSansSerif, 9.0F, FontStyle.Bold);

            //dtgrdvDisplay.DataSource = source;
            // Check to see the current state (running at startup or not)
            if (rkApp.GetValue("MyApp") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                mnu_StartWithWindows.Checked = false;
                ntfMnu_RunWithWindows.Checked = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                mnu_StartWithWindows.Checked = true;
                ntfMnu_RunWithWindows.Checked = true;
            }

            ///
            /// Initialize for BackUpTime Form End
            /// 

        }

        ///
        /// <summary>
        /// Methods/ Events From BackUpPersonalFiles Form Start
        /// </summary>
        /// 

        private void button1_Click(object sender, EventArgs e)
        {
            th.Start();
            tmrProgress.Start();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void chkDL_Click(object sender, EventArgs e)
        {
            if (chkDL.Checked)
            {
                countFiles(countDL, true);
            }
            else
            {
                countFiles(countDL, false);
            }
        }

        private void chkDesk_Click(object sender, EventArgs e)
        {
            if (chkDesk.Checked)
            {
                countFiles(countDesk, true);
            }
            else
            {
                countFiles(countDesk, false);
            }
        }

        private void chkDoc_Click(object sender, EventArgs e)
        {
            if (chkDoc.Checked)
            {
                countFiles(countDoc, true);
            }
            else
            {
                countFiles(countDoc, false);
            }
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            checkCopiedFiles();
        }

        private void tmrFilesCheck_Tick(object sender, EventArgs e)
        {

            lblFiles.Text = string.Format("Files: {0}", count);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {



            txtDestinationPath.Text = folderName.ToString();
        }

        private void chkVid_Click(object sender, EventArgs e)
        {
            if (chkVid.Checked)
            {
                countFiles(countVid, true);
            }
            else
            {
                countFiles(countVid, false);
            }
        }

        private void chkMus_Click(object sender, EventArgs e)
        {
            if (chkMus.Checked)
            {
                countFiles(countMus, true);
            }
            else
            {
                countFiles(countMus, false);
            }
        }

        private void chkPic_Click(object sender, EventArgs e)
        {
            if (chkPic.Checked)
            {
                countFiles(countPic, true);
            }
            else
            {
                countFiles(countPic, false);
            }

        }

        private void openFolder()
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            MessageBox.Show("Note this. You must create a new folder.", "Note this:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ofd.ShowDialog();
            txtDestinationPath.Text = ofd.SelectedPath.ToString();
            dirToPaste = txtDestinationPath.Text;

        }

        private void checkCopiedFiles()
        {
            //Every Tick
            try
            {
                countCopied = Directory.GetFiles(dirToPaste, "*.*", SearchOption.AllDirectories).Length;
                copiedFiles = countCopied.ToString();
                lblCurCopiedFiles.Text = string.Format("Current Copied Files: {0}", copiedFiles);
            }
            catch (Exception)
            {

            }

        }

        private void checkWhatCopy()
        {
            dirToPaste = txtDestinationPath.Text;
            if (dirToPaste == "")
                return;


            try
            {
                if (chkPic.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Picture");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myPic), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (chkMus.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Music");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myMus), new DirectoryInfo(newDest));

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            try
            {
                if (chkVid.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Videos");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myVid), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (chkDoc.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Documents");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myDoc), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (chkDL.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Download");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myDL), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (chkDesk.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Desktop");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myDesk), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CopyAll(DirectoryInfo oOriginal, DirectoryInfo oFinal)
        {
            foreach (DirectoryInfo oFolder in oOriginal.GetDirectories())
                this.CopyAll(oFolder, oFinal.CreateSubdirectory(oFolder.Name));

            foreach (FileInfo oFile in oOriginal.GetFiles())
                oFile.CopyTo(oFinal.FullName + @"\" + oFile.Name, true);
        }

        private void countFiles(int countFiles, bool isChecked)
        {
            //Legend
            //countFiles είναι ο αριθμός που θα στείλουμε
            //isChecked για να δούμε αν θα κάνει πρόσθεση ή αφαίρεση
            if (isChecked)
            {
                count += countFiles;
            }
            else
            {
                count -= countFiles;
            }

            files = count.ToString();
            lblFiles.Text = string.Format("Files: {0}", files);

        }

        private static void DirectoryCopy(
        string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }


        public void ShowProgress()
        {
            Form progress = new Progress(count, dirToPaste);
            progress.ShowDialog();
        }

        ///
        /// <summary>
        /// Methods/ Events From BackUpPersonalFiles Form End
        /// </summary>
        /// 



        ///
        /// <summary>
        /// Methods/ Events From BackUpTimer Form Start
        /// </summary>
        /// 

        private void checkForAlarm()
        {
            try
            {
                for (int x = 0; x < backUpList.Count; x++)
                {
                    backUpList[x].TmSp = backUpList[x].Date - DateTime.Now;
                    if ((backUpList[x].TSTotalSeconds <= 0 && backUpList[x].TSTotalSeconds > -0.200))
                    {
                        Tools.doBackUp(backUpList[x], notifyIcon_Main, backUpList, saveFile, dtgrdvDisplay);


                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "  timespanerror");
            }

        }

        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            BackUp bk = new BackUp(fromPath.SelectedPath, toPath.SelectedPath, txtbJob.Text, DateTime.Now, cbxList[cbx_Mode.SelectedIndex].Mode, (int)nmr_Repeat.Value, cbxList[cbx_Mode.SelectedIndex].Descr);
            backUpList.Add(bk);
            Tools.doBackUp(bk, notifyIcon_Main, backUpList, saveFile, dtgrdvDisplay);
        }

        

        private void btnFrom_Click(object sender, EventArgs e)
        {

            fromPath.ShowDialog();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            checkForAlarm();
            lblFrom.Text = fromPath.SelectedPath;
            lblTo.Text = toPath.SelectedPath;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tmrFilesCheck.Start();


            dtgrdvDisplay.AllowUserToAddRows = false;
            notifyIcon_Main.Visible = true;
            menuMain.BackColor = Color.CadetBlue;
            this.BackColor = Color.MediumTurquoise;
            pnlControls.BackColor = Color.CadetBlue;
            dtgrdvDisplay.BackgroundColor = Color.CadetBlue;
            Tools.LoadBackup(savePath, backUpList, saveFile, dtgrdvDisplay);
            
        }
        

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            Tools.SaveBackUp(backUpList, saveFile);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            notifyIcon_Main.BalloonTipTitle = "Minimized to Tray App";
            notifyIcon_Main.BalloonTipText = "Double Click to show again.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon_Main.Visible = true;
                notifyIcon_Main.ShowBalloonTip(500);
                this.Hide();
            }
        }


        private void ntfMnu_Exit_Click(object sender, EventArgs e)
        {
            Tools.SaveBackUp(backUpList, saveFile);
            notifyIcon_Main.Visible = false;
            Environment.Exit(1);
        }

        private void ntfMnu_RunWithWindows_Click(object sender, EventArgs e)
        {
            mnu_StartWithWindows.Checked = !mnu_StartWithWindows.Checked;
            ntfMnu_RunWithWindows.Checked = !ntfMnu_RunWithWindows.Checked;
            if (mnu_StartWithWindows.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("MyApp", Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("MyApp", false);
            }
        }

        private void notifyIcon_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void lstbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnRun.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dtgrdvDisplay.SelectedRows)
                {  
                    dtgrdvDisplay.Rows.Remove(row);
                    backUpList.Remove(backUpList[row.Index]);
                }

            }
            catch
            {

            }
        }

        private void dtgrdvDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //foreach (DataGridCell cell in dtgrdvDisplay.SelectedCells)
            //{
            //    frmHistory form = new frmHistory(backUpList[cell.RowNumber].historyList, backUpList[cell.RowNumber].descr); ;
            //}

            //for(int i = dtgrdvDisplay.SelectedCells.Count -1; i >= 0; i--)
            //{
            //    frmHistory form = new frmHistory(backUpList[i].historyList, backUpList[i].descr);
            //    form.Show();
            //}
            //for (int i = 0; i < dtgrdvDisplay.SelectedCells.Count; i++)
            //{
            //    frmHistory form = new frmHistory(backUpList[i].historyList, backUpList[i].descr);
            //    form.Show();
            //}
            
            frmHistory form = new frmHistory(backUpList[e.RowIndex].historyList, backUpList[e.RowIndex].descr);
            form.Show();

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgrdvDisplay.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        Tools.doBackUp(backUpList[row.Index], notifyIcon_Main, backUpList, saveFile, dtgrdvDisplay);
                    }
                }

            }
            catch
            {

            }
        }

        private void mnu_Load_Click(object sender, EventArgs e)
        {

        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Tools.SaveBackUp(backUpList, saveFile);
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            toPath.ShowDialog();
        }

        ///
        /// <summary>
        /// Methods/ Events From BackUpTimer Form Start
        /// </summary>
        /// 

    }
}

