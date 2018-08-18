using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PIP_Ethernet_Inspection_Tool
{
    public partial class FRM_Receive : Form
    {
        public FRM_Receive()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////// FORM

        private void FRM_Receive_FormClosing(object sender, FormClosingEventArgs e)
        {
            BW_Monitoring_Engine.Dispose();
        }

        ////////////////////////////////////////////////////////////////// SETUP

        int Incoming_Message_Index = 0;
        string Incoming_Message = "";
        string Incoming_Message_Memory = "";
        string BW_Monitoring_Engine_Running = "Stopped";


        ////////////////////////////////////////////////////////////////// BUTTONS

        private void BTN_Start_Monitoring_Click(object sender, EventArgs e)
        {
            if (BW_Monitoring_Engine_Running=="Stopped")
            {
                if (!BW_Monitoring_Engine.IsBusy)
                {
                    BW_Monitoring_Engine.RunWorkerAsync();
                    BW_Monitoring_Engine_Running = "Started";
                    IND_Monitoring_Engine.BackColor = Color.Green;
                    DGV_Incoming_Messages.Rows.Insert(0, Incoming_Message_Index, System.DateTime.Now.ToString(), "Monitoring Started");
                    Incoming_Message_Index++;
                }
                else
                {
                    BW_Monitoring_Engine_Running = "Hung";
                    IND_Monitoring_Engine.BackColor = Color.Orange;
                    DGV_Incoming_Messages.Rows.Insert(0, Incoming_Message_Index, System.DateTime.Now.ToString(), "Monitoring Hung");
                    Incoming_Message_Index++;
                }                
            }
            else
            {                
                BW_Monitoring_Engine.CancelAsync();
                BW_Monitoring_Engine_Running = "Stopped";
                IND_Monitoring_Engine.BackColor = Color.Red;
                DGV_Incoming_Messages.Rows.Insert(0, Incoming_Message_Index, System.DateTime.Now.ToString(), "Monitoring Stopped");
                Incoming_Message_Index++;
            }
        }

        // ////////////////////////////////////////////////////////////////// BACKGROUND WORKERS

        private void BW_Monitoring_Engine_DoWork(object sender, DoWorkEventArgs e)
        {
            TcpListener server = null;
            try
            {                
                Int32 Port_Address = Convert.ToInt32(NV_Port_Address.Value);
                string IP_Address = NV_IP_Byte_1.Value.ToString() + "." + NV_IP_Byte_2.Value.ToString() + "." + NV_IP_Byte_3.Value.ToString() + "." + NV_IP_Byte_4.Value.ToString();
                IPAddress localAddr = IPAddress.Parse(IP_Address);
                server = new TcpListener(localAddr, Port_Address);
                server.Start();
                Byte[] bytes = new Byte[256];
                String data = null;
                while (true)
                {
                    Console.Write("Waiting for a connection... ");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    data = null;
                    NetworkStream stream = client.GetStream();
                    int i;
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        if (!BW_Monitoring_Engine.CancellationPending)
                        {
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            Console.WriteLine("Received: {0}", data);
                            data = data.ToUpper();
                            Incoming_Message = data;
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                            stream.Write(msg, 0, msg.Length);
                            Console.WriteLine("Sent: {0}", data);
                        }
                        else
                        {
                            server.Stop();
                            stream.Dispose();
                            break;
                        }
                    }
                    client.Close();
                }
            }
            catch
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }                    
        }

        private void BW_Monitoring_Engine_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        // ////////////////////////////////////////////////////////////////// TIMERS

        private void TMR_Display_Engine_Tick(object sender, EventArgs e)
        {
            if (BW_Monitoring_Engine_Running=="Started" && TMR_Monitoring_Engine.Enabled)
            {
                IND_Display_Engine.BackColor = Color.Green;
            }

            if (BW_Monitoring_Engine_Running=="Stopped" || !TMR_Monitoring_Engine.Enabled)
            {
                IND_Display_Engine.BackColor = Color.Orange;
            }

            if (BW_Monitoring_Engine_Running=="Stopped" && !TMR_Monitoring_Engine.Enabled)
            {
                IND_Display_Engine.BackColor = Color.Red;
            }

            if (TMR_Display_Engine.Enabled)
            {
                IND_Display_Engine.BackColor = Color.Green;
            }
            else
            {
                IND_Display_Engine.BackColor = Color.Red;
            }

        }

        private void TMR_Monitoring_Engine_Tick(object sender, EventArgs e)
        {
            if(Incoming_Message!= Incoming_Message_Memory)
            {
                DGV_Incoming_Messages.Rows.Insert(0, Incoming_Message_Index, System.DateTime.Now.ToString(), Incoming_Message);
                Incoming_Message = Incoming_Message_Memory;
                Incoming_Message_Index++;
            }
        }        
    }    
}
