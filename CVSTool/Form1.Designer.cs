namespace CVSTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabConServerLog = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StatusSMS = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMeterLiveLog = new System.Windows.Forms.DataGridView();
            this.tpgSendMsgLog = new System.Windows.Forms.TabPage();
            this.dgrSendMsgLog = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvEPILog = new System.Windows.Forms.DataGridView();
            this.btnStartService = new System.Windows.Forms.Button();
            this.显示ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnExportEnergyAlarmlist = new System.Windows.Forms.Button();
            this.btnReadEnergyAlarmlist = new System.Windows.Forms.Button();
            this.btnReadSendMsgList = new System.Windows.Forms.Button();
            this.btnExportMeterAlarmList = new System.Windows.Forms.Button();
            this.btnReadAlarmList = new System.Windows.Forms.Button();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2.SuspendLayout();
            this.tabConServerLog.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterLiveLog)).BeginInit();
            this.tpgSendMsgLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSendMsgLog)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEPILog)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabConServerLog);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1142, 483);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态显示";
            // 
            // tabConServerLog
            // 
            this.tabConServerLog.Controls.Add(this.tabPage1);
            this.tabConServerLog.Controls.Add(this.tabPage2);
            this.tabConServerLog.Controls.Add(this.tpgSendMsgLog);
            this.tabConServerLog.Controls.Add(this.tabPage3);
            this.tabConServerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConServerLog.Location = new System.Drawing.Point(3, 17);
            this.tabConServerLog.Name = "tabConServerLog";
            this.tabConServerLog.SelectedIndex = 0;
            this.tabConServerLog.Size = new System.Drawing.Size(1136, 463);
            this.tabConServerLog.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StatusSMS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "服务日志";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StatusSMS
            // 
            this.StatusSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusSMS.Location = new System.Drawing.Point(3, 3);
            this.StatusSMS.Name = "StatusSMS";
            this.StatusSMS.Size = new System.Drawing.Size(1122, 431);
            this.StatusSMS.TabIndex = 24;
            this.StatusSMS.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dgvMeterLiveLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设备报警记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMeterLiveLog
            // 
            this.dgvMeterLiveLog.AllowDrop = true;
            this.dgvMeterLiveLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeterLiveLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMeterLiveLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeterLiveLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeterLiveLog.Location = new System.Drawing.Point(3, 3);
            this.dgvMeterLiveLog.Name = "dgvMeterLiveLog";
            this.dgvMeterLiveLog.RowHeadersWidth = 50;
            this.dgvMeterLiveLog.RowTemplate.Height = 23;
            this.dgvMeterLiveLog.Size = new System.Drawing.Size(1122, 431);
            this.dgvMeterLiveLog.TabIndex = 0;
            // 
            // tpgSendMsgLog
            // 
            this.tpgSendMsgLog.Controls.Add(this.dgrSendMsgLog);
            this.tpgSendMsgLog.Location = new System.Drawing.Point(4, 22);
            this.tpgSendMsgLog.Name = "tpgSendMsgLog";
            this.tpgSendMsgLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSendMsgLog.Size = new System.Drawing.Size(1128, 437);
            this.tpgSendMsgLog.TabIndex = 2;
            this.tpgSendMsgLog.Text = "短信发送记录";
            this.tpgSendMsgLog.UseVisualStyleBackColor = true;
            // 
            // dgrSendMsgLog
            // 
            this.dgrSendMsgLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrSendMsgLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrSendMsgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSendMsgLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrSendMsgLog.Location = new System.Drawing.Point(3, 3);
            this.dgrSendMsgLog.Name = "dgrSendMsgLog";
            this.dgrSendMsgLog.RowHeadersWidth = 10;
            this.dgrSendMsgLog.RowTemplate.Height = 23;
            this.dgrSendMsgLog.Size = new System.Drawing.Size(1122, 431);
            this.dgrSendMsgLog.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvEPILog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1133, 533);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "用能报警记录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvEPILog
            // 
            this.dgvEPILog.AllowDrop = true;
            this.dgvEPILog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEPILog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEPILog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEPILog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEPILog.Location = new System.Drawing.Point(3, 3);
            this.dgvEPILog.Name = "dgvEPILog";
            this.dgvEPILog.RowTemplate.Height = 23;
            this.dgvEPILog.Size = new System.Drawing.Size(1127, 527);
            this.dgvEPILog.TabIndex = 1;
            // 
            // btnStartService
            // 
            this.btnStartService.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartService.Location = new System.Drawing.Point(32, 20);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(90, 41);
            this.btnStartService.TabIndex = 19;
            this.btnStartService.Text = "导出基础数据";
            this.btnStartService.UseVisualStyleBackColor = false;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // 显示ToolStripMenuItem1
            // 
            this.显示ToolStripMenuItem1.Name = "显示ToolStripMenuItem1";
            this.显示ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem1.Text = "显示";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem1,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "短信服务";
            this.notifyIcon1.Visible = true;
            // 
            // btnStopService
            // 
            this.btnStopService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStopService.Location = new System.Drawing.Point(143, 20);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(88, 41);
            this.btnStopService.TabIndex = 17;
            this.btnStopService.Text = "停止服务";
            this.btnStopService.UseVisualStyleBackColor = false;
            // 
            // btnExportEnergyAlarmlist
            // 
            this.btnExportEnergyAlarmlist.BackColor = System.Drawing.SystemColors.Info;
            this.btnExportEnergyAlarmlist.Location = new System.Drawing.Point(780, 17);
            this.btnExportEnergyAlarmlist.Name = "btnExportEnergyAlarmlist";
            this.btnExportEnergyAlarmlist.Size = new System.Drawing.Size(72, 41);
            this.btnExportEnergyAlarmlist.TabIndex = 16;
            this.btnExportEnergyAlarmlist.Text = "导出能耗告警记录";
            this.btnExportEnergyAlarmlist.UseVisualStyleBackColor = false;
            // 
            // btnReadEnergyAlarmlist
            // 
            this.btnReadEnergyAlarmlist.BackColor = System.Drawing.SystemColors.Info;
            this.btnReadEnergyAlarmlist.Location = new System.Drawing.Point(688, 17);
            this.btnReadEnergyAlarmlist.Name = "btnReadEnergyAlarmlist";
            this.btnReadEnergyAlarmlist.Size = new System.Drawing.Size(72, 41);
            this.btnReadEnergyAlarmlist.TabIndex = 16;
            this.btnReadEnergyAlarmlist.Text = "查询能耗告警记录";
            this.btnReadEnergyAlarmlist.UseVisualStyleBackColor = false;
            // 
            // btnReadSendMsgList
            // 
            this.btnReadSendMsgList.Location = new System.Drawing.Point(1048, 17);
            this.btnReadSendMsgList.Name = "btnReadSendMsgList";
            this.btnReadSendMsgList.Size = new System.Drawing.Size(63, 41);
            this.btnReadSendMsgList.TabIndex = 16;
            this.btnReadSendMsgList.Text = "查询短信记录";
            this.btnReadSendMsgList.UseVisualStyleBackColor = true;
            // 
            // btnExportMeterAlarmList
            // 
            this.btnExportMeterAlarmList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExportMeterAlarmList.Location = new System.Drawing.Point(961, 17);
            this.btnExportMeterAlarmList.Name = "btnExportMeterAlarmList";
            this.btnExportMeterAlarmList.Size = new System.Drawing.Size(67, 41);
            this.btnExportMeterAlarmList.TabIndex = 16;
            this.btnExportMeterAlarmList.Text = "导出设备离线记录";
            this.btnExportMeterAlarmList.UseVisualStyleBackColor = false;
            // 
            // btnReadAlarmList
            // 
            this.btnReadAlarmList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReadAlarmList.Location = new System.Drawing.Point(872, 17);
            this.btnReadAlarmList.Name = "btnReadAlarmList";
            this.btnReadAlarmList.Size = new System.Drawing.Size(69, 41);
            this.btnReadAlarmList.TabIndex = 16;
            this.btnReadAlarmList.Text = "查询设备离线记录";
            this.btnReadAlarmList.UseVisualStyleBackColor = false;
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置SToolStripMenuItem.Text = "系统设置";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置SToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartService);
            this.groupBox1.Controls.Add(this.btnStopService);
            this.groupBox1.Controls.Add(this.btnExportEnergyAlarmlist);
            this.groupBox1.Controls.Add(this.btnReadEnergyAlarmlist);
            this.groupBox1.Controls.Add(this.btnReadSendMsgList);
            this.groupBox1.Controls.Add(this.btnExportMeterAlarmList);
            this.groupBox1.Controls.Add(this.btnReadAlarmList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 75);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 25);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.tabConServerLog.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterLiveLog)).EndInit();
            this.tpgSendMsgLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSendMsgLog)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEPILog)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabConServerLog;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox StatusSMS;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvMeterLiveLog;
        private System.Windows.Forms.TabPage tpgSendMsgLog;
        private System.Windows.Forms.DataGridView dgrSendMsgLog;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dgvEPILog;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Button btnExportEnergyAlarmlist;
        private System.Windows.Forms.Button btnReadEnergyAlarmlist;
        private System.Windows.Forms.Button btnReadSendMsgList;
        private System.Windows.Forms.Button btnExportMeterAlarmList;
        private System.Windows.Forms.Button btnReadAlarmList;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}