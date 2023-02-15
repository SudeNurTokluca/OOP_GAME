using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace OOP2LAB_PROJE
{
    public partial class MultiplayerServer : Form
    {
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Socket soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        //        soket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 600));
        //        soket.Listen(10);
        //        Socket Client = soket.Accept();
        //        NetworkStream ns = new NetworkStream(Client);
        //        StreamReader sr = new StreamReader(ns);
        //        textBox1.Text = sr.ReadToEnd();
        //        sr.Close();
        //        ns.Close();
        //        soket.Shutdown(SocketShutdown.Receive);
        //        Client.Shutdown(SocketShutdown.Receive);
        //    }
        //    catch(SocketException ex)
        //    {
        //        MessageBox.Show("Hata");
        //    }
        //}

        //private void MultiplayerServer_Load(object sender, EventArgs e)
        //{

        //}
    }
    



















        //private void button1_Click(object sender, EventArgs e)
        //{
        //    msg(">> Karşı taraf bağlandı..");
        //    StartClient();
        //}

        //public void StartServer()
        //{
        //    TcpListener serverSocket = new TcpListener(int.Parse(textBox2.Text));

        //    int requestCount = 0;
        //    clientSocket = default(TcpClient);
        //    serverSocket.Start();
        //    listBox1.Items.Add(">> Server Started");
        //    //Console.WriteLine(" >> Server Started");
        //    clientSocket = serverSocket.AcceptTcpClient();
        //    listBox1.Items.Add(" >> Accept connection from client");
        //    //Console.WriteLine(" >> Accept connection from client");
        //    requestCount = 0;

        //    NetworkStream serverStream = clientSocket.GetStream();
        //    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox3.Text + "$");
        //    serverStream.Write(outStream, 0, outStream.Length);
        //    serverStream.Flush();

        //    byte[] inStream = new byte[65536];
        //    serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
        //    string returndata = System.Text.Encoding.ASCII.GetString(inStream);
        //    //msg(returndata);

        //    listBox1.Items.Add(Environment.NewLine + " >> " + returndata);
        //    listBox1.Refresh();
        //}

        //public void StartClient()
        //{
        //   // "127.0.0.1", 51219
        //    msg("Client Started");
        //    clientSocket.Connect(textBox1.Text,int.Parse(textBox2.Text));
        //    listBox1.Items.Add("Client Socket Program - Server Connected ...");

        //    NetworkStream serverStream = clientSocket.GetStream();
        //    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox3.Text + "$");
        //    serverStream.Write(outStream, 0, outStream.Length);
        //    serverStream.Flush();

        //    byte[] inStream = new byte[65536];
        //    serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
        //    string returndata = System.Text.Encoding.ASCII.GetString(inStream);
        //    //msg(returndata);

        //    listBox1.Items.Add(Environment.NewLine + " >> " + returndata);
        //    listBox1.Refresh();
        //}

        //public void msg(string mesg)
        //{
        //    //NetworkStream serverStream = clientSocket.GetStream();
        //    //byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
        //    //serverStream.Write(outStream, 0, outStream.Length);
        //    //serverStream.Flush();

        //    //byte[] inStream = new byte[65536];
        //    //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
        //    //string returndata = System.Text.Encoding.ASCII.GetString(inStream);

        //    listBox1.Items.Add(Environment.NewLine + " >> " + mesg);
        //    listBox1.Refresh();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    msg("Karşı taraf bekleniyor..");
        //    StartServer();
        //}
    }

