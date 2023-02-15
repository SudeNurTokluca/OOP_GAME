namespace OOP2LAB_PROJE
{
    partial class ManageScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageScreen));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSiralaArtis = new System.Windows.Forms.Button();
            this.btnSiralaAzal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddUser.Location = new System.Drawing.Point(617, 67);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(222, 39);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(617, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 59);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update User\'s Information";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Location = new System.Drawing.Point(617, 116);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(222, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnList.Location = new System.Drawing.Point(119, 323);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(222, 39);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List All Users";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(362, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(635, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "**Please select user from the table to perform the operations on the right.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.BestScore});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 183);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // UserName
            // 
            this.UserName.Text = "UserName";
            this.UserName.Width = 200;
            // 
            // BestScore
            // 
            this.BestScore.Text = "Best Score";
            this.BestScore.Width = 200;
            // 
            // btnSiralaArtis
            // 
            this.btnSiralaArtis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSiralaArtis.Location = new System.Drawing.Point(119, 373);
            this.btnSiralaArtis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiralaArtis.Name = "btnSiralaArtis";
            this.btnSiralaArtis.Size = new System.Drawing.Size(222, 39);
            this.btnSiralaArtis.TabIndex = 15;
            this.btnSiralaArtis.Text = "Sort By Ascending";
            this.btnSiralaArtis.UseVisualStyleBackColor = false;
            this.btnSiralaArtis.Click += new System.EventHandler(this.btnSiralaArtis_Click);
            // 
            // btnSiralaAzal
            // 
            this.btnSiralaAzal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSiralaAzal.Location = new System.Drawing.Point(119, 422);
            this.btnSiralaAzal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiralaAzal.Name = "btnSiralaAzal";
            this.btnSiralaAzal.Size = new System.Drawing.Size(222, 39);
            this.btnSiralaAzal.TabIndex = 16;
            this.btnSiralaAzal.Text = "Sort By Descending";
            this.btnSiralaAzal.UseVisualStyleBackColor = false;
            this.btnSiralaAzal.Click += new System.EventHandler(this.btnSiralaAzal_Click);
            // 
            // ManageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1013, 654);
            this.Controls.Add(this.btnSiralaAzal);
            this.Controls.Add(this.btnSiralaArtis);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageScreen";
            this.Text = "ManageScreen";
            this.Load += new System.EventHandler(this.ManageScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader BestScore;
        private System.Windows.Forms.Button btnSiralaArtis;
        private System.Windows.Forms.Button btnSiralaAzal;
    }
}
