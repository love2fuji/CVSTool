﻿namespace CVSTool
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabConServerLog = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ServerLog = new System.Windows.Forms.RichTextBox();
            this.tpgRegion = new System.Windows.Forms.TabPage();
            this.dgvShowRegion = new System.Windows.Forms.DataGridView();
            this.tpgDepart = new System.Windows.Forms.TabPage();
            this.dgvShowDepart = new System.Windows.Forms.DataGridView();
            this.btnBaseDataExport2Excel = new System.Windows.Forms.Button();
            this.显示ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnRegionDataExport2CSV = new System.Windows.Forms.Button();
            this.btnImportRegion = new System.Windows.Forms.Button();
            this.btnOpenCSV = new System.Windows.Forms.Button();
            this.btnImportDepart = new System.Windows.Forms.Button();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxBiuldInfo = new System.Windows.Forms.ComboBox();
            this.btnEnergyDataExport = new System.Windows.Forms.Button();
            this.btnBaseDataExport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEnergyItemImport = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabConServerLog.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpgRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRegion)).BeginInit();
            this.tpgDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDepart)).BeginInit();
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
            this.groupBox2.Size = new System.Drawing.Size(1174, 533);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态显示";
            // 
            // tabConServerLog
            // 
            this.tabConServerLog.Controls.Add(this.tabPage1);
            this.tabConServerLog.Controls.Add(this.tpgRegion);
            this.tabConServerLog.Controls.Add(this.tpgDepart);
            this.tabConServerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConServerLog.Location = new System.Drawing.Point(3, 17);
            this.tabConServerLog.Name = "tabConServerLog";
            this.tabConServerLog.SelectedIndex = 0;
            this.tabConServerLog.Size = new System.Drawing.Size(1168, 513);
            this.tabConServerLog.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ServerLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1160, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "服务日志";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ServerLog
            // 
            this.ServerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerLog.Location = new System.Drawing.Point(3, 3);
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.Size = new System.Drawing.Size(1154, 481);
            this.ServerLog.TabIndex = 24;
            this.ServerLog.Text = "";
            // 
            // tpgRegion
            // 
            this.tpgRegion.AutoScroll = true;
            this.tpgRegion.Controls.Add(this.dgvShowRegion);
            this.tpgRegion.Location = new System.Drawing.Point(4, 22);
            this.tpgRegion.Name = "tpgRegion";
            this.tpgRegion.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRegion.Size = new System.Drawing.Size(1160, 487);
            this.tpgRegion.TabIndex = 1;
            this.tpgRegion.Text = "区域/部门基础数据";
            this.tpgRegion.UseVisualStyleBackColor = true;
            // 
            // dgvShowRegion
            // 
            this.dgvShowRegion.AllowDrop = true;
            this.dgvShowRegion.AllowUserToAddRows = false;
            this.dgvShowRegion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowRegion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowRegion.Location = new System.Drawing.Point(3, 3);
            this.dgvShowRegion.Name = "dgvShowRegion";
            this.dgvShowRegion.RowHeadersWidth = 50;
            this.dgvShowRegion.RowTemplate.Height = 23;
            this.dgvShowRegion.Size = new System.Drawing.Size(1154, 481);
            this.dgvShowRegion.TabIndex = 0;
            this.dgvShowRegion.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvShowRegion_RowStateChanged);
            // 
            // tpgDepart
            // 
            this.tpgDepart.Controls.Add(this.dgvShowDepart);
            this.tpgDepart.Location = new System.Drawing.Point(4, 22);
            this.tpgDepart.Name = "tpgDepart";
            this.tpgDepart.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDepart.Size = new System.Drawing.Size(1160, 487);
            this.tpgDepart.TabIndex = 2;
            this.tpgDepart.Text = " ";
            this.tpgDepart.UseVisualStyleBackColor = true;
            // 
            // dgvShowDepart
            // 
            this.dgvShowDepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShowDepart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDepart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowDepart.Location = new System.Drawing.Point(3, 3);
            this.dgvShowDepart.Name = "dgvShowDepart";
            this.dgvShowDepart.RowHeadersWidth = 10;
            this.dgvShowDepart.RowTemplate.Height = 23;
            this.dgvShowDepart.Size = new System.Drawing.Size(1154, 481);
            this.dgvShowDepart.TabIndex = 0;
            // 
            // btnBaseDataExport2Excel
            // 
            this.btnBaseDataExport2Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBaseDataExport2Excel.Location = new System.Drawing.Point(529, 20);
            this.btnBaseDataExport2Excel.Name = "btnBaseDataExport2Excel";
            this.btnBaseDataExport2Excel.Size = new System.Drawing.Size(81, 41);
            this.btnBaseDataExport2Excel.TabIndex = 19;
            this.btnBaseDataExport2Excel.Text = "导出原部门基础数据";
            this.btnBaseDataExport2Excel.UseVisualStyleBackColor = false;
            this.btnBaseDataExport2Excel.Click += new System.EventHandler(this.btnDepartmentDataExport2CSV_Click);
            // 
            // 显示ToolStripMenuItem1
            // 
            this.显示ToolStripMenuItem1.Name = "显示ToolStripMenuItem1";
            this.显示ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem1.Text = "显示";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            // btnRegionDataExport2CSV
            // 
            this.btnRegionDataExport2CSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegionDataExport2CSV.Location = new System.Drawing.Point(430, 20);
            this.btnRegionDataExport2CSV.Name = "btnRegionDataExport2CSV";
            this.btnRegionDataExport2CSV.Size = new System.Drawing.Size(82, 41);
            this.btnRegionDataExport2CSV.TabIndex = 17;
            this.btnRegionDataExport2CSV.Text = "导出原区域基础数据";
            this.btnRegionDataExport2CSV.UseVisualStyleBackColor = false;
            this.btnRegionDataExport2CSV.Click += new System.EventHandler(this.btnRegionDataExport2CSV_Click);
            // 
            // btnImportRegion
            // 
            this.btnImportRegion.BackColor = System.Drawing.SystemColors.Info;
            this.btnImportRegion.Location = new System.Drawing.Point(804, 20);
            this.btnImportRegion.Name = "btnImportRegion";
            this.btnImportRegion.Size = new System.Drawing.Size(71, 41);
            this.btnImportRegion.TabIndex = 16;
            this.btnImportRegion.Text = "导入区域基础数据";
            this.btnImportRegion.UseVisualStyleBackColor = false;
            this.btnImportRegion.Click += new System.EventHandler(this.btnImportRegion_Click);
            // 
            // btnOpenCSV
            // 
            this.btnOpenCSV.Location = new System.Drawing.Point(664, 20);
            this.btnOpenCSV.Name = "btnOpenCSV";
            this.btnOpenCSV.Size = new System.Drawing.Size(109, 41);
            this.btnOpenCSV.TabIndex = 16;
            this.btnOpenCSV.Text = "查找文件（.CSV）";
            this.btnOpenCSV.UseVisualStyleBackColor = true;
            this.btnOpenCSV.Click += new System.EventHandler(this.btnOpenCSV_Click);
            // 
            // btnImportDepart
            // 
            this.btnImportDepart.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnImportDepart.Location = new System.Drawing.Point(900, 20);
            this.btnImportDepart.Name = "btnImportDepart";
            this.btnImportDepart.Size = new System.Drawing.Size(70, 41);
            this.btnImportDepart.TabIndex = 16;
            this.btnImportDepart.Text = "导入部门基础数据";
            this.btnImportDepart.UseVisualStyleBackColor = false;
            this.btnImportDepart.Click += new System.EventHandler(this.btnImportDepart_Click);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxBiuldInfo);
            this.groupBox1.Controls.Add(this.btnBaseDataExport2Excel);
            this.groupBox1.Controls.Add(this.btnEnergyDataExport);
            this.groupBox1.Controls.Add(this.btnBaseDataExport);
            this.groupBox1.Controls.Add(this.btnEnergyItemImport);
            this.groupBox1.Controls.Add(this.btnRegionDataExport2CSV);
            this.groupBox1.Controls.Add(this.btnImportRegion);
            this.groupBox1.Controls.Add(this.btnOpenCSV);
            this.groupBox1.Controls.Add(this.btnImportDepart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 75);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "选择建筑物";
            // 
            // cboxBiuldInfo
            // 
            this.cboxBiuldInfo.FormattingEnabled = true;
            this.cboxBiuldInfo.Location = new System.Drawing.Point(29, 39);
            this.cboxBiuldInfo.Name = "cboxBiuldInfo";
            this.cboxBiuldInfo.Size = new System.Drawing.Size(165, 20);
            this.cboxBiuldInfo.TabIndex = 20;
            this.cboxBiuldInfo.SelectedIndexChanged += new System.EventHandler(this.cboxBiuldInfo_SelectedIndexChanged);
            // 
            // btnEnergyDataExport
            // 
            this.btnEnergyDataExport.BackColor = System.Drawing.Color.Silver;
            this.btnEnergyDataExport.Location = new System.Drawing.Point(247, 18);
            this.btnEnergyDataExport.Name = "btnEnergyDataExport";
            this.btnEnergyDataExport.Size = new System.Drawing.Size(71, 41);
            this.btnEnergyDataExport.TabIndex = 17;
            this.btnEnergyDataExport.Text = "导出能耗基础数据";
            this.btnEnergyDataExport.UseVisualStyleBackColor = false;
            this.btnEnergyDataExport.Click += new System.EventHandler(this.btnEnergyDataExport_Click);
            // 
            // btnBaseDataExport
            // 
            this.btnBaseDataExport.BackColor = System.Drawing.Color.Silver;
            this.btnBaseDataExport.Location = new System.Drawing.Point(336, 18);
            this.btnBaseDataExport.Name = "btnBaseDataExport";
            this.btnBaseDataExport.Size = new System.Drawing.Size(71, 41);
            this.btnBaseDataExport.TabIndex = 17;
            this.btnBaseDataExport.Text = "导出区域数据格式";
            this.btnBaseDataExport.UseVisualStyleBackColor = false;
            this.btnBaseDataExport.Click += new System.EventHandler(this.btnBaseDataExport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 25);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEnergyItemImport
            // 
            this.btnEnergyItemImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEnergyItemImport.Location = new System.Drawing.Point(994, 20);
            this.btnEnergyItemImport.Name = "btnEnergyItemImport";
            this.btnEnergyItemImport.Size = new System.Drawing.Size(67, 41);
            this.btnEnergyItemImport.TabIndex = 17;
            this.btnEnergyItemImport.Text = "导入分项基础数据";
            this.btnEnergyItemImport.UseVisualStyleBackColor = false;
            this.btnEnergyItemImport.Click += new System.EventHandler(this.btnEnergyItemImport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "区域部门基础信息导入工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabConServerLog.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpgRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRegion)).EndInit();
            this.tpgDepart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDepart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabConServerLog;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox ServerLog;
        private System.Windows.Forms.TabPage tpgRegion;
        public System.Windows.Forms.DataGridView dgvShowRegion;
        private System.Windows.Forms.TabPage tpgDepart;
        private System.Windows.Forms.DataGridView dgvShowDepart;
        private System.Windows.Forms.Button btnBaseDataExport2Excel;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnRegionDataExport2CSV;
        private System.Windows.Forms.Button btnImportRegion;
        private System.Windows.Forms.Button btnOpenCSV;
        private System.Windows.Forms.Button btnImportDepart;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxBiuldInfo;
        private System.Windows.Forms.Button btnBaseDataExport;
        private System.Windows.Forms.Button btnEnergyDataExport;
        private System.Windows.Forms.Button btnEnergyItemImport;
    }
}

