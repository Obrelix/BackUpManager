using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpMe
{
    public partial class Progress : Form
    {
        int files;
        string path;
        int destFile, bubble;

        public Progress(int files, string path)
        {
            InitializeComponent();
            this.files = files;
            this.path = path;
            prbFiles.Maximum = files;
            tmr.Start();
            //label1.Text = string.Format("Copied Files: {0}", files);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {

            if (prbFiles.Value != files)
            {

                try
                {
                    if ((destFile + 1) == Directory.GetFiles(path).Length)
                    {
                        destFile = Directory.GetFiles(path).Length;
                        prbFiles.Value += 1;

                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }


    }
}
