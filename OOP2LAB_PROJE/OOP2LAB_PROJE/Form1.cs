using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace OOP2LAB_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            Oku("kullanıcılar.txt");
            chkŞifreGöster.Checked = false;
            txtSifre.PasswordChar = '*';
       
        }
        public string username;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool flag = false; //login doğru şekilde gerçekleştiyse True olur.

            // Kullanıcı türünün seçilip seçilmediği denetlenir.
            if (rBtnKullanici.Checked == false && rBtnYonetici.Checked == false)
            {
                MessageBox.Show("Please select the user type !");
                flag = false;
            }
           
            string dosya;
            //Kullanıcı bilgilerini tanımlar.
            //SqlConnection baglanti = new SqlConnection("Data Source=192.168.1.101,1433;Network Library=DBMSSOCN; Initial Catalog=Game; User Id=ADMIN;Password=sude;");
            //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");
            if (rBtnKullanici.Checked)
            {
                string username;
                string password;
                 baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserName,Password from USER_INFO", baglanti);
               
                SqlDataReader sqlRead = cmd.ExecuteReader();
                while (sqlRead.Read())
                {
                    username = sqlRead[0].ToString();
                    password = sqlRead[1].ToString();
                    if (txtAd.Text == username)
                    {
                        if (SHA256Hash(txtSifre.Text) == password)
                        {
                            flag = true;
                            username = txtAd.Text;
                            Properties.Settings.Default.kullaniciAdi = username;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password !");
                            flag = false;
                        }
                        break;
                    }
                }
                baglanti.Close();
                 
            }
            else
            {
                dosya = "Kayıtlar_Admins.xml";
                XDocument xdosya = XDocument.Load(dosya);
                XElement rootElement = xdosya.Root;

                //Kullanıcı bilgilerininin belirtilen belgeden kkontrolünü sağlar.
                foreach (XElement kullanici in rootElement.Elements())
                {
                    if (txtAd.Text == kullanici.Element("Username").Value)
                    {
                        if (SHA256Hash(txtSifre.Text) == kullanici.Element("Password").Value)
                        {
                            flag = true;
                            username = txtAd.Text;
                        }
                        else
                        {
                            MessageBox.Show("Wrong password !");
                            flag = false;
                        }
                        break;
                    }
                } 
            }

            if (!flag)
            {
                MessageBox.Show("Invalid username and password !");
            }
            // Şifre ve kullanıcı adı doğruysa user girişi oyunu admin girişi yönetici ekranını açar.
            else 
            {
                if (rBtnYonetici.Checked)
                {
                    ManageScreen ms = new ManageScreen();
                    ms.Show();

                    this.Hide();
                    StreamWriter sw = new StreamWriter(Dosya_Oluştur_Ulas());
                    sw.WriteLine("{0}", txtAd.Text);

                    sw.Flush();
                    sw.Close();
                }
                else if (rBtnKullanici.Checked)
                {
                    //Form2 ekranını açar.
                    Form2 ff = new Form2();
                    ff.Show();

                    this.Hide();
                    StreamWriter sw = new StreamWriter(Dosya_Oluştur_Ulas());
                    sw.WriteLine("{0}", txtAd.Text);

                    sw.Flush();
                    sw.Close();
                }
            }

        }

        //FormSingUp ekranını açar.
        private void btnKaydol_Click(object sender, EventArgs e)
        {      
                SingUp SU = new SingUp();
                SU.Show();
        }

        //Son başarılı giriş yapılan kullanıcı bilgilerini kaydetmek için dosya oluşturur.
        private FileStream Dosya_Oluştur_Ulas()
        {
            string dosya_yolu = "kullanıcılar.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            return fs;
        }

        //Kayıtlı veriler bulunan dosyadan verileri okur.
        private void Oku(string dy)
        {
            StreamReader sw = new StreamReader(Dosya_Oluştur_Ulas());
            txtAd.Text = sw.ReadLine();
            sw.Close();
        }

        //Şifreyi gösterir ve ya gizler.
        private void chkŞifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkŞifreGöster.Checked == true)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        //Username bilgisinin sadece harflerden oluşmasını sağlar. Farklı karakter girişini engeller. 
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        //Şifreyi SHA2 ile kaydeden fonksiyon.
        string SHA256Hash(string text)
        {
            string source = text;
            using (SHA256 sha1Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return (hash);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.kullaniciAdi = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MultiplayerServer mm = new MultiplayerServer();
            mm.Show();
            this.Hide();


            string dosya_yolu = "ayarlar.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("{0}", false);
            sw.WriteLine("{0}", true);
            sw.WriteLine("{0}", false);
            sw.WriteLine("{0}", false);
            sw.WriteLine("{0}", true);
            sw.WriteLine("{0}", true);
            sw.WriteLine("{0}", true);
            sw.WriteLine("{0}",true);
            sw.WriteLine("{0}",true);
            sw.WriteLine("{0}",true);

            sw.Flush();
            sw.Close();
            //Game game = new Game();
            //game.Show();

        }
    }
}


