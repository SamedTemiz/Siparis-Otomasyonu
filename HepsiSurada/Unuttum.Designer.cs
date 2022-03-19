
namespace HepsiSurada
{
    partial class Unuttum
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HepsiSurada.Properties.Resources.profil;
            this.pictureBox1.Location = new System.Drawing.Point(100, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "E-Posta :";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(82, 138);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(190, 23);
            this.txt_eposta.TabIndex = 8;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Tan;
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(8, 167);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(264, 40);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "ÖĞREN";
            this.metroButton1.UseCompatibleTextRendering = true;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Unuttum";
            this.Text = "Unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eposta;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}