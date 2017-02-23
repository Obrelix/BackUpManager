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
using Newtonsoft.Json;
using Microsoft.Win32;
using BackUpManager.Forms;
namespace BackUpManager
{
    public partial class Main : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        FolderBrowserDialog fromPath = new FolderBrowserDialog();
        FolderBrowserDialog toPath = new FolderBrowserDialog();
        string pathFrom = string.Empty, pathTo= string.Empty;
        public static List<BackUp> backUpList = new List<BackUp>();
        public static int listIndex;
        List<ListId> cbxList = new List<ListId>();
        

        static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BackUpManager";
        static string saveFile = savePath + "\\BackupSaves.json";
        

        private void checkForAlarm()
        {
            try
            {
                for (int x = 0; x < backUpList.Count; x++)
                {
                    backUpList[x].TmSp = backUpList[x].Date - DateTime.Now;
                    if ((backUpList[x].TSTotalSeconds <= 0 && backUpList[x].TSTotalSeconds > -0.200))
                    {
                        doBackUp(backUpList[x]);


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
            doBackUp(bk);
        }

        private void doBackUp(BackUp obj)
        {
            string dirPath = obj.pathTo + "/" + obj.descr  + "_Backup_" + 
               DateTime.Now.Day + "-" +
               DateTime.Now.Month + "-" +
               DateTime.Now.Year + "_" +
               DateTime.Now.Hour + "_" +
               DateTime.Now.Minute + "_" +
               DateTime.Now.Second;
            try
            {
                Tools.DirectoryCopy(obj.pathFrom , dirPath, true);

                notifyIcon_Main.BalloonTipTitle = "New Backup Created";
                notifyIcon_Main.BalloonTipText = obj.descr +
                    Environment.NewLine + "From:" + obj.pathFrom +
                    Environment.NewLine + "To:" + obj.pathTo;
                notifyIcon_Main.ShowBalloonTip(500);
                DirectoryInfo di = new DirectoryInfo(obj.pathFrom);
                obj.size = di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
                obj.size /= 1024;
                obj.size /= 1024;
                obj.size = Math.Round(obj.size, 2);
                obj.files = Directory.GetFiles(obj.pathFrom, "*.*", SearchOption.AllDirectories).Length;
                obj.historyDateList.Add(obj.Date);
                obj.historyList.Add(new BackUpHistory(obj.Date, true, obj.size, obj.files));
                BackUp.AddExtraTime(obj);
                obj.displayInit();

                gridRefresh();
                SaveBackUp();
            }
            catch
            {

            }
        }

       

        public Main()
        {
            InitializeComponent();

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
            notifyIcon_Main.Visible = true;
            menuMain.BackColor = Color.CadetBlue;
            this.BackColor = Color.MediumTurquoise;
            pnlControls.BackColor = Color.CadetBlue;
            dtgrdvDisplay.BackgroundColor = Color.CadetBlue;
            Directory.CreateDirectory(savePath);
            if (File.Exists(saveFile))
            {
                LoadBackup();
                gridRefresh();
            }
            else
            {
                using (System.IO.FileStream fs = System.IO.File.Create(saveFile))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
        }

        private void enableBackups()
        {
            foreach (BackUp bk in backUpList)
            {
                if (bk.Mode != 5)
                {
                    while (DateTime.Compare(bk.Date, DateTime.Now) < 0)
                    {
                        bk.historyList.Add(new BackUpHistory(bk.Date, false, 0, 0));
                        BackUp.AddExtraTime(bk);
                    }
                }
            }
        }

        private void LoadBackup()
        {

            try
            {
                backUpList.Clear();
                backUpList = JsonConvert.DeserializeObject<List<BackUp>>(System.IO.File.ReadAllText(saveFile));
                enableBackups();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void SaveBackUp()
        {

            try
            {
                string contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(backUpList.ToArray(), Newtonsoft.Json.Formatting.Indented);
                
                System.IO.File.WriteAllText(saveFile, contentsToWriteToFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       

        private void gridRefresh()
        {
            
            dtgrdvDisplay.Rows.Clear();
            foreach (BackUp obj in backUpList)
            {
                dtgrdvDisplay.Rows.Add(obj.display);
            }

        }
        
        

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            SaveBackUp();
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
            SaveBackUp();
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
                    if (!row.IsNewRow)
                    {
                        backUpList.Remove(backUpList[row.Index]);
                        dtgrdvDisplay.Rows.Remove(row);

                    }
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
                        doBackUp(backUpList[row.Index]);
                    }
                }

            }
            catch
            {

            }
        }
        

        private void btnTo_Click(object sender, EventArgs e)
        {
            toPath.ShowDialog();
        }
        
    }
}
