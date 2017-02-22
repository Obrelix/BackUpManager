using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpManager.Forms
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }

        public frmHistory(List<DateTime> dateList, string name)
        {
            InitializeComponent();
            this.Text = name + " Back Up History";
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Time";
            dataGridView1.Font = new Font(FontFamily.GenericSansSerif, 9.0F, FontStyle.Bold);
            string[] row = new string[2];
            foreach (DateTime dt in dateList)
            {
                row[0] = dt.ToShortDateString();
                row[1] = dt.ToLongTimeString();
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
