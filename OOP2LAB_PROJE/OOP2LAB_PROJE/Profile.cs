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
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Data.SqlClient;


namespace OOP2LAB_PROJE
{
    public partial class Profile : Form
    {
        public string username;
        public Profile()
        {
            InitializeComponent();

        }
        //Bilgileri Güncelleyen Fonksiyon
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool temp=false;
            string name = Properties.Settings.Default.username;
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

            bag.Open();
            SqlCommand com = new SqlCommand("select Password from USER_INFO where UserName ='" + name + "'", bag);
            SqlDataReader sqlRead = com.ExecuteReader();
            while (sqlRead.Read())
            {
                if (SHA256Hash(txtChk_Password.Text) == sqlRead[0].ToString()) 
              {
                    temp = true;
                    break;
              }
            }
            bag.Close();


            if (temp)
            {
                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

                string username = Properties.Settings.Default.username;
                con.Open();
                SqlCommand komut = new SqlCommand("update USER_INFO set Password= @Password,NameSurname= @Name_Surname,PhoneNumber = @PhoneNumber,Address=@Address,City=@City,Country=@Country,Email= @Email where UserName ='" + username + "'", con);

                komut.Parameters.AddWithValue("@Password", SHA256Hash(txtPassword.Text));
                komut.Parameters.AddWithValue("@Name_Surname", txtNameSurname.Text);
                komut.Parameters.AddWithValue("@PhoneNumber", txtPhoneNum.Text);
                komut.Parameters.AddWithValue("@Address ", txtAddress.Text);
                komut.Parameters.AddWithValue("@City", txtCity.Text);
                komut.Parameters.AddWithValue("@Country", txtCountry.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("User's Informations Are Updated Successfully");
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password!.Please try again.");
            }
        }
        
        //Kullanıcıyı Silen Fonksiyon
        private void btnDelete_Click(object sender, EventArgs e)
        {

            bool temp = false;
            string name = Properties.Settings.Default.username;
            string passw="";
            //SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
            SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

            bag.Open();
            SqlCommand com = new SqlCommand("select Password from USER_INFO where UserName ='" + name + "'", bag);
            SqlDataReader sqlRead = com.ExecuteReader();
            while (sqlRead.Read())
            {
                if (SHA256Hash(txtChk_Password.Text) == sqlRead[0].ToString())
                {
                    passw = sqlRead[0].ToString();
                    temp = true;
                    break;
                }
            }
            bag.Close();

            if (temp)
            {
              
                string username = Properties.Settings.Default.username;
                bag.Open();
                SqlCommand komut = new SqlCommand(" delete USER_INFO where UserName ='" + name + "' and Password= ' "+passw+"'"  , bag);
                komut.ExecuteNonQuery();
                bag.Close();

                Form1 ff = new Form1();
                ActiveForm.Hide();
                ff.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password!.Please try again.");
            }
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
        //Form Yüklenirken Bilgileri Çeken Fonksiyon
        private void Profile_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

            string name = Properties.Settings.Default.username;
            con.Open();
            SqlCommand cmd = new SqlCommand("select Password, NameSurname,PhoneNumber,Address,City,Country,Email from USER_INFO where UserName= '" + name + "'", con);
            SqlDataReader sqlRead = cmd.ExecuteReader();
            while (sqlRead.Read())
            {
                txtUserName.Text = name;
                txtPassword.Text = "user";
                txtNameSurname.Text = sqlRead[1].ToString();
                txtPhoneNum.Text = sqlRead[2].ToString();
                txtAddress.Text = sqlRead[3].ToString();
                txtCity.Text = sqlRead[4].ToString();
                txtCountry.Text = sqlRead[5].ToString();
                txtEmail.Text = sqlRead[6].ToString();
            }
            con.Close();
        }
    }
}

