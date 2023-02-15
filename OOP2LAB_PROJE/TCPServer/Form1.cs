using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//127.0.0.1:53271
namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                txtInfo.Text += $"Starting..{Environment.NewLine}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            txtInfo.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            txtInfo.Text += $"{e.IpPort}: disconnected{Environment.NewLine}";
            listClient.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            txtInfo.Text += $"{e.IpPort}: connected{Environment.NewLine}";
            listClient.Items.Add(e.IpPort);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text) && listClient.SelectedItem != null)
                {
                    server.Send(listClient.SelectedItem.ToString(), txtMessage.Text);
                    txtInfo.Text += $"Server: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
        }
    }
}
