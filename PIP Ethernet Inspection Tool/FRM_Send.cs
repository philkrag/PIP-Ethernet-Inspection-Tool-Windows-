using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PIP_Ethernet_Inspection_Tool
{
    public partial class FRM_Send : Form
    {
        public FRM_Send()
        {
            InitializeComponent();
        }

        // ////////////////////////////////////////////////////////////////// FORM

        private void FRM_Send_Load(object sender, EventArgs e)
        {

        }

        private void FRM_Send_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.Dispose();
        }

        // ////////////////////////////////////////////////////////////////// BUTTONS

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        // ////////////////////////////////////////////////////////////////// BACKGORUND WORKERS

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string Message = TXB_Message.Text;
                Int32 Port_Address = Convert.ToInt32(NV_Port_Address.Value);
                string IP_Address = NV_IP_Byte_1.Value.ToString() + "." + NV_IP_Byte_2.Value.ToString() + "." + NV_IP_Byte_3.Value.ToString() + "." + NV_IP_Byte_4.Value.ToString();
                TcpClient client = new TcpClient(IP_Address, Port_Address);
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(Message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: {0}", Message);
                data = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);
                stream.Close();
                client.Close();
            }
            catch
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }

        
    }
}
