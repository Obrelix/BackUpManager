﻿namespace BackUpManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_NewAlarm = new System.Windows.Forms.Panel();
            this.nmr_Repeat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Mode = new System.Windows.Forms.ComboBox();
            this.btn_BackUp = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.dtgrdvDisplay = new System.Windows.Forms.DataGridView();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_StartWithWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.pnl_NewAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Repeat)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvDisplay)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtbJob);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 28);
            this.panel1.TabIndex = 13;
            // 
            // txtbJob
            // 
            this.txtbJob.Location = new System.Drawing.Point(99, 3);
            this.txtbJob.Name = "txtbJob";
            this.txtbJob.Size = new System.Drawing.Size(149, 20);
            this.txtbJob.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.pnl_NewAlarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_NewAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_NewAlarm.Controls.Add(this.nmr_Repeat);
            this.pnl_NewAlarm.Controls.Add(this.label6);
            this.pnl_NewAlarm.Controls.Add(this.cbx_Mode);
            this.pnl_NewAlarm.Location = new System.Drawing.Point(3, 81);
            this.pnl_NewAlarm.Name = "pnl_NewAlarm";
            this.pnl_NewAlarm.Size = new System.Drawing.Size(254, 31);
            this.pnl_NewAlarm.TabIndex = 12;
            // 
            // nmr_Repeat
            // 
            this.nmr_Repeat.Location = new System.Drawing.Point(101, 5);
            this.nmr_Repeat.Name = "nmr_Repeat";
            this.nmr_Repeat.Size = new System.Drawing.Size(45, 20);
            this.nmr_Repeat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.cbx_Mode.Location = new System.Drawing.Point(152, 5);
            this.cbx_Mode.Name = "cbx_Mode";
            this.cbx_Mode.Size = new System.Drawing.Size(96, 21);
            this.cbx_Mode.TabIndex = 12;
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_BackUp.Location = new System.Drawing.Point(162, 111);
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Size = new System.Drawing.Size(95, 23);
            this.btn_BackUp.TabIndex = 10;
            this.btn_BackUp.Text = "Back Up";
            this.btn_BackUp.UseVisualStyleBackColor = false;
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.AutoEllipsis = true;
            this.btnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrom.Location = new System.Drawing.Point(100, -1);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(45, 23);
            this.btnFrom.TabIndex = 20;
            this.btnFrom.Text = "...";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnTo
            // 
            this.btnTo.AutoEllipsis = true;
            this.btnTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo.Location = new System.Drawing.Point(100, 23);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(45, 23);
            this.btnTo.TabIndex = 22;
            this.btnTo.Text = "...";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.lblTo);
            this.pnlControls.Controls.Add(this.btn_BackUp);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Controls.Add(this.pnl_NewAlarm);
            this.pnlControls.Controls.Add(this.lblFrom);
            this.pnlControls.Controls.Add(this.label9);
            this.pnlControls.Controls.Add(this.btnTo);
            this.pnlControls.Controls.Add(this.label8);
            this.pnlControls.Controls.Add(this.btnFrom);
            this.pnlControls.Location = new System.Drawing.Point(12, 235);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(730, 135);
            this.pnlControls.TabIndex = 14;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTo.Location = new System.Drawing.Point(150, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFrom.Location = new System.Drawing.Point(151, 4);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(7, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Copy Files To :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(7, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Copy Files From :";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // dtgrdvDisplay
            // 
            this.dtgrdvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdvDisplay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgrdvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvDisplay.Location = new System.Drawing.Point(12, 27);
            this.dtgrdvDisplay.Name = "dtgrdvDisplay";
            this.dtgrdvDisplay.Size = new System.Drawing.Size(730, 202);
            this.dtgrdvDisplay.TabIndex = 15;
            this.dtgrdvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvDisplay_CellContentClick);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(754, 24);
            this.menuMain.TabIndex = 16;
            this.menuMain.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Load,
            this.mnu_StartWithWindows});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // mnu_Load
            // 
            this.mnu_Load.Name = "mnu_Load";
            this.mnu_Load.Size = new System.Drawing.Size(176, 22);
            this.mnu_Load.Text = "&Load BackUp";
            // 
            // mnu_StartWithWindows
            // 
            this.mnu_StartWithWindows.Checked = true;
            this.mnu_StartWithWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_StartWithWindows.Name = "mnu_StartWithWindows";
            this.mnu_StartWithWindows.Size = new System.Drawing.Size(176, 22);
            this.mnu_StartWithWindows.Text = "Start with Windows";
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
            this.mnu_About.Size = new System.Drawing.Size(152, 22);
            this.mnu_About.Text = "A&bout";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "Backup Manager";
            this.notifyIcon_Main.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 382);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.dtgrdvDisplay);
            this.Controls.Add(this.pnlControls);
            this.Name = "Main";
            this.Text = "Back Up Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_NewAlarm.ResumeLayout(false);
            this.pnl_NewAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Repeat)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvDisplay)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_NewAlarm;
        private System.Windows.Forms.NumericUpDown nmr_Repeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Mode;
        private System.Windows.Forms.Button btn_BackUp;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgrdvDisplay;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Load;
        private System.Windows.Forms.ToolStripMenuItem mnu_StartWithWindows;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon_Main;
    }
}

