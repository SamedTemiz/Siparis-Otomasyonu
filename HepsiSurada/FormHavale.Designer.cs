
namespace HepsiSurada
{
    partial class FormHavale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHavale));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.CVV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblbankNo = new System.Windows.Forms.Label();
            this.lblbankTarih = new System.Windows.Forms.Label();
            this.lblbankAdSoyad = new System.Windows.Forms.Label();
            this.btnHavale = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_odeme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(373, 452);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart Üzerindeki İsim";
            // 
            // CVV
            // 
            this.CVV.AutoSize = true;
            this.CVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CVV.Location = new System.Drawing.Point(248, 280);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(35, 17);
            this.CVV.TabIndex = 3;
            this.CVV.Text = "CVV";
            this.CVV.Click += new System.EventHandler(this.CVV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Son Kul. Tarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kart Numarası";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(48, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 28);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(48, 137);
            this.maskedTextBox1.Mask = "0000 0000 0000 0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(238, 28);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Gold;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(373, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(373, 452);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox4.Location = new System.Drawing.Point(250, 313);
            this.maskedTextBox4.Mask = "000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(36, 26);
            this.maskedTextBox4.TabIndex = 15;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(606, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblbankNo
            // 
            this.lblbankNo.AutoSize = true;
            this.lblbankNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbankNo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbankNo.Location = new System.Drawing.Point(480, 232);
            this.lblbankNo.Name = "lblbankNo";
            this.lblbankNo.Size = new System.Drawing.Size(0, 25);
            this.lblbankNo.TabIndex = 18;
            this.lblbankNo.Click += new System.EventHandler(this.lblbankNo_Click);
            // 
            // lblbankTarih
            // 
            this.lblbankTarih.AutoSize = true;
            this.lblbankTarih.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbankTarih.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbankTarih.Location = new System.Drawing.Point(424, 334);
            this.lblbankTarih.Name = "lblbankTarih";
            this.lblbankTarih.Size = new System.Drawing.Size(0, 20);
            this.lblbankTarih.TabIndex = 19;
            // 
            // lblbankAdSoyad
            // 
            this.lblbankAdSoyad.AutoSize = true;
            this.lblbankAdSoyad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbankAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbankAdSoyad.Location = new System.Drawing.Point(422, 290);
            this.lblbankAdSoyad.Name = "lblbankAdSoyad";
            this.lblbankAdSoyad.Size = new System.Drawing.Size(0, 21);
            this.lblbankAdSoyad.TabIndex = 20;
            // 
            // btnHavale
            // 
            this.btnHavale.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHavale.Location = new System.Drawing.Point(46, 382);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(138, 35);
            this.btnHavale.TabIndex = 22;
            this.btnHavale.Text = "Ödeme Yap";
            this.btnHavale.UseVisualStyleBackColor = false;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "ÖDEMEYİ TAMAMLA";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(49, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 25);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29"});
            this.comboBox2.Location = new System.Drawing.Point(122, 317);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(51, 25);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(102, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "/";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_odeme);
            this.panel1.Location = new System.Drawing.Point(399, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 61);
            this.panel1.TabIndex = 47;
            // 
            // lbl_odeme
            // 
            this.lbl_odeme.AutoSize = true;
            this.lbl_odeme.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_odeme.Location = new System.Drawing.Point(121, 12);
            this.lbl_odeme.Name = "lbl_odeme";
            this.lbl_odeme.Size = new System.Drawing.Size(53, 37);
            this.lbl_odeme.TabIndex = 0;
            this.lbl_odeme.Text = "***";
            // 
            // FormHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.lblbankAdSoyad);
            this.Controls.Add(this.lblbankTarih);
            this.Controls.Add(this.lblbankNo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "FormHavale";
            this.Text = "Havale";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CVV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblbankNo;
        private System.Windows.Forms.Label lblbankTarih;
        private System.Windows.Forms.Label lblbankAdSoyad;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_odeme;
    }
}