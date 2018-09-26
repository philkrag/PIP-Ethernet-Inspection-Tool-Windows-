namespace PIP_Ethernet_Inspection_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Send = new System.Windows.Forms.Button();
            this.BTN_Receive = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_Banner = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(129, 42);
            this.BTN_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(120, 123);
            this.BTN_Send.TabIndex = 0;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // BTN_Receive
            // 
            this.BTN_Receive.Location = new System.Drawing.Point(129, 174);
            this.BTN_Receive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Receive.Name = "BTN_Receive";
            this.BTN_Receive.Size = new System.Drawing.Size(120, 123);
            this.BTN_Receive.TabIndex = 1;
            this.BTN_Receive.Text = "Receive";
            this.BTN_Receive.UseVisualStyleBackColor = true;
            this.BTN_Receive.Click += new System.EventHandler(this.BTN_Receive_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(258, 35);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PB_Banner
            // 
            this.PB_Banner.BackColor = System.Drawing.Color.DimGray;
            this.PB_Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Banner.Location = new System.Drawing.Point(0, 42);
            this.PB_Banner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Banner.Name = "PB_Banner";
            this.PB_Banner.Size = new System.Drawing.Size(119, 262);
            this.PB_Banner.TabIndex = 8;
            this.PB_Banner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 305);
            this.Controls.Add(this.BTN_Receive);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.PB_Banner);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Button BTN_Receive;
        private System.Windows.Forms.PictureBox PB_Banner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

