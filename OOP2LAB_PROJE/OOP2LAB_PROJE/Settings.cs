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

namespace OOP2LAB_PROJE
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Oku("ayarlar.txt");
        }
        //Verileri kaydetmek için istenen dosya yok ise yeni dosya oluşturur, var ise dosyayı açar.
        private FileStream Dosya_Oluştur_Ulas()
        {
            string dosya_yolu = "ayarlar.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            return fs;
        }
        bool hata ;
        //Kaydet butonuna basıldığında çağırılan fonksiyondur.Verileri oluşan dosyaya kaydeder.
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            hata = false;

            StreamWriter sw = new StreamWriter(Dosya_Oluştur_Ulas());
            sw.WriteLine("{0}", kolayToolStripMenuItem.Checked);
            sw.WriteLine("{0}", ortaToolStripMenuItem.Checked);
            sw.WriteLine("{0}", zorToolStripMenuItem.Checked);
            sw.WriteLine("{0}", özelSeçeneklerToolStripMenuItem.Checked);
            if (özelSeçeneklerToolStripMenuItem.Checked)
            {   if (int.Parse(txt_En.Text)<= 5 && int.Parse(txt_Boy.Text)<= 5)
                {
                    MessageBox.Show("Girilen boyutlarda board oluşturulamaz.Row ve Column seçenelerini 5'ten büyük değerler giriniz.");
                    özelSeçeneklerToolStripMenuItem.Checked = false;
                    hata = true;
                }
                sw.WriteLine("{0}", txt_Boy.Text);
                sw.WriteLine("{0}", txt_En.Text);
            }
            sw.WriteLine("{0}", kareToolStripMenuItem.Checked);
            sw.WriteLine("{0}", üçgenToolStripMenuItem.Checked);
            sw.WriteLine("{0}", daireToolStripMenuItem.Checked);
            sw.WriteLine("{0}", greenToolStripMenuItem.Checked);
            sw.WriteLine("{0}", yellowToolStripMenuItem.Checked);
            sw.WriteLine("{0}", redToolStripMenuItem.Checked);

            sw.Flush();
            sw.Close();
            int i = 0,j=0 ;
            if(kareToolStripMenuItem.Checked)
            { i++; }
            if(üçgenToolStripMenuItem.Checked)
            { i++; }
            if(daireToolStripMenuItem.Checked)
            { i++; }
            if(greenToolStripMenuItem.Checked)
            { j++; }
            if(yellowToolStripMenuItem.Checked)
            { j++; }
            if(redToolStripMenuItem.Checked)
            { j++; }
            if((i==0||i==1 )&&(j==0||j==1))
            {
                MessageBox.Show("Please choose more colors or shapes.");
                hata = true;
            }
           
        }

        private int ConvertInt32(string text)
        {
            throw new NotImplementedException();
        }

        //Kayıtlı veriler bulunan dosyadan verileri okur.
        private void Oku(string dy)
        {
            StreamReader sw = new StreamReader(Dosya_Oluştur_Ulas());

            kolayToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            ortaToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            zorToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            özelSeçeneklerToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            if (özelSeçeneklerToolStripMenuItem.Checked)
            {
                txt_Boy.Text = sw.ReadLine();
                txt_En.Text = sw.ReadLine();
            }
            kareToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            üçgenToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            daireToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            greenToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            yellowToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            redToolStripMenuItem.Checked = Convert.ToBoolean(sw.ReadLine());
            sw.Close();
        }
        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ortaToolStripMenuItem.Checked = false;
            zorToolStripMenuItem.Checked = false;
            özelSeçeneklerToolStripMenuItem.Checked = false;
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolayToolStripMenuItem.Checked = false;
            zorToolStripMenuItem.Checked = false;
            özelSeçeneklerToolStripMenuItem.Checked = false;
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolayToolStripMenuItem.Checked = false;
            ortaToolStripMenuItem.Checked = false;
            özelSeçeneklerToolStripMenuItem.Checked = false;
        }


        private void özelSeçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolayToolStripMenuItem.Checked = false;
            ortaToolStripMenuItem.Checked = false;
            zorToolStripMenuItem.Checked = false;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(hata)
            {
                e.Cancel = true;
                MessageBox.Show("İstenileni yapmadan formu kapatamazsınız.");
            }
        }
    }
}


