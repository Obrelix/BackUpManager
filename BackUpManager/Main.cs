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

namespace BackUpManager
{
    public partial class Main : Form
    {

        FolderBrowserDialog fromPath = new FolderBrowserDialog();
        FolderBrowserDialog toPath = new FolderBrowserDialog();
        string pathFrom = string.Empty, pathTo= string.Empty;
        List<BackUp> backUpList = new List<BackUp>();
        List<ListId> cbxList = new List<ListId>();
        static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BackUpManager";
        static string saveFile = savePath + "\\BackupSaves.json";

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
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            
            fromPath.ShowDialog();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblFrom.Text = fromPath.SelectedPath;
            lblTo.Text = toPath.SelectedPath;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SlateBlue;
            pnlControls.BackColor = Color.DarkCyan;
            dtgrdvDisplay.BackgroundColor = Color.DarkCyan;
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


        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            backUpList.Add(new BackUp(fromPath.SelectedPath, toPath.SelectedPath, txtbJob.Text, DateTime.Now, cbxList[cbx_Mode.SelectedIndex].Mode, (int)nmr_Repeat.Value, cbxList[cbx_Mode.SelectedIndex].Descr));
            gridRefresh();
            SaveBackUp();
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

        private void btnTo_Click(object sender, EventArgs e)
        {
            
            toPath.ShowDialog();
        }
        
    }
}
