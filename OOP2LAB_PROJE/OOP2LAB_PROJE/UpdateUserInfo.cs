using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class UpdateUserInfo : Form
    {
        public UpdateUserInfo()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt8);
            this.groupBox1.Controls.Add(this.txt7);
            this.groupBox1.Controls.Add(this.txt6);
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(581, 263);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(249, 30);
            this.txt8.TabIndex = 15;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(581, 194);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(249, 30);
            this.txt7.TabIndex = 14;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(581, 127);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(249, 30);
            this.txt6.TabIndex = 13;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(581, 58);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(249, 30);
            this.txt5.TabIndex = 12;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(192, 265);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(230, 30);
            this.txt4.TabIndex = 11;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(192, 196);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(230, 30);
            this.txt3.TabIndex = 10;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(192, 127);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(230, 30);
            this.txt2.TabIndex = 9;
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(192, 58);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(230, 30);
            this.txt1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name-Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdate.Location = new System.Drawing.Point(371, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 49);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateUserInfo
            // 
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(912, 464);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "UpdateUserInfo";
            this.Load += new System.EventHandler(this.UpdateUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        //XML dosyasındaki bilgileri güncelleyen fonksiyon.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

            string username = Properties.Settings.Default.username;
            con.Open();
            SqlCommand komut = new SqlCommand("update USER_INFO set Password= @Password,NameSurname= @Name_Surname,PhoneNumber = @PhoneNumber,Address=@Address,City=@City,Country=@Country,Email= @Email where UserName ='"+username+"'", con);

            komut.Parameters.AddWithValue("@Password", SHA256Hash(txt2.Text));
            komut.Parameters.AddWithValue("@Name_Surname", txt3.Text);
            komut.Parameters.AddWithValue("@PhoneNumber", txt4.Text);
            komut.Parameters.AddWithValue("@Address ", txt5.Text);
            komut.Parameters.AddWithValue("@City", txt6.Text);
            komut.Parameters.AddWithValue("@Country", txt7.Text);
            komut.Parameters.AddWithValue("@Email", txt8.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("User's Informations Are Updated Successfully");
            this.Hide();
            con.Close();
        }
        //Ekran açılırken txt bilgilerini XML dosyasından alan fonksiyon.
        private void UpdateUserInfo_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OFUI204;Initial Catalog=Game;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JLNV27O;Initial Catalog=Game;Integrated Security=True");

            string name = Properties.Settings.Default.username;
            con.Open();
            SqlCommand cmd = new SqlCommand("select Password, NameSurname,PhoneNumber,Address,City,Country,Email from USER_INFO where UserName= '"+name+"'", con);
            SqlDataReader sqlRead = cmd.ExecuteReader();
            while (sqlRead.Read())
            {
                txt1.Text = name;
                txt2.Text = sqlRead[0].ToString();
                txt3.Text = sqlRead[1].ToString();
                txt4.Text = sqlRead[2].ToString();
                txt5.Text = sqlRead[3].ToString();
                txt6.Text = sqlRead[4].ToString();
                txt7.Text = sqlRead[5].ToString();
                txt8.Text = sqlRead[6].ToString();
            }
             con.Close();
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
