namespace OrderCancellerApp
{
    partial class Uygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uygulama));
            this.YemekPOS = new System.Windows.Forms.Label();
            this.NO = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.siparisNOGirdisi = new System.Windows.Forms.TextBox();
            this.iptalButonu = new System.Windows.Forms.Button();
            this.teslimButonu = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.siparisListesi = new System.Windows.Forms.DataGridView();
            this.zamanBildirgesi = new System.Windows.Forms.Label();
            this.siparisGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // YemekPOS
            // 
            this.YemekPOS.AutoSize = true;
            this.YemekPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YemekPOS.Location = new System.Drawing.Point(17, 9);
            this.YemekPOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YemekPOS.Name = "YemekPOS";
            this.YemekPOS.Size = new System.Drawing.Size(294, 18);
            this.YemekPOS.TabIndex = 0;
            this.YemekPOS.Text = "YemekPOS Sıpariş İptal/Teslim Uygulaması";
            this.YemekPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NO.Location = new System.Drawing.Point(111, 58);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(84, 18);
            this.NO.TabIndex = 1;
            this.NO.Text = "Sipariş NO:";
            // 
            // siparisNOGirdisi
            // 
            this.siparisNOGirdisi.Location = new System.Drawing.Point(87, 79);
            this.siparisNOGirdisi.Name = "siparisNOGirdisi";
            this.siparisNOGirdisi.Size = new System.Drawing.Size(130, 20);
            this.siparisNOGirdisi.TabIndex = 2;
            // 
            // iptalButonu
            // 
            this.iptalButonu.Location = new System.Drawing.Point(12, 115);
            this.iptalButonu.Name = "iptalButonu";
            this.iptalButonu.Size = new System.Drawing.Size(91, 28);
            this.iptalButonu.TabIndex = 3;
            this.iptalButonu.Text = "Iptal Et";
            this.iptalButonu.UseVisualStyleBackColor = true;
            // 
            // teslimButonu
            // 
            this.teslimButonu.Location = new System.Drawing.Point(205, 115);
            this.teslimButonu.Name = "teslimButonu";
            this.teslimButonu.Size = new System.Drawing.Size(91, 28);
            this.teslimButonu.TabIndex = 4;
            this.teslimButonu.Text = "Teslim Edildi";
            this.teslimButonu.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // siparisListesi
            // 
            this.siparisListesi.AllowUserToAddRows = false;
            this.siparisListesi.AllowUserToDeleteRows = false;
            this.siparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisListesi.Location = new System.Drawing.Point(12, 201);
            this.siparisListesi.Name = "siparisListesi";
            this.siparisListesi.ReadOnly = true;
            this.siparisListesi.Size = new System.Drawing.Size(284, 150);
            this.siparisListesi.TabIndex = 5;
            // 
            // zamanBildirgesi
            // 
            this.zamanBildirgesi.AutoSize = true;
            this.zamanBildirgesi.Location = new System.Drawing.Point(65, 185);
            this.zamanBildirgesi.Name = "zamanBildirgesi";
            this.zamanBildirgesi.Size = new System.Drawing.Size(173, 13);
            this.zamanBildirgesi.TabIndex = 6;
            this.zamanBildirgesi.Text = "3 Saatten Fazla Bekleyen Siparişler";
            // 
            // siparisGoster
            // 
            this.siparisGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisGoster.Location = new System.Drawing.Point(87, 159);
            this.siparisGoster.Name = "siparisGoster";
            this.siparisGoster.Size = new System.Drawing.Size(130, 23);
            this.siparisGoster.TabIndex = 7;
            this.siparisGoster.Text = "Siparişleri Göster";
            this.siparisGoster.UseVisualStyleBackColor = true;
            this.siparisGoster.Click += new System.EventHandler(this.siparisGoster_Click);
            // 
            // Uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 352);
            this.Controls.Add(this.siparisGoster);
            this.Controls.Add(this.zamanBildirgesi);
            this.Controls.Add(this.siparisListesi);
            this.Controls.Add(this.teslimButonu);
            this.Controls.Add(this.iptalButonu);
            this.Controls.Add(this.siparisNOGirdisi);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.YemekPOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Uygulama";
            this.Text = "YemekPOS Sıpariş İptal/Teslim Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YemekPOS;
        private System.Windows.Forms.Label NO;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox siparisNOGirdisi;
        private System.Windows.Forms.Button iptalButonu;
        private System.Windows.Forms.Button teslimButonu;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView siparisListesi;
        private System.Windows.Forms.Label zamanBildirgesi;
        private System.Windows.Forms.Button siparisGoster;
    }
}

