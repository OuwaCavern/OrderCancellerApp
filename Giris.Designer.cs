using System.Windows.Forms;

namespace OrderCancellerApp
{
    partial class Giris
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.girisBilgisi = new System.Windows.Forms.Label();
            this.sifreGirisi = new System.Windows.Forms.TextBox();
            this.girisButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisBilgisi
            // 
            this.girisBilgisi.AutoSize = true;
            this.girisBilgisi.Location = new System.Drawing.Point(61, 40);
            this.girisBilgisi.Name = "girisBilgisi";
            this.girisBilgisi.Size = new System.Drawing.Size(95, 13);
            this.girisBilgisi.TabIndex = 0;
            this.girisBilgisi.Text = "Lütfen şifreyi giriniz";
            // 
            // sifreGirisi
            // 
            this.sifreGirisi.Location = new System.Drawing.Point(56, 56);
            this.sifreGirisi.Name = "sifreGirisi";
            this.sifreGirisi.PasswordChar = '*';
            this.sifreGirisi.Size = new System.Drawing.Size(109, 20);
            this.sifreGirisi.TabIndex = 1;
            this.sifreGirisi.UseSystemPasswordChar = true;
            this.sifreGirisi.TextChanged += new System.EventHandler(this.sifreGirisi_TextChanged);
            // 
            // girisButonu
            // 
            this.girisButonu.Location = new System.Drawing.Point(75, 82);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(75, 23);
            this.girisButonu.TabIndex = 2;
            this.girisButonu.Text = "Giriş";
            this.girisButonu.UseVisualStyleBackColor = true;
            this.girisButonu.Click += new System.EventHandler(this.girisButonu_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.girisButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 158);
            this.Controls.Add(this.girisButonu);
            this.Controls.Add(this.sifreGirisi);
            this.Controls.Add(this.girisBilgisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girisBilgisi;
        private System.Windows.Forms.Button girisButonu;
        protected System.Windows.Forms.TextBox sifreGirisi;
    }
}