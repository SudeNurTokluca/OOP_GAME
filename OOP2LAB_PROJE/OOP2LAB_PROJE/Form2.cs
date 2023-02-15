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

namespace OOP2LAB_PROJE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        //Exit butonuna tıklandığında çalışan fonksiyondur. Log In ekranına dönüş sağlanır.
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
            f1.Show();

            this.Hide();
        }

        //Ayarlar butonuna tıklanınca Form3 ekranı açılır.
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Form3 ekranını açar.
            Settings f3 = new Settings();
            f3.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Profil ekranını açar.
            Profile p = new Profile();
            p.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            this.Enabled = false;

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }
    }
}


