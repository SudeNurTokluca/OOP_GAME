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

namespace OOP2LAB_PROJE
{
    public partial class Multiplayer : Form
    {
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int PORT = 52000;
            soket.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.101"), PORT));

            
            try
            {
                soket.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.101"), PORT));
                Console.WriteLine("Başarıyla bağlanıldı!");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n (X) -> Bağlanmaya çalışırken hata oluştu: " + ex.Message);
            }

            while (true && soket.Connected)
            {
                
                // Gönderilecek metni alıyoruz.
                string gonder = "hheey";

                // Ağ üzerinden gönderilecek her şey bytelara 
                // dönüştürülmüş olmalıdır.
                soket.Send(Encoding.UTF8.GetBytes(gonder));
            }
        }

      

    }
}
