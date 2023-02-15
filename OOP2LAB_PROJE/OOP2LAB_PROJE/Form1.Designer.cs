namespace OOP2LAB_PROJE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.rBtnKullanici = new System.Windows.Forms.RadioButton();
            this.rBtnYonetici = new System.Windows.Forms.RadioButton();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkŞifreGöster = new System.Windows.Forms.CheckBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGiris.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGiris.Location = new System.Drawing.Point(266, 281);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(189, 35);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Log In";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(266, 178);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(189, 30);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // rBtnKullanici
            // 
            this.rBtnKullanici.AutoSize = true;
            this.rBtnKullanici.Location = new System.Drawing.Point(266, 118);
            this.rBtnKullanici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnKullanici.Name = "rBtnKullanici";
            this.rBtnKullanici.Size = new System.Drawing.Size(74, 29);
            this.rBtnKullanici.TabIndex = 0;
            this.rBtnKullanici.Text = "User";
            this.rBtnKullanici.UseVisualStyleBackColor = true;
            // 
            // rBtnYonetici
            // 
            this.rBtnYonetici.AutoSize = true;
            this.rBtnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnYonetici.Location = new System.Drawing.Point(366, 118);
            this.rBtnYonetici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rBtnYonetici.Name = "rBtnYonetici";
            this.rBtnYonetici.Size = new System.Drawing.Size(89, 29);
            this.rBtnYonetici.TabIndex = 0;
            this.rBtnYonetici.Text = "Admin";
            this.rBtnYonetici.UseVisualStyleBackColor = true;
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKaydol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnKaydol.Location = new System.Drawing.Point(266, 348);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(189, 32);
            this.btnKaydol.TabIndex = 4;
            this.btnKaydol.Text = "Sing Up";
            this.btnKaydol.UseVisualStyleBackColor = false;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(342, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // chkŞifreGöster
            // 
            this.chkŞifreGöster.AutoSize = true;
            this.chkŞifreGöster.Location = new System.Drawing.Point(476, 229);
            this.chkŞifreGöster.Name = "chkŞifreGöster";
            this.chkŞifreGöster.Size = new System.Drawing.Size(138, 29);
            this.chkŞifreGöster.TabIndex = 6;
            this.chkŞifreGöster.TabStop = false;
            this.chkŞifreGöster.Text = "Şİfre Göster";
            this.chkŞifreGöster.UseVisualStyleBackColor = true;
            this.chkŞifreGöster.CheckStateChanged += new System.EventHandler(this.chkŞifreGöster_CheckedChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(266, 231);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(189, 30);
            this.txtSifre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(578, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "About Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(285, 428);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(185, 29);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Multiplayer Game";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(735, 504);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.chkŞifreGöster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.rBtnYonetici);
            this.Controls.Add(this.rBtnKullanici);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.RadioButton rBtnKullanici;
        private System.Windows.Forms.RadioButton rBtnYonetici;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkŞifreGöster;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}



