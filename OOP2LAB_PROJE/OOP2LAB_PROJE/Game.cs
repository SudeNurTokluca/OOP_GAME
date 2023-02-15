using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.SqlClient;
//rand enable sleep
namespace OOP2LAB_PROJE
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Board board;
        public int interval;
        int puan, patSayi = 0;
        int ToplamPuan = 0;
        Random rastgele = new Random();

        private void Game_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            Properties.Settings.Default.SecilenBtnX1 = -1;
            Properties.Settings.Default.SecilenBtnY1 = -1;
            Properties.Settings.Default.SecilenBtnX2 = -1;
            Properties.Settings.Default.SecilenBtnY2 = -1;

            Size board_size = new Size(0, 0);
            string dosya_yolu = "ayarlar.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sw = new StreamReader(fs);
            bool kolay, orta, zor, özel;

            kolay = Convert.ToBoolean(sw.ReadLine());
            orta = Convert.ToBoolean(sw.ReadLine());
            zor = Convert.ToBoolean(sw.ReadLine());
            özel = Convert.ToBoolean(sw.ReadLine());
            if (kolay)
            {
                board_size = new Size(450, 450);
                puan = 1;
            }
            else if (orta)
            {
                board_size = new Size(270, 270);
                puan = 3;
            }
            else if (zor)
            {
                board_size = new Size(180, 180);
                puan = 5;
            }
            else if (özel)
            {
                int Boy = int.Parse(sw.ReadLine()) * 30;
                int En = int.Parse(sw.ReadLine()) * 30;
                board_size = new Size(En, Boy);
                puan = 2;
            }
            board = new Board(board_size, puan);
            Game_panel.Size = board.size;
            Board_Oluştur();


            bool kare, üçgen, daire, green, yellow, red;
            kare = Convert.ToBoolean(sw.ReadLine());
            üçgen = Convert.ToBoolean(sw.ReadLine());
            daire = Convert.ToBoolean(sw.ReadLine());

            green = Convert.ToBoolean(sw.ReadLine());
            yellow = Convert.ToBoolean(sw.ReadLine());
            red = Convert.ToBoolean(sw.ReadLine());

            if (kare && red)
            {
                ŞekilButton ş = new ŞekilButton(4, Color.Red);
                board.Şekil_Ekle(ş);
            }
            if (kare && yellow)
            {
                ŞekilButton ş = new ŞekilButton(4, Color.Yellow);
                board.Şekil_Ekle(ş);
            }
            if (kare && green)
            {
                ŞekilButton ş = new ŞekilButton(4, Color.Green);
                board.Şekil_Ekle(ş);
            }

            if (üçgen && red)
            {
                ŞekilButton ş = new ŞekilButton(3, Color.Red);
                board.Şekil_Ekle(ş);
            }
            if (üçgen && yellow)
            {
                ŞekilButton ş = new ŞekilButton(3, Color.Yellow);
                board.Şekil_Ekle(ş);
            }
            if (üçgen && green)
            {
                ŞekilButton ş = new ŞekilButton(3, Color.Green);
                board.Şekil_Ekle(ş);
            }

            if (daire && red)
            {
                ŞekilButton ş = new ŞekilButton(0, Color.Red);
                board.Şekil_Ekle(ş);
            }
            if (daire && yellow)
            {
                ŞekilButton ş = new ŞekilButton(0, Color.Yellow);
                board.Şekil_Ekle(ş);
            }
            if (daire && green)
            {
                ŞekilButton ş = new ŞekilButton(0, Color.Green);
                board.Şekil_Ekle(ş);
            }
            Sekil_Atama();
            Skor_Kaydet();
        }
        int null_button;
        public void Board_Oluştur()
        {
            for (int x = 0; x < Game_panel.Width; x = x + 30)
            {
                for (int y = 0; y < Game_panel.Height; y = y + 30)
                {
                    Button_Ekle(new Point(x, y));
                }
            }
            null_button = (Game_panel.Width / 30) * (Game_panel.Height / 30);
        }
        public void Button_Ekle(Point loc)
        {
            ŞekilButton btn = new ŞekilButton(-1, Color.Transparent);
            btn.Name = "btn" + "(" + loc.X / 30 + "," + loc.Y / 30 + ")";
            btn.Size = new Size(30, 30);
            btn.Location = loc;
            btn.BackColor = Color.White;
            btn.Click += new EventHandler(btn_Click);
            Game_panel.Controls.Add(btn);


        }

        public void Sekil_Atama()
        {

            
            for (int i = 0; i < 3; i++)
            {

                int sayi = rastgele.Next(board.Get_Şekiller().Count());
                int x = rastgele.Next(Game_panel.Width / 30);
                int y = rastgele.Next(Game_panel.Height / 30);
                ŞekilButton btn = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x + "," + y + ")", false)[0];
                if (btn.Image == null && null_button != 0)
                {
                    Bitmap objBitmap = new Bitmap(board.Get_Şekiller()[sayi].Image, new Size(20, 20));
                    btn.Image = objBitmap;
                    btn.renk = board.Get_Şekiller()[sayi].renk;
                    btn.model = board.Get_Şekiller()[sayi].model;
                    null_button--;
                }
                else if (btn.Image != null && null_button != 0)
                {
                    i--;
                }
               
            }
    

        }

        /* Oyun recursive olarak işleyecek. Oyun başlandığında üç ŞekilButton atanır ve kullanıcıdan girdi beklenir.Hamle yapılır ve 
         * program 5 aynı ŞekilButton yan yana mı diye kontrol eder. Eğer öyleyse ŞekilButtonleri siler ve puan tablosuna gerekli puan eklenir.
         * Değil ise Oyna fonksiyonu tekrar çağırılır ve 3 ŞekilButton atanarak oyun hareket edecek buton kalmayana kadar tekrarlanır.
          */

        //DÜZENLE
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

        private void Skor_Kaydet()
        {
            string kullaniciAdi = Properties.Settings.Default.kullaniciAdi;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserName,Score from USER_INFO", con);
            SqlDataReader sqlRead = cmd.ExecuteReader();
       
            //sql komutları DÜZENLE
            //veri tabanındaki herkesin puanını 0 tanımla en başta.
            //best skoru ekranda göster.
            while (sqlRead.Read())
            {
                if (kullaniciAdi == sqlRead[0].ToString())
                {
                    label3.Text = sqlRead[1].ToString();
                    if (ToplamPuan > int.Parse(sqlRead[1].ToString()))
                    {
                        con.Close();
                        con.Open();
                        SqlCommand komut = new SqlCommand("update USER_INFO set Score= " +ToplamPuan+" where UserName ='" + kullaniciAdi + "'", con);
                        label3.Text = ToplamPuan.ToString();
                        komut.ExecuteNonQuery();
                        con.Close();
                        break;
                    }
                }
          
            }
            con.Close();
        }
        bool patlamaVarmi = false;
        private void btn_Click(object sender, EventArgs e)
        {
            ŞekilButton button;
            Ses.URL = "Click.mp3";
            bool flag = false;

            if (sender is ŞekilButton)
            {
                button = (ŞekilButton)sender;
            
                if (button.Image != null)//Tıklanan butonda ŞekilButton varsa
                {

                    Point loc = button.Location;
                    Point a = loc + new Size(30, 0);// a,b,c,d clockwise 
                    Point b = loc + new Size(0, 30);
                    Point c = loc + new Size(-30, 0);
                    Point d = loc + new Size(0, -30);


                    Properties.Settings.Default.SecilenBtnX1 = loc.X / 30;
                    Properties.Settings.Default.SecilenBtnY1 = loc.Y / 30;
                    Properties.Settings.Default.Save();

                    foreach (ŞekilButton btn in Game_panel.Controls)
                    {
                        if (btn.Location == a || btn.Location == b || btn.Location == c || btn.Location == d)//Eğer çevresinde 1 boş kutucuk 
                        {                                                                                    // varsa seçime izin verir.
                            if (btn.Image == null)
                            {
                                button.Enabled = true;
                                flag = true;

                            }
                        }
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Şekli hareket ettiremezsiniz!11111");


                    }
                }

                else if (button.Image == null && (Properties.Settings.Default.SecilenBtnX1 != -1 && Properties.Settings.Default.SecilenBtnY1 != -1)) //Tıklanan butonda ŞekilButton yoksa
                {
                    Point loc = button.Location;

                    Properties.Settings.Default.SecilenBtnX2 = loc.X / 30;
                    Properties.Settings.Default.SecilenBtnY2 = loc.Y / 30;
                    Properties.Settings.Default.Save();
                    backgroundWorker1.RunWorkerAsync();
                }

            }
        }



        public void Oyun()
        {


            int x1 = Properties.Settings.Default.SecilenBtnX1;
            int y1 = Properties.Settings.Default.SecilenBtnY1;
            int x2 = Properties.Settings.Default.SecilenBtnX2;
            int y2 = Properties.Settings.Default.SecilenBtnY2;

            Properties.Settings.Default.SecilenBtnX1 = -1;
            Properties.Settings.Default.SecilenBtnY1 = -1;
            Properties.Settings.Default.SecilenBtnX2 = -1;
            Properties.Settings.Default.SecilenBtnY2 = -1;
            Properties.Settings.Default.Save();

            ŞekilButton button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
            pictureBox1.Image = button1.Image;







            Point X1Y1 = new Point(x1 * 30, y1 * 30);
            Point X2Y2 = new Point(x2 * 30, y2 * 30);


            ŞekilButton buttonA = new ŞekilButton();
            ŞekilButton buttonB = new ŞekilButton();
            ŞekilButton buttonC = new ŞekilButton();
            ŞekilButton buttonD = new ŞekilButton();


            Point a = X1Y1 + new Size(30, 0);// a,b,c,d clockwise 
            Point b = X1Y1 + new Size(0, 30);
            Point c = X1Y1 + new Size(-30, 0);
            Point d = X1Y1 + new Size(0, -30);
            foreach (Button btn in Game_panel.Controls)
            {

                if (btn.Location == a)
                {
                    buttonA = (ŞekilButton)btn;
                    if (a.X < 0 || a.Y < 0)
                    {
                        buttonA.Location = new Point(-1, -1);
                        buttonA.Image = Image.FromFile("engel.jpg");
                    }
                }
                else if (btn.Location == b)
                {
                    buttonB = (ŞekilButton)btn;
                    if (b.X < 0 || b.Y < 0)
                    {
                        buttonB.Location = new Point(-1, -1);
                        buttonB.Image = Image.FromFile("engel.jpg");
                    }
                }
                else if (btn.Location == c)
                {
                    buttonC = (ŞekilButton)btn;
                    if (c.X < 0 || c.Y < 0)
                    {
                        buttonC.Location = new Point(-1, -1);
                        buttonC.Image = Image.FromFile("engel.jpg");
                    }
                }
                else if (btn.Location == d)
                {
                    buttonD = (ŞekilButton)btn;
                    if (d.X < 0 || d.Y < 0)
                    {
                        buttonD.Location = new Point(-1, -1);
                        buttonD.Image = Image.FromFile("engel.jpg");
                    }
                }
            }
            bool temp = true;
            //Button_Ekle(X1Y1);
            while (X1Y1.X != X2Y2.X || X1Y1.Y != X2Y2.Y)
            {

                Thread.Sleep(100);
                if (X1Y1.X != X2Y2.X)
                {
                    if (X1Y1.X < X2Y2.X && X1Y1.Y <= X2Y2.Y)
                    {
                        if (buttonA.Image == null && buttonA.visited == false)
                        {
                            //x1++;
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonB.Image == null && buttonB.visited == false)
                        {
                            //y1++;

                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonD.Image == null && buttonD.visited == false)
                        {
                            // y1--;

                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonC.Image == null && buttonC.visited == false)
                        {
                            // x1--;

                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }

                    }
                    else if (X1Y1.X < X2Y2.X && X1Y1.Y > X2Y2.Y)
                    {

                        if (buttonA.Image == null && buttonA.visited == false)
                        {
                            //x1++;
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonD.Image == null && buttonD.visited == false)
                        {
                            //y1--;
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonB.Image == null && buttonB.visited == false)
                        {
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                            //y1++;
                        }
                        else if (buttonC.Image == null && buttonC.visited == false)
                        {
                            //x1--;
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }


                    }
                    else if (X1Y1.X > X2Y2.X && X1Y1.Y <= X2Y2.Y)
                    {
                        if (buttonC.Image == null && buttonC.visited == false)
                        {
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                            // x1--;
                        }
                        else if (buttonB.Image == null && buttonB.visited == false)
                        {
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                            // y1++;
                        }
                        else if (buttonD.Image == null && buttonD.visited == false)
                        {
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                            //y1--;
                        }
                        else if (buttonA.Image == null && buttonA.visited == false)
                        {
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                            //x1++;
                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;

                        }


                    }
                    else if (X1Y1.X > X2Y2.X && X1Y1.Y > X2Y2.Y)
                    {
                        if (buttonC.Image == null && buttonC.visited == false)
                        {
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                            //x1--;
                        }
                        else if (buttonD.Image == null && buttonD.visited == false)
                        {
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];
                            //y1--;
                        }
                        else if (buttonB.Image == null && buttonB.visited == false)
                        {
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                            // y1++;
                        }
                        else if (buttonA.Image == null && buttonA.visited == false)
                        {
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                            //x1++;
                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }

                    }
                }
                else if (X1Y1.Y != X2Y2.Y)
                {
                    if (X1Y1.Y < X2Y2.Y && X1Y1.X <= X2Y2.X)
                    {
                        if (buttonB.Image == null && buttonB.visited == false)
                        {
                            //y1++;
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonA.Image == null && buttonA.visited == false)
                        {
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                            //x1++;
                        }
                        else if (buttonC.Image == null && buttonC.visited == false)
                        {
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                            //x1--;
                        }
                        else if (buttonD.Image == null && buttonD.visited == false)
                        {
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                            // y1--;
                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }


                    }
                    else if (X1Y1.Y < X2Y2.Y && X1Y1.X > X2Y2.X)
                    {
                        if (buttonB.Image == null && buttonB.visited == false)
                        {
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                            //y1++;
                        }
                        else if (buttonC.Image == null && buttonC.visited == false)
                        {
                            //x1--;
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonA.Image == null && buttonA.visited == false)
                        {
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                            //x1++;
                        }
                        else if (buttonD.Image == null && buttonD.visited == false)
                        {
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                            //y1--;
                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }

                    }
                    else if (X1Y1.Y > X2Y2.Y && X1Y1.X <= X2Y2.X)
                    {
                        if (buttonD.Image == null && buttonD.visited == false)
                        {
                            //y1--;
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                        }
                        else if (buttonA.Image == null && buttonA.visited == false)
                        {
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                            //x1++;
                        }
                        else if (buttonC.Image == null && buttonC.visited == false)
                        {
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                            //x1--;
                        }
                        else if (buttonB.Image == null && buttonB.visited == false)
                        {
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                            //y1++;
                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (X1Y1.Y > X2Y2.Y && X1Y1.X > X2Y2.X)
                    {
                        if (buttonD.Image == null && buttonD.visited == false)
                        {
                            buttonD.renk = button1.renk;
                            buttonD.model = button1.model;
                            buttonD.Image = pictureBox1.Image;
                            buttonD.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonD.Location.X / 30 + "," + buttonD.Location.Y / 30 + ")", false)[0];

                            //y1--;
                        }
                        else if (buttonC.Image == null && buttonC.visited == false)
                        {
                            buttonC.renk = button1.renk;
                            buttonC.model = button1.model;
                            buttonC.Image = pictureBox1.Image;
                            buttonC.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonC.Location.X / 30 + "," + buttonC.Location.Y / 30 + ")", false)[0];

                            // x1--;
                        }
                        else if (buttonA.Image == null && buttonA.visited == false)
                        {
                            buttonA.renk = button1.renk;
                            buttonA.model = button1.model;
                            buttonA.Image = pictureBox1.Image;
                            buttonA.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonA.Location.X / 30 + "," + buttonA.Location.Y / 30 + ")", false)[0];

                            //x1++;
                        }
                        else if (buttonB.Image == null && buttonB.visited == false)
                        {
                            buttonB.renk = button1.renk;
                            buttonB.model = button1.model;
                            buttonB.Image = pictureBox1.Image;
                            buttonB.visited = true;
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + buttonB.Location.X / 30 + "," + buttonB.Location.Y / 30 + ")", false)[0];

                            //y1++;
                        }
                        else
                        {
                            button1.renk = Color.Transparent;
                            button1.model = -1;
                            button1.Image = null;
                            MessageBox.Show("Şekli hareket ettiremezsiniz!");
                            button1 = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x1 + "," + y1 + ")", false)[0];
                            button1.Image = pictureBox1.Image;
                            temp = false;
                            break;
                        }

                    }
                }

                //bw=new BackgroundWorker();
                //bw.DoWork += (sender, e) => TasksAsync(10);

                //timer1.Start();

                X1Y1 = button1.Location;

                a = X1Y1 + new Size(30, 0);// a,b,c,d clockwise 
                b = X1Y1 + new Size(0, 30);
                c = X1Y1 + new Size(-30, 0);
                d = X1Y1 + new Size(0, -30);

                foreach (Button btn in Game_panel.Controls)
                {
                    if (btn.Location == a)
                    {
                        buttonA = (ŞekilButton)btn;
                        if (a.X < 0 || a.Y < 0)
                        {
                            buttonA.Location = new Point(-1, -1);
                            buttonA.Image = Image.FromFile("engel.jpg");
                        }
                    }
                    else if (btn.Location == b)
                    {
                        buttonB = (ŞekilButton)btn;
                        if (b.X < 0 || b.Y < 0)
                        {
                            buttonB.Location = new Point(-1, -1);
                            buttonB.Image = Image.FromFile("engel.jpg");
                        }
                    }
                    else if (btn.Location == c)
                    {
                        buttonC = (ŞekilButton)btn;
                        if (c.X < 0 || c.Y < 0)
                        {
                            buttonC.Location = new Point(-1, -1);
                            buttonC.Image = Image.FromFile("engel.jpg");
                        }
                    }
                    else if (btn.Location == d)
                    {
                        buttonD = (ŞekilButton)btn;
                        if (d.X < 0 || d.Y < 0)
                        {
                            buttonD.Location = new Point(-1, -1);
                            buttonD.Image = Image.FromFile("engel.jpg");
                        }
                    }
                }
            }
            foreach (Button btn in Game_panel.Controls)
            {
                ŞekilButton btnx = (ŞekilButton)btn;
                btnx.visited = false;
            }

            Patlatma((ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x2 + "," + y2 + ")", false)[0]);
            if (patlamaVarmi == false && temp == true)
            {
                Sekil_Atama();
            }
            for (int i = 0; i < Game_panel.Width / 30; i++)
            {
                for (int j = 0; j < Game_panel.Height / 30; j++)
                {
                    Patlatma((ŞekilButton)Game_panel.Controls.Find("btn" + "(" + i + "," + j + ")", false)[0]);
                }
            }


            Skor_Kaydet();
            if (null_button == 0)
            {
                MessageBox.Show("GAME OVER");
                Form2 f2 = new Form2();
                this.Close();
                f2.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            help.ShowDialog();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (null_button != 0)////////////////////////////////////////////////////
            {
                Oyun();
            }
        }

        // Her hamleden sonra tüm butonları tek tek geziyor. Üzerinde olduğu butonun
        // resmini picturebox2 ye kaydediyor. Butonun yatay ve dikey komşularını geziyor.
        // Aynı ŞekilButton komşuda da varsa değerini bir artırıyor. Topplamda 5 aynı ŞekilButton
        // varsa hepsini silip puan ekliyor. 

        public void Patlatma(ŞekilButton btn)
        {
            List<ŞekilButton> besliSetX = new List<ŞekilButton>();
            besliSetX.Add(btn);
            List<ŞekilButton> besliSetY = new List<ŞekilButton>();
            besliSetY.Add(btn);
            int xx = btn.Location.X;
            int yy = btn.Location.Y;
            patlamaVarmi = false;

            //Yatayda yanındaki 8 kutuya bakacak
            for (int x = xx + 30; x < Game_panel.Width; x = x + 30)
            {
                ŞekilButton sb = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x / 30 + "," + yy / 30 + ")", false)[0];
                if (sb.Image != null && sb.renk == btn.renk && sb.model == btn.model)
                {

                    besliSetX.Add(sb);
                }
                else
                {
                    break;
                }
            }
            for (int x = xx - 30; x >= 0; x = x - 30)
            {
                ŞekilButton sb = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + x / 30 + "," + yy / 30 + ")", false)[0];
                if (sb.Image != null && sb.renk == btn.renk && sb.model == btn.model)
                {

                    besliSetX.Add(sb);
                }
                else
                {
                    break;
                }
            }


            //Dikeyde yanındaki 8 kutuya bakacak
            for (int y = yy + 30; y < Game_panel.Height; y = y + 30)
            {
                ŞekilButton sb = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + xx / 30 + "," + y / 30 + ")", false)[0];
                if (sb.Image != null && sb.renk == btn.renk && sb.model == btn.model)
                {

                    besliSetY.Add(sb);
                }
                else
                {
                    break;
                }
            }
            for (int y = yy - 30; y >= 0; y = y - 30)
            {
                ŞekilButton sb = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + xx / 30 + "," + y / 30 + ")", false)[0];
                if (sb.Image != null && sb.renk == btn.renk && sb.model == btn.model)
                {

                    besliSetY.Add(sb);
                }
                else
                {
                    break;
                }
            }
            bool PatX = false;
            bool PatY = false;

            if (besliSetX.Count() >= 5 || besliSetY.Count() >= 5)
            {
                Ses.URL = "Congratulations.mp3";
                patlamaVarmi = true;
                if (besliSetX.Count() >= 5)
                {
                    foreach (var item in besliSetX)
                    {
                        ŞekilButton sb = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + item.Location.X / 30 + "," + item.Location.Y / 30 + ")", false)[0];
                        sb.renk = Color.Transparent;
                        sb.model = -1;
                        sb.Image = null;
                        

                    }
                    PatX = true;
                }
                if (besliSetY.Count() >= 5)
                {
                    foreach (var item in besliSetY)
                    {
                        ŞekilButton sb = (ŞekilButton)Game_panel.Controls.Find("btn" + "(" + item.Location.X / 30 + "," + item.Location.Y / 30 + ")", false)[0];
                        sb.renk = Color.Transparent;
                        sb.model = -1;
                        sb.Image = null;
                  
                    }
                    PatY = true;
                }
            }
            if (patlamaVarmi)
            {

                if (PatX == true && PatY == true)
                {
                    patSayi = besliSetX.Count() + besliSetY.Count() - 1;
                }
                else if (PatX == true)
                {
                    patSayi = besliSetX.Count();
                }
                else if (PatY == true)
                {
                    patSayi = besliSetY.Count();
                }
            }
            null_button += patSayi;
            ToplamPuan = (board.puan * patSayi) + ToplamPuan;
            label2.Text = ToplamPuan.ToString();

            besliSetX.Clear();
            besliSetY.Clear();
            patSayi = 0;

        }


    }
}
    


