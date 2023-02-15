namespace OOP2LAB_PROJE
{
    partial class Settings
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelSeçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Boy = new System.Windows.Forms.ToolStripTextBox();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_En = new System.Windows.Forms.ToolStripTextBox();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üçgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKaydet.Location = new System.Drawing.Point(593, 381);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(123, 59);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Save";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyLevelToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.coloursToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // difficultyLevelToolStripMenuItem
            // 
            this.difficultyLevelToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.difficultyLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolayToolStripMenuItem,
            this.ortaToolStripMenuItem,
            this.zorToolStripMenuItem,
            this.özelSeçeneklerToolStripMenuItem});
            this.difficultyLevelToolStripMenuItem.Name = "difficultyLevelToolStripMenuItem";
            this.difficultyLevelToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.difficultyLevelToolStripMenuItem.Text = "Difficulty Level";
            // 
            // kolayToolStripMenuItem
            // 
            this.kolayToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.kolayToolStripMenuItem.CheckOnClick = true;
            this.kolayToolStripMenuItem.Name = "kolayToolStripMenuItem";
            this.kolayToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.kolayToolStripMenuItem.Text = "Easy";
            this.kolayToolStripMenuItem.Click += new System.EventHandler(this.kolayToolStripMenuItem_Click);
            // 
            // ortaToolStripMenuItem
            // 
            this.ortaToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.ortaToolStripMenuItem.CheckOnClick = true;
            this.ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            this.ortaToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.ortaToolStripMenuItem.Text = "Normal";
            this.ortaToolStripMenuItem.Click += new System.EventHandler(this.ortaToolStripMenuItem_Click);
            // 
            // zorToolStripMenuItem
            // 
            this.zorToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.zorToolStripMenuItem.CheckOnClick = true;
            this.zorToolStripMenuItem.Name = "zorToolStripMenuItem";
            this.zorToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.zorToolStripMenuItem.Text = "Hard";
            this.zorToolStripMenuItem.Click += new System.EventHandler(this.zorToolStripMenuItem_Click);
            // 
            // özelSeçeneklerToolStripMenuItem
            // 
            this.özelSeçeneklerToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.özelSeçeneklerToolStripMenuItem.CheckOnClick = true;
            this.özelSeçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsToolStripMenuItem,
            this.columnsToolStripMenuItem});
            this.özelSeçeneklerToolStripMenuItem.Name = "özelSeçeneklerToolStripMenuItem";
            this.özelSeçeneklerToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.özelSeçeneklerToolStripMenuItem.Text = "Custom Settings";
            this.özelSeçeneklerToolStripMenuItem.Click += new System.EventHandler(this.özelSeçeneklerToolStripMenuItem_Click);
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_Boy});
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.rowsToolStripMenuItem.Text = "Rows";
            // 
            // txt_Boy
            // 
            this.txt_Boy.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Boy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Boy.Name = "txt_Boy";
            this.txt_Boy.Size = new System.Drawing.Size(100, 27);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_En});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // txt_En
            // 
            this.txt_En.BackColor = System.Drawing.SystemColors.Info;
            this.txt_En.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_En.Name = "txt_En";
            this.txt_En.Size = new System.Drawing.Size(100, 27);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kareToolStripMenuItem,
            this.üçgenToolStripMenuItem,
            this.daireToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // kareToolStripMenuItem
            // 
            this.kareToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.kareToolStripMenuItem.CheckOnClick = true;
            this.kareToolStripMenuItem.Name = "kareToolStripMenuItem";
            this.kareToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.kareToolStripMenuItem.Text = "Square";
            // 
            // üçgenToolStripMenuItem
            // 
            this.üçgenToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.üçgenToolStripMenuItem.CheckOnClick = true;
            this.üçgenToolStripMenuItem.Name = "üçgenToolStripMenuItem";
            this.üçgenToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.üçgenToolStripMenuItem.Text = "Triangle";
            // 
            // daireToolStripMenuItem
            // 
            this.daireToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.daireToolStripMenuItem.CheckOnClick = true;
            this.daireToolStripMenuItem.Name = "daireToolStripMenuItem";
            this.daireToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.daireToolStripMenuItem.Text = "Round";
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.coloursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.redToolStripMenuItem});
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.coloursToolStripMenuItem.Text = "Colours";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.greenToolStripMenuItem.CheckOnClick = true;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.yellowToolStripMenuItem.CheckOnClick = true;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.CheckOnClick = true;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(742, 454);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelSeçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_Boy;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_En;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üçgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
    }
}

