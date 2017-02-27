using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpManager
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }

        public frmHistory(List<BackUpHistory> hisList, string name)
        {
            InitializeComponent();
            this.Text = name + " Back Up History";
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Time";
            dataGridView1.Columns[2].Name = "Done";
            dataGridView1.Columns[3].Name = "Size" + " (MB)";
            dataGridView1.Columns[4].Name = "Files Copied";

            dataGridView1.Font = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
            string[] row = new string[5];
            foreach (BackUpHistory bkh in hisList)
            {
                row[0] = bkh.date;
                row[1] = bkh.time;
                row[2] = bkh.done.ToString();
                row[3] = bkh.size.ToString() ;
                row[4] = bkh.files.ToString();
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
