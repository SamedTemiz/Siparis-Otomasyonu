
namespace HepsiSurada
{
    partial class Profil
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(109)))), ((int)(((byte)(112)))));
            this.metroButton1.FlatAppearance.BorderSize = 0;
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroButton1.Location = new System.Drawing.Point(213, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(25, 25);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "X";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.UseVisualStyleBackColor = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HepsiSurada.Properties.Resources.profil;
            this.pictureBox1.Location = new System.Drawing.Point(75, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(13, 178);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Müşteri No :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(13, 207);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Kullanıcı Adı :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(13, 265);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Soyad :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(13, 236);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Ad :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(13, 293);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "E-Posta :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(13, 321);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Telefon :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(13, 349);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Adres :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txt_kulad
            // 
            this.txt_kulad.BackColor = System.Drawing.Color.White;
            this.txt_kulad.Enabled = false;
            this.txt_kulad.Location = new System.Drawing.Point(100, 207);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.ReadOnly = true;
            this.txt_kulad.Size = new System.Drawing.Size(138, 23);
            this.txt_kulad.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(100, 178);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(138, 23);
            this.txt_id.TabIndex = 7;
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.White;
            this.txt_ad.Enabled = false;
            this.txt_ad.Location = new System.Drawing.Point(100, 236);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(138, 23);
            this.txt_ad.TabIndex = 7;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.White;
            this.txt_soyad.Enabled = false;
            this.txt_soyad.Location = new System.Drawing.Point(100, 265);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(138, 23);
            this.txt_soyad.TabIndex = 7;
            // 
            // txt_eposta
            // 
            this.txt_eposta.BackColor = System.Drawing.Color.White;
            this.txt_eposta.Enabled = false;
            this.txt_eposta.Location = new System.Drawing.Point(100, 293);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.ReadOnly = true;
            this.txt_eposta.Size = new System.Drawing.Size(138, 23);
            this.txt_eposta.TabIndex = 7;
            // 
            // txt_telefon
            // 
            this.txt_telefon.BackColor = System.Drawing.Color.White;
            this.txt_telefon.Enabled = false;
            this.txt_telefon.Location = new System.Drawing.Point(100, 321);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.ReadOnly = true;
            this.txt_telefon.Size = new System.Drawing.Size(138, 23);
            this.txt_telefon.TabIndex = 7;
            // 
            // txt_adres
            // 
            this.txt_adres.BackColor = System.Drawing.Color.White;
            this.txt_adres.Enabled = false;
            this.txt_adres.Location = new System.Drawing.Point(100, 349);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.ReadOnly = true;
            this.txt_adres.Size = new System.Drawing.Size(138, 23);
            this.txt_adres.TabIndex = 7;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(250, 400);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profil";
            this.Text = "Profil";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_adres;
    }
}