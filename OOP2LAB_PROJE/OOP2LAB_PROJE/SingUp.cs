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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }
       
        
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");


        private void btn_SıngUpOK_Click(object sender, EventArgs e)
        {
           
            bool flag = true;
            if (txt_Username.Text==""|| txt_Password.Text == "" || txt_Name_Surname.Text == "" || txt_PhoneNumber.Text == "" ||
                txt_Address.Text == "" || txt_City.Text == "" || txt_Country.Text == "" || txt_Email.Text == "")
            {
                flag = false;
                MessageBox.Show("Please check your information.");
            }

            if (flag)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("insert into USER_INFO(Username, Password, NameSurname,PhoneNumber,Address,City,Country,Email )  values ( @Username , @Password,@Name_Surname,@PhoneNumber,@Address,@City,@Country, @Email)", con);                                   
                komut.Parameters.AddWithValue("@Username ", txt_Username.Text);
                komut.Parameters.AddWithValue("@Password", SHA256Hash(txt_Password.Text));
                komut.Parameters.AddWithValue("@Name_Surname", txt_Name_Surname.Text);
                komut.Parameters.AddWithValue("@PhoneNumber", txt_PhoneNumber.Text);
                komut.Parameters.AddWithValue("@Address ", txt_Address.Text);
                komut.Parameters.AddWithValue("@City", txt_City.Text);
                komut.Parameters.AddWithValue("@Country", txt_Country.Text);
                komut.Parameters.AddWithValue("@Email", txt_Email.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Congratulations, your registration is complete.");
                con.Close();
                this.Hide();
            }
         
        }

        private void SingUp_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Kayıtlar_Users.xml"))
            {
                XmlTextWriter dosya = new XmlTextWriter(@"Kayıtlar_Users.xml", Encoding.UTF8);
                dosya.Formatting = Formatting.Indented;
                dosya.WriteStartDocument();
                dosya.WriteStartElement("Users");
                dosya.WriteEndElement();
                dosya.Close();
            }
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
