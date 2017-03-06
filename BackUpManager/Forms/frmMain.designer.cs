namespace BackUpManager
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCurCopiedFiles = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDesk = new System.Windows.Forms.CheckBox();
            this.chkDL = new System.Windows.Forms.CheckBox();
            this.chkDoc = new System.Windows.Forms.CheckBox();
            this.chkVid = new System.Windows.Forms.CheckBox();
            this.chkMus = new System.Windows.Forms.CheckBox();
            this.chkPic = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_NewAlarm = new System.Windows.Forms.Panel();
            this.nmr_Repeat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Mode = new System.Windows.Forms.ComboBox();
            this.btn_BackUp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dtgrdvDisplay = new System.Windows.Forms.DataGridView();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.tmrFilesCheck = new System.Windows.Forms.Timer(this.components);
            this.mnu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.ntfMnu_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ntfMnu_RunWithWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ntfMnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfMnu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ntfMnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfMnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxMnu_Intreval = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInt_Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_StartWithWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_NewAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Repeat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvDisplay)).BeginInit();
            this.ntfMnu_Menu.SuspendLayout();
            this.cntxMnu_Intreval.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.lblCurCopiedFiles);
            this.tabPage1.Controls.Add(this.lblFiles);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDestinationPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BackUp Personal Files";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(136, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // lblCurCopiedFiles
            // 
            this.lblCurCopiedFiles.AutoSize = true;
            this.lblCurCopiedFiles.Location = new System.Drawing.Point(302, 233);
            this.lblCurCopiedFiles.Name = "lblCurCopiedFiles";
            this.lblCurCopiedFiles.Size = new System.Drawing.Size(100, 13);
            this.lblCurCopiedFiles.TabIndex = 15;
            this.lblCurCopiedFiles.Text = "Current copied files:";
            this.lblCurCopiedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(133, 233);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 14;
            this.lblFiles.Text = "Files:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDesk);
            this.groupBox1.Controls.Add(this.chkDL);
            this.groupBox1.Controls.Add(this.chkDoc);
            this.groupBox1.Controls.Add(this.chkVid);
            this.groupBox1.Controls.Add(this.chkMus);
            this.groupBox1.Controls.Add(this.chkPic);
            this.groupBox1.Location = new System.Drawing.Point(133, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 56);
            this.groupBox1.TabIndex = 12;
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
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(627, 99);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose target path:";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(133, 101);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(488, 20);
            this.txtDestinationPath.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabPage2.Controls.Add(this.pnlControls);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BackUp Timer";
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.panel2);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Controls.Add(this.pnl_NewAlarm);
            this.pnlControls.Controls.Add(this.btn_BackUp);
            this.pnlControls.Location = new System.Drawing.Point(25, 250);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(788, 71);
            this.pnlControls.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblTo);
            this.panel2.Controls.Add(this.btnFrom);
            this.panel2.Controls.Add(this.btnTo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblFrom);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 61);
            this.panel2.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "BackUp From:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTo.Location = new System.Drawing.Point(191, 38);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "To";
            // 
            // btnFrom
            // 
            this.btnFrom.AutoEllipsis = true;
            this.btnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnFrom.Location = new System.Drawing.Point(84, 3);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(83, 23);
            this.btnFrom.TabIndex = 20;
            this.btnFrom.Text = "Browse...";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnTo
            // 
            this.btnTo.AutoEllipsis = true;
            this.btnTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnTo.Location = new System.Drawing.Point(261, 2);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(84, 23);
            this.btnTo.TabIndex = 22;
            this.btnTo.Text = "Browse...";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(191, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "BackUp To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.SkyBlue;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFrom.Location = new System.Drawing.Point(3, 37);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "From";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtbJob);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(395, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 28);
            this.panel1.TabIndex = 13;
            // 
            // txtbJob
            // 
            this.txtbJob.Location = new System.Drawing.Point(104, 3);
            this.txtbJob.Name = "txtbJob";
            this.txtbJob.Size = new System.Drawing.Size(279, 20);
            this.txtbJob.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Backup Job Name";
            // 
            // pnl_NewAlarm
            // 
            this.pnl_NewAlarm.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_NewAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_NewAlarm.Controls.Add(this.nmr_Repeat);
            this.pnl_NewAlarm.Controls.Add(this.label6);
            this.pnl_NewAlarm.Controls.Add(this.cbx_Mode);
            this.pnl_NewAlarm.Location = new System.Drawing.Point(395, 33);
            this.pnl_NewAlarm.Name = "pnl_NewAlarm";
            this.pnl_NewAlarm.Size = new System.Drawing.Size(289, 31);
            this.pnl_NewAlarm.TabIndex = 12;
            // 
            // nmr_Repeat
            // 
            this.nmr_Repeat.Location = new System.Drawing.Point(104, 6);
            this.nmr_Repeat.Name = "nmr_Repeat";
            this.nmr_Repeat.Size = new System.Drawing.Size(45, 20);
            this.nmr_Repeat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Repeat Every:";
            // 
            // cbx_Mode
            // 
            this.cbx_Mode.FormattingEnabled = true;
            this.cbx_Mode.Location = new System.Drawing.Point(155, 5);
            this.cbx_Mode.Name = "cbx_Mode";
            this.cbx_Mode.Size = new System.Drawing.Size(129, 21);
            this.cbx_Mode.TabIndex = 12;
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_BackUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_BackUp.Location = new System.Drawing.Point(690, 32);
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Size = new System.Drawing.Size(93, 34);
            this.btn_BackUp.TabIndex = 10;
            this.btn_BackUp.Text = "Create";
            this.btn_BackUp.UseVisualStyleBackColor = false;
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRun);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.dtgrdvDisplay);
            this.panel3.Location = new System.Drawing.Point(25, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 203);
            this.panel3.TabIndex = 30;
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(3, 167);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 31);
            this.btnRun.TabIndex = 27;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(708, 167);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 31);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dtgrdvDisplay
            // 
            this.dtgrdvDisplay.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrdvDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdvDisplay.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dtgrdvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdvDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdvDisplay.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgrdvDisplay.Location = new System.Drawing.Point(3, 3);
            this.dtgrdvDisplay.Name = "dtgrdvDisplay";
            this.dtgrdvDisplay.ReadOnly = true;
            this.dtgrdvDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrdvDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrdvDisplay.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Teal;
            this.dtgrdvDisplay.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dtgrdvDisplay.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgrdvDisplay.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dtgrdvDisplay.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrdvDisplay.RowTemplate.DividerHeight = 1;
            this.dtgrdvDisplay.RowTemplate.ReadOnly = true;
            this.dtgrdvDisplay.Size = new System.Drawing.Size(780, 158);
            this.dtgrdvDisplay.TabIndex = 15;
           this.dtgrdvDisplay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvDisplay_CellDoubleClick);
            this.dtgrdvDisplay.SelectionChanged += new System.EventHandler(this.lstbHistory_SelectedIndexChanged);
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
            // mnu_Load
            // 
            this.mnu_Load.Name = "mnu_Load";
            this.mnu_Load.Size = new System.Drawing.Size(180, 22);
            this.mnu_Load.Text = "&Load BackUp Profile";
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(107, 22);
            this.mnu_About.Text = "A&bout";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.ntfMnu_Menu;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "Backup Manager";
            this.notifyIcon_Main.Visible = true;
            this.notifyIcon_Main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Main_MouseDoubleClick);
            // 
            // ntfMnu_Menu
            // 
            this.ntfMnu_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ntfMnu_RunWithWindows,
            this.toolStripSeparator1,
            this.ntfMnu_Save,
            this.ntfMnu_Load,
            this.toolStripSeparator2,
            this.ntfMnu_About,
            this.ntfMnu_Exit});
            this.ntfMnu_Menu.Name = "ntfMnu_Menu";
            this.ntfMnu_Menu.Size = new System.Drawing.Size(174, 126);
            // 
            // ntfMnu_RunWithWindows
            // 
            this.ntfMnu_RunWithWindows.Checked = true;
            this.ntfMnu_RunWithWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ntfMnu_RunWithWindows.Name = "ntfMnu_RunWithWindows";
            this.ntfMnu_RunWithWindows.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_RunWithWindows.Text = "Run with Windows";
            this.ntfMnu_RunWithWindows.Click += new System.EventHandler(this.ntfMnu_RunWithWindows_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // ntfMnu_Save
            // 
            this.ntfMnu_Save.Name = "ntfMnu_Save";
            this.ntfMnu_Save.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_Save.Text = "Save";
            // 
            // ntfMnu_Load
            // 
            this.ntfMnu_Load.Name = "ntfMnu_Load";
            this.ntfMnu_Load.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_Load.Text = "Load";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // ntfMnu_About
            // 
            this.ntfMnu_About.Name = "ntfMnu_About";
            this.ntfMnu_About.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_About.Text = "About";
            // 
            // ntfMnu_Exit
            // 
            this.ntfMnu_Exit.Name = "ntfMnu_Exit";
            this.ntfMnu_Exit.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_Exit.Text = "Exit";
            this.ntfMnu_Exit.Click += new System.EventHandler(this.ntfMnu_Exit_Click);
            // 
            // cntxMnu_Intreval
            // 
            this.cntxMnu_Intreval.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInt_Minimize,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.cntxMnu_Intreval.Name = "contextMenuStrip1";
            this.cntxMnu_Intreval.Size = new System.Drawing.Size(163, 70);
            this.cntxMnu_Intreval.Text = "Menu";
            // 
            // mnuInt_Minimize
            // 
            this.mnuInt_Minimize.Name = "mnuInt_Minimize";
            this.mnuInt_Minimize.Size = new System.Drawing.Size(162, 22);
            this.mnuInt_Minimize.Text = "Minimize to Tray";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // mnu_StartWithWindows
            // 
            this.mnu_StartWithWindows.Checked = true;
            this.mnu_StartWithWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_StartWithWindows.Name = "mnu_StartWithWindows";
            this.mnu_StartWithWindows.Size = new System.Drawing.Size(180, 22);
            this.mnu_StartWithWindows.Text = "Start with Windows";
            this.mnu_StartWithWindows.Click += new System.EventHandler(this.ntfMnu_RunWithWindows_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Load,
            this.mnu_StartWithWindows,
            this.minimizeToTrayToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.PowderBlue;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(867, 24);
            this.menuMain.TabIndex = 29;
            this.menuMain.Text = "Menu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(867, 451);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "frmStartWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_NewAlarm.ResumeLayout(false);
            this.pnl_NewAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Repeat)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvDisplay)).EndInit();
            this.ntfMnu_Menu.ResumeLayout(false);
            this.cntxMnu_Intreval.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCurCopiedFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDesk;
        private System.Windows.Forms.CheckBox chkDL;
        private System.Windows.Forms.CheckBox chkDoc;
        private System.Windows.Forms.CheckBox chkVid;
        private System.Windows.Forms.CheckBox chkMus;
        private System.Windows.Forms.CheckBox chkPic;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Timer tmrFilesCheck;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_NewAlarm;
        private System.Windows.Forms.NumericUpDown nmr_Repeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Mode;
        private System.Windows.Forms.Button btn_BackUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dtgrdvDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnu_Load;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon_Main;
        private System.Windows.Forms.ContextMenuStrip ntfMnu_Menu;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_RunWithWindows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_Save;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_Load;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_About;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_Exit;
        private System.Windows.Forms.ContextMenuStrip cntxMnu_Intreval;
        private System.Windows.Forms.ToolStripMenuItem mnuInt_Minimize;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_StartWithWindows;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.MenuStrip menuMain;
    }
}