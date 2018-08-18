namespace PIP_Ethernet_Inspection_Tool
{
    partial class FRM_Receive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Receive));
            this.BTN_Start_Monitoring = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IND_Display_Engine = new System.Windows.Forms.PictureBox();
            this.LBL_Display_Engine_Status = new System.Windows.Forms.Label();
            this.IND_Monitoring_Engine = new System.Windows.Forms.PictureBox();
            this.LBL_Monitoring_Engine_Status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_Port_Address = new System.Windows.Forms.Label();
            this.NV_Port_Address = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_1 = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_2 = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_3 = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_4 = new System.Windows.Forms.NumericUpDown();
            this.LBL_IP_Address = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGV_Incoming_Messages = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BW_Monitoring_Engine = new System.ComponentModel.BackgroundWorker();
            this.TMR_Display_Engine = new System.Windows.Forms.Timer(this.components);
            this.TMR_Monitoring_Engine = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PB_Banner = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IND_Display_Engine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IND_Monitoring_Engine)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NV_Port_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Incoming_Messages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Start_Monitoring
            // 
            this.BTN_Start_Monitoring.Location = new System.Drawing.Point(384, 19);
            this.BTN_Start_Monitoring.Name = "BTN_Start_Monitoring";
            this.BTN_Start_Monitoring.Size = new System.Drawing.Size(120, 23);
            this.BTN_Start_Monitoring.TabIndex = 0;
            this.BTN_Start_Monitoring.Text = "Start / Stop";
            this.BTN_Start_Monitoring.UseVisualStyleBackColor = true;
            this.BTN_Start_Monitoring.Click += new System.EventHandler(this.BTN_Start_Monitoring_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IND_Display_Engine);
            this.groupBox1.Controls.Add(this.LBL_Display_Engine_Status);
            this.groupBox1.Controls.Add(this.IND_Monitoring_Engine);
            this.groupBox1.Controls.Add(this.LBL_Monitoring_Engine_Status);
            this.groupBox1.Controls.Add(this.BTN_Start_Monitoring);
            this.groupBox1.Location = new System.Drawing.Point(92, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Control";
            // 
            // IND_Display_Engine
            // 
            this.IND_Display_Engine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IND_Display_Engine.Location = new System.Drawing.Point(6, 48);
            this.IND_Display_Engine.Name = "IND_Display_Engine";
            this.IND_Display_Engine.Size = new System.Drawing.Size(23, 23);
            this.IND_Display_Engine.TabIndex = 5;
            this.IND_Display_Engine.TabStop = false;
            // 
            // LBL_Display_Engine_Status
            // 
            this.LBL_Display_Engine_Status.AutoSize = true;
            this.LBL_Display_Engine_Status.Location = new System.Drawing.Point(35, 58);
            this.LBL_Display_Engine_Status.Name = "LBL_Display_Engine_Status";
            this.LBL_Display_Engine_Status.Size = new System.Drawing.Size(110, 13);
            this.LBL_Display_Engine_Status.TabIndex = 4;
            this.LBL_Display_Engine_Status.Text = "Display Engine Status";
            // 
            // IND_Monitoring_Engine
            // 
            this.IND_Monitoring_Engine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IND_Monitoring_Engine.Location = new System.Drawing.Point(6, 19);
            this.IND_Monitoring_Engine.Name = "IND_Monitoring_Engine";
            this.IND_Monitoring_Engine.Size = new System.Drawing.Size(23, 23);
            this.IND_Monitoring_Engine.TabIndex = 3;
            this.IND_Monitoring_Engine.TabStop = false;
            // 
            // LBL_Monitoring_Engine_Status
            // 
            this.LBL_Monitoring_Engine_Status.AutoSize = true;
            this.LBL_Monitoring_Engine_Status.Location = new System.Drawing.Point(35, 29);
            this.LBL_Monitoring_Engine_Status.Name = "LBL_Monitoring_Engine_Status";
            this.LBL_Monitoring_Engine_Status.Size = new System.Drawing.Size(125, 13);
            this.LBL_Monitoring_Engine_Status.TabIndex = 2;
            this.LBL_Monitoring_Engine_Status.Text = "Monitoring Engine Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_Port_Address);
            this.groupBox2.Controls.Add(this.NV_Port_Address);
            this.groupBox2.Controls.Add(this.NV_IP_Byte_1);
            this.groupBox2.Controls.Add(this.NV_IP_Byte_2);
            this.groupBox2.Controls.Add(this.NV_IP_Byte_3);
            this.groupBox2.Controls.Add(this.NV_IP_Byte_4);
            this.groupBox2.Controls.Add(this.LBL_IP_Address);
            this.groupBox2.Location = new System.Drawing.Point(92, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communications Setup";
            // 
            // LBL_Port_Address
            // 
            this.LBL_Port_Address.AutoSize = true;
            this.LBL_Port_Address.Location = new System.Drawing.Point(6, 52);
            this.LBL_Port_Address.Name = "LBL_Port_Address";
            this.LBL_Port_Address.Size = new System.Drawing.Size(69, 13);
            this.LBL_Port_Address.TabIndex = 6;
            this.LBL_Port_Address.Text = "Listen to Port";
            // 
            // NV_Port_Address
            // 
            this.NV_Port_Address.Location = new System.Drawing.Point(254, 45);
            this.NV_Port_Address.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NV_Port_Address.Name = "NV_Port_Address";
            this.NV_Port_Address.Size = new System.Drawing.Size(250, 20);
            this.NV_Port_Address.TabIndex = 5;
            this.NV_Port_Address.Value = new decimal(new int[] {
            13000,
            0,
            0,
            0});
            // 
            // NV_IP_Byte_1
            // 
            this.NV_IP_Byte_1.Location = new System.Drawing.Point(254, 19);
            this.NV_IP_Byte_1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NV_IP_Byte_1.Name = "NV_IP_Byte_1";
            this.NV_IP_Byte_1.Size = new System.Drawing.Size(58, 20);
            this.NV_IP_Byte_1.TabIndex = 4;
            this.NV_IP_Byte_1.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // NV_IP_Byte_2
            // 
            this.NV_IP_Byte_2.Location = new System.Drawing.Point(318, 19);
            this.NV_IP_Byte_2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NV_IP_Byte_2.Name = "NV_IP_Byte_2";
            this.NV_IP_Byte_2.Size = new System.Drawing.Size(58, 20);
            this.NV_IP_Byte_2.TabIndex = 3;
            // 
            // NV_IP_Byte_3
            // 
            this.NV_IP_Byte_3.Location = new System.Drawing.Point(382, 19);
            this.NV_IP_Byte_3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NV_IP_Byte_3.Name = "NV_IP_Byte_3";
            this.NV_IP_Byte_3.Size = new System.Drawing.Size(58, 20);
            this.NV_IP_Byte_3.TabIndex = 2;
            // 
            // NV_IP_Byte_4
            // 
            this.NV_IP_Byte_4.Location = new System.Drawing.Point(446, 19);
            this.NV_IP_Byte_4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NV_IP_Byte_4.Name = "NV_IP_Byte_4";
            this.NV_IP_Byte_4.Size = new System.Drawing.Size(58, 20);
            this.NV_IP_Byte_4.TabIndex = 1;
            this.NV_IP_Byte_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBL_IP_Address
            // 
            this.LBL_IP_Address.AutoSize = true;
            this.LBL_IP_Address.Location = new System.Drawing.Point(6, 26);
            this.LBL_IP_Address.Name = "LBL_IP_Address";
            this.LBL_IP_Address.Size = new System.Drawing.Size(95, 13);
            this.LBL_IP_Address.TabIndex = 0;
            this.LBL_IP_Address.Text = "Current IP Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_Incoming_Messages);
            this.groupBox4.Location = new System.Drawing.Point(92, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 228);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Received Messages";
            // 
            // DGV_Incoming_Messages
            // 
            this.DGV_Incoming_Messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Incoming_Messages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date_Time,
            this.Message});
            this.DGV_Incoming_Messages.Location = new System.Drawing.Point(6, 19);
            this.DGV_Incoming_Messages.Name = "DGV_Incoming_Messages";
            this.DGV_Incoming_Messages.Size = new System.Drawing.Size(498, 203);
            this.DGV_Incoming_Messages.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // Date_Time
            // 
            this.Date_Time.HeaderText = "Date Time";
            this.Date_Time.Name = "Date_Time";
            this.Date_Time.Width = 140;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.Width = 255;
            // 
            // BW_Monitoring_Engine
            // 
            this.BW_Monitoring_Engine.WorkerReportsProgress = true;
            this.BW_Monitoring_Engine.WorkerSupportsCancellation = true;
            this.BW_Monitoring_Engine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_Monitoring_Engine_DoWork);
            this.BW_Monitoring_Engine.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_Monitoring_Engine_RunWorkerCompleted);
            // 
            // TMR_Display_Engine
            // 
            this.TMR_Display_Engine.Enabled = true;
            this.TMR_Display_Engine.Tick += new System.EventHandler(this.TMR_Display_Engine_Tick);
            // 
            // TMR_Monitoring_Engine
            // 
            this.TMR_Monitoring_Engine.Enabled = true;
            this.TMR_Monitoring_Engine.Interval = 10;
            this.TMR_Monitoring_Engine.Tick += new System.EventHandler(this.TMR_Monitoring_Engine_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PB_Banner
            // 
            this.PB_Banner.BackColor = System.Drawing.Color.White;
            this.PB_Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Banner.Image = global::PIP_Ethernet_Inspection_Tool.Properties.Resources.Software_Banner;
            this.PB_Banner.Location = new System.Drawing.Point(0, 0);
            this.PB_Banner.Name = "PB_Banner";
            this.PB_Banner.Size = new System.Drawing.Size(80, 419);
            this.PB_Banner.TabIndex = 6;
            this.PB_Banner.TabStop = false;
            // 
            // FRM_Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 419);
            this.Controls.Add(this.PB_Banner);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Receive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive Ethernet Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Receive_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IND_Display_Engine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IND_Monitoring_Engine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NV_Port_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Incoming_Messages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start_Monitoring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_IP_Address;
        private System.Windows.Forms.PictureBox IND_Monitoring_Engine;
        private System.Windows.Forms.Label LBL_Monitoring_Engine_Status;
        private System.Windows.Forms.Label LBL_Port_Address;
        private System.Windows.Forms.NumericUpDown NV_Port_Address;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_1;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_2;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_3;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker BW_Monitoring_Engine;
        private System.Windows.Forms.PictureBox IND_Display_Engine;
        private System.Windows.Forms.Label LBL_Display_Engine_Status;
        private System.Windows.Forms.Timer TMR_Display_Engine;
        private System.Windows.Forms.DataGridView DGV_Incoming_Messages;
        private System.Windows.Forms.Timer TMR_Monitoring_Engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.PictureBox PB_Banner;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}