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

namespace BackUpManager
{
    public partial class Main : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        FolderBrowserDialog fromPath = new FolderBrowserDialog();
        FolderBrowserDialog toPath = new FolderBrowserDialog();
        string pathFrom = string.Empty, pathTo= string.Empty;
        List<BackUp> backUpList = new List<BackUp>();
        List<ListId> cbxList = new List<ListId>();
        static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BackUpManager";
        static string saveFile = savePath + "\\BackupSaves.json";


        private void checkForAlarm()
        {
            try
            {
                //Έλεγξε  τον χρόνο που απομένει για κάθε Ξυπνητήρι και περασέ τον στην λιστα
                for (int x = 0; x < backUpList.Count; x++)
                {
                    backUpList[x].TmSp = backUpList[x].Date - DateTime.Now;
                    //Aν κάποιο ξυπνητήρι ενεργοποιηθεί 
                    if ((backUpList[x].TSTotalSeconds <= 0 && backUpList[x].TSTotalSeconds > -0.200))
                    {
                        doBackUp(backUpList[x].descr, backUpList[x].pathFrom, backUpList[x].pathTo);
                        backUpList[x].lastRun = DateTime.Now.ToString();
                        backUpList[x].historyList.Add(DateTime.Now);
                        BackUp.AddExtraTime(backUpList[x]);
                        listBoxRefresh();

                        
                        notifyIcon_Main.BalloonTipTitle = "New Backup Created";
                        notifyIcon_Main.BalloonTipText = backUpList[x].descr +
                            Environment.NewLine + "From:" + backUpList[x].pathFrom +
                            Environment.NewLine + "To:" + backUpList[x].pathTo;
                        notifyIcon_Main.ShowBalloonTip(500);
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

            bk.historyList.Add(DateTime.Now);
            doBackUp(bk.descr, bk.pathFrom, bk.pathTo);
            backUpList.Add(bk);
            listBoxRefresh();
            gridRefresh();
            SaveBackUp();
        }

        private void doBackUp(string name, string fromPath, string toPath)
        {
            string dirPath = toPath + "/" + name  + "_Backup_" + 
               DateTime.Now.Day + "-" +
               DateTime.Now.Month + "-" +
               DateTime.Now.Year + "_" +
               DateTime.Now.Hour + "_" +
               DateTime.Now.Minute + "_" +
               DateTime.Now.Second;
            try
            {
                Tools.DirectoryCopy(fromPath , dirPath, true);
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
            dtgrdvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdvDisplay.Columns[0].Name = "Backup Job Name";
            dtgrdvDisplay.Columns[1].Name = "Origin";
            dtgrdvDisplay.Columns[2].Name = "Destination";
            dtgrdvDisplay.Columns[3].Name = "Schedule";
            dtgrdvDisplay.Columns[4].Name = "Last Run";

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
            
            lstbHistory.BackColor = Color.MediumTurquoise;
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
            listBoxRefresh();
        }

        private void listBoxRefresh()
        {
            lstbHistory.Items.Clear();
            foreach (BackUp bk in backUpList)
            {
                lstbHistory.Items.Add(bk);
            }
        }

        private void LoadBackup()
        {

            try
            {
                backUpList.Clear();
                backUpList = JsonConvert.DeserializeObject<List<BackUp>>(System.IO.File.ReadAllText(saveFile));
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
                //Καταχώρησε στην μεταβλητή contentsToWriteToFile τα στοιχεία της λίστας ξυπνητηριών
                string contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(backUpList.ToArray(), Newtonsoft.Json.Formatting.Indented);

                //Πέρασε στο Json την παραπάνω μεταβλητή
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

        private void dtgrdvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("LALALALAL");
        }

        private void mnu_Load_Click(object sender, EventArgs e)
        {

        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ακύρωσε την κληση για κλείσιμο της φόρμας
            e.Cancel = true;
            //Κάνε minimize την φόρμα
            this.WindowState = FormWindowState.Minimized;
            //Σώσε τα τρέχοντα ξυπνητήρια στο αρχείο Json
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

        private void btnTo_Click(object sender, EventArgs e)
        {
            
            toPath.ShowDialog();
        }
        
    }
}
