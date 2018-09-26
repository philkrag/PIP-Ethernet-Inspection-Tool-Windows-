namespace PIP_Ethernet_Inspection_Tool
{
    partial class FRM_Send
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Send));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Message = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NV_Port_Address = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_1 = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_2 = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_3 = new System.Windows.Forms.NumericUpDown();
            this.NV_IP_Byte_4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_Banner = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_TCP_Select = new System.Windows.Forms.RadioButton();
            this.BTN_UDP_Select = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NV_Port_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Send);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXB_Message);
            this.groupBox2.Location = new System.Drawing.Point(92, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data to Send";
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(384, 45);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(120, 23);
            this.BTN_Send.TabIndex = 8;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sending String";
            // 
            // TXB_Message
            // 
            this.TXB_Message.Location = new System.Drawing.Point(254, 19);
            this.TXB_Message.Name = "TXB_Message";
            this.TXB_Message.Size = new System.Drawing.Size(250, 20);
            this.TXB_Message.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NV_Port_Address);
            this.groupBox1.Controls.Add(this.NV_IP_Byte_1);
            this.groupBox1.Controls.Add(this.NV_IP_Byte_2);
            this.groupBox1.Controls.Add(this.NV_IP_Byte_3);
            this.groupBox1.Controls.Add(this.NV_IP_Byte_4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(92, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communications Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listen to Port";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination IP Address";
            // 
            // PB_Banner
            // 
            this.PB_Banner.BackColor = System.Drawing.Color.DimGray;
            this.PB_Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Banner.Location = new System.Drawing.Point(0, 0);
            this.PB_Banner.Name = "PB_Banner";
            this.PB_Banner.Size = new System.Drawing.Size(80, 242);
            this.PB_Banner.TabIndex = 7;
            this.PB_Banner.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_TCP_Select);
            this.groupBox3.Controls.Add(this.BTN_UDP_Select);
            this.groupBox3.Location = new System.Drawing.Point(92, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(510, 50);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmission Method";
            // 
            // BTN_TCP_Select
            // 
            this.BTN_TCP_Select.Appearance = System.Windows.Forms.Appearance.Button;
            this.BTN_TCP_Select.Checked = true;
            this.BTN_TCP_Select.Location = new System.Drawing.Point(384, 16);
            this.BTN_TCP_Select.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_TCP_Select.Name = "BTN_TCP_Select";
            this.BTN_TCP_Select.Size = new System.Drawing.Size(57, 23);
            this.BTN_TCP_Select.TabIndex = 1;
            this.BTN_TCP_Select.TabStop = true;
            this.BTN_TCP_Select.Text = "TCP";
            this.BTN_TCP_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_TCP_Select.UseVisualStyleBackColor = true;
            this.BTN_TCP_Select.CheckedChanged += new System.EventHandler(this.BTN_TCP_Select_CheckedChanged);
            // 
            // BTN_UDP_Select
            // 
            this.BTN_UDP_Select.Appearance = System.Windows.Forms.Appearance.Button;
            this.BTN_UDP_Select.Location = new System.Drawing.Point(447, 16);
            this.BTN_UDP_Select.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UDP_Select.Name = "BTN_UDP_Select";
            this.BTN_UDP_Select.Size = new System.Drawing.Size(57, 23);
            this.BTN_UDP_Select.TabIndex = 0;
            this.BTN_UDP_Select.Text = "UDP";
            this.BTN_UDP_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_UDP_Select.UseVisualStyleBackColor = true;
            this.BTN_UDP_Select.CheckedChanged += new System.EventHandler(this.BTN_UDP_Select_CheckedChanged);
            // 
            // FRM_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 241);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PB_Banner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Send";
            this.Text = "Send Ethernet Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Send_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Send_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NV_Port_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NV_IP_Byte_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_Message;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NV_Port_Address;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_1;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_2;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_3;
        private System.Windows.Forms.NumericUpDown NV_IP_Byte_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_Banner;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton BTN_TCP_Select;
        private System.Windows.Forms.RadioButton BTN_UDP_Select;
    }
}