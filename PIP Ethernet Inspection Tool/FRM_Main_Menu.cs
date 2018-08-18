using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIP_Ethernet_Inspection_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ////////////////////////////////////////////////////////////////// FORMS

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ////////////////////////////////////////////////////////////////// TOOLSTRIP

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_About FRM_About = new FRM_About();
            FRM_About.Show();
        }

        // ////////////////////////////////////////////////////////////////// BUTTONS

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            FRM_Send FRM_Send = new FRM_Send();
            FRM_Send.Show();
        }

        private void BTN_Receive_Click(object sender, EventArgs e)
        {
            FRM_Receive FRM_Receive = new FRM_Receive();
            FRM_Receive.Show();
        }
    }
}
