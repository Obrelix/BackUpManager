namespace BackUpMe
{
    partial class frmBackUpPersonalFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUpPersonalFiles));
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDesk = new System.Windows.Forms.CheckBox();
            this.chkDL = new System.Windows.Forms.CheckBox();
            this.chkDoc = new System.Windows.Forms.CheckBox();
            this.chkVid = new System.Windows.Forms.CheckBox();
            this.chkMus = new System.Windows.Forms.CheckBox();
            this.chkPic = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblCurCopiedFiles = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.tmrFilesCheck = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(12, 29);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(488, 20);
            this.txtDestinationPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose target path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(506, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDesk);
            this.groupBox1.Controls.Add(this.chkDL);
            this.groupBox1.Controls.Add(this.chkDoc);
            this.groupBox1.Controls.Add(this.chkVid);
            this.groupBox1.Controls.Add(this.chkMus);
            this.groupBox1.Controls.Add(this.chkPic);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose what do you want to copy";
            // 
            // chkDesk
            // 
            this.chkDesk.AutoSize = true;
            this.chkDesk.Checked = true;
            this.chkDesk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDesk.Location = new System.Drawing.Point(434, 19);
            this.chkDesk.Name = "chkDesk";
            this.chkDesk.Size = new System.Drawing.Size(66, 17);
            this.chkDesk.TabIndex = 5;
            this.chkDesk.Text = "Desktop";
            this.chkDesk.UseVisualStyleBackColor = true;
            this.chkDesk.Click += new System.EventHandler(this.chkDesk_Click);
            // 
            // chkDL
            // 
            this.chkDL.AutoSize = true;
            this.chkDL.Checked = true;
            this.chkDL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDL.Location = new System.Drawing.Point(349, 19);
            this.chkDL.Name = "chkDL";
            this.chkDL.Size = new System.Drawing.Size(79, 17);
            this.chkDL.TabIndex = 4;
            this.chkDL.Text = "Downloads";
            this.chkDL.UseVisualStyleBackColor = true;
            this.chkDL.Click += new System.EventHandler(this.chkDL_Click);
            // 
            // chkDoc
            // 
            this.chkDoc.AutoSize = true;
            this.chkDoc.Checked = true;
            this.chkDoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDoc.Location = new System.Drawing.Point(263, 19);
            this.chkDoc.Name = "chkDoc";
            this.chkDoc.Size = new System.Drawing.Size(80, 17);
            this.chkDoc.TabIndex = 3;
            this.chkDoc.Text = "Documents";
            this.chkDoc.UseVisualStyleBackColor = true;
            this.chkDoc.Click += new System.EventHandler(this.chkDoc_Click);
            // 
            // chkVid
            // 
            this.chkVid.AutoSize = true;
            this.chkVid.Checked = true;
            this.chkVid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVid.Location = new System.Drawing.Point(199, 19);
            this.chkVid.Name = "chkVid";
            this.chkVid.Size = new System.Drawing.Size(58, 17);
            this.chkVid.TabIndex = 2;
            this.chkVid.Text = "Videos";
            this.chkVid.UseVisualStyleBackColor = true;
            this.chkVid.Click += new System.EventHandler(this.chkVid_Click);
            // 
            // chkMus
            // 
            this.chkMus.AutoSize = true;
            this.chkMus.Checked = true;
            this.chkMus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMus.Location = new System.Drawing.Point(139, 19);
            this.chkMus.Name = "chkMus";
            this.chkMus.Size = new System.Drawing.Size(54, 17);
            this.chkMus.TabIndex = 1;
            this.chkMus.Text = "Music";
            this.chkMus.UseVisualStyleBackColor = true;
            this.chkMus.Click += new System.EventHandler(this.chkMus_Click);
            // 
            // chkPic
            // 
            this.chkPic.AutoSize = true;
            this.chkPic.Checked = true;
            this.chkPic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPic.Location = new System.Drawing.Point(69, 19);
            this.chkPic.Name = "chkPic";
            this.chkPic.Size = new System.Drawing.Size(64, 17);
            this.chkPic.TabIndex = 0;
            this.chkPic.Text = "Pictures";
            this.chkPic.UseVisualStyleBackColor = true;
            this.chkPic.Click += new System.EventHandler(this.chkPic_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(12, 161);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 5;
            this.lblFiles.Text = "Files:";
            // 
            // lblCurCopiedFiles
            // 
            this.lblCurCopiedFiles.AutoSize = true;
            this.lblCurCopiedFiles.Location = new System.Drawing.Point(181, 161);
            this.lblCurCopiedFiles.Name = "lblCurCopiedFiles";
            this.lblCurCopiedFiles.Size = new System.Drawing.Size(100, 13);
            this.lblCurCopiedFiles.TabIndex = 6;
            this.lblCurCopiedFiles.Text = "Current copied files:";
            this.lblCurCopiedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 207);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Interval = 10;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // tmrFilesCheck
            // 
            this.tmrFilesCheck.Enabled = true;
            this.tmrFilesCheck.Interval = 1000;
            this.tmrFilesCheck.Tick += new System.EventHandler(this.tmrFilesCheck_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // frmBackUpPersonalFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 256);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblCurCopiedFiles);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestinationPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackUpPersonalFiles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDesk;
        private System.Windows.Forms.CheckBox chkDL;
        private System.Windows.Forms.CheckBox chkDoc;
        private System.Windows.Forms.CheckBox chkVid;
        private System.Windows.Forms.CheckBox chkMus;
        private System.Windows.Forms.CheckBox chkPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblCurCopiedFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Timer tmrFilesCheck;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

