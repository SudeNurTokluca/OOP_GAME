using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using SortOrder = System.Windows.Forms.SortOrder;

namespace OOP2LAB_PROJE
{
    public partial class ManageScreen : Form
    {

        public ManageScreen()
        {
            InitializeComponent();

        }

        //Admini SignUp sayfasına yönlendirerek yeni kullanıcı kaydı yapan fonksiyon.
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //FormSingUp ekranını açar.
            SingUp SU = new SingUp();
            SU.ShowDialog();

            btnList_Click(sender, e);
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

        //Adminin isteği kullanıcının bilgilerini güncelleyen fonksiyon.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UpdateUserInfo sayfasını açar.
            UpdateUserInfo UI = new UpdateUserInfo();
            UI.Show();


        }
        //Tüm kullanıcıları listeler.
        private void btnList_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserName,Score from USER_INFO", con);

            SqlDataReader sqlRead = cmd.ExecuteReader();
            while (sqlRead.Read())
            {
                string[] satir = { sqlRead[0].ToString(), sqlRead[1].ToString() };
                ListViewItem eklenecekSatir = new ListViewItem(satir);
                listView1.Items.Add(eklenecekSatir);
            }
            con.Close();

        }

        // Seçilen kullanıcının verilerini XML dosyasından silen fonksiyon.
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult x = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                string name = listView1.SelectedItems[0].Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("delete USER_INFO WHERE UserName= '" + name + "'", con);
                cmd.ExecuteNonQuery();
                pictureBox1.Visible = true;
                con.Close();
            }
            else if (x == DialogResult.No)
            {

            }

            btnList_Click(sender, e);
        }

        private void ManageScreen_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "";
        }

        //Seçilen kullanıcının adını saklayan fonksiyon.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = listView1.SelectedItems[0].Text;
            Properties.Settings.Default.Save();
        }
        //SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");



        private void btnSiralaArtis_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
       
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserName,Score from USER_INFO ORDER BY Score ASC", con);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string[] satir = { read[0].ToString(), read[1].ToString() };
                ListViewItem eklenecekSatir = new ListViewItem(satir);
                listView1.Items.Add(eklenecekSatir);
            }
            con.Close();

        }

        private void btnSiralaAzal_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserName,Score from USER_INFO ORDER BY Score DESC", con);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string[] satir = { read[0].ToString(), read[1].ToString() };
                ListViewItem eklenecekSatir = new ListViewItem(satir);
                listView1.Items.Add(eklenecekSatir);
            }
            con.Close();

        }
    }
}


