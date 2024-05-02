using System.Windows.Forms;

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
            this.siparisNoGirdiBilgi = new System.Windows.Forms.Label();
            this.sonXGun = new System.Windows.Forms.NumericUpDown();
            this.sonXGunLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonXGun)).BeginInit();
            this.SuspendLayout();
            // 
            // YemekPOS
            // 
            this.YemekPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YemekPOS.AutoSize = true;
            this.YemekPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YemekPOS.Location = new System.Drawing.Point(22, 9);
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
            this.NO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NO.Location = new System.Drawing.Point(132, 68);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(84, 18);
            this.NO.TabIndex = 1;
            this.NO.Text = "Sipariş NO:";
            // 
            // siparisNOGirdisi
            // 
            this.siparisNOGirdisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisNOGirdisi.Location = new System.Drawing.Point(12, 89);
            this.siparisNOGirdisi.Name = "siparisNOGirdisi";
            this.siparisNOGirdisi.Size = new System.Drawing.Size(313, 20);
            this.siparisNOGirdisi.TabIndex = 2;
            this.siparisNOGirdisi.TextChanged += new System.EventHandler(this.siparisNOGirdisi_TextChanged);
            // 
            // iptalButonu
            // 
            this.iptalButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iptalButonu.Location = new System.Drawing.Point(12, 124);
            this.iptalButonu.Name = "iptalButonu";
            this.iptalButonu.Size = new System.Drawing.Size(91, 28);
            this.iptalButonu.TabIndex = 3;
            this.iptalButonu.Text = "Iptal Et";
            this.iptalButonu.UseVisualStyleBackColor = true;
            this.iptalButonu.Click += new System.EventHandler(this.iptalButonu_Click);
            // 
            // teslimButonu
            // 
            this.teslimButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.teslimButonu.Location = new System.Drawing.Point(234, 124);
            this.teslimButonu.Name = "teslimButonu";
            this.teslimButonu.Size = new System.Drawing.Size(91, 28);
            this.teslimButonu.TabIndex = 4;
            this.teslimButonu.Text = "Teslim Edildi";
            this.teslimButonu.UseVisualStyleBackColor = true;
            this.teslimButonu.Click += new System.EventHandler(this.teslimButonu_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // siparisListesi
            // 
            this.siparisListesi.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.siparisListesi.AllowUserToAddRows = false;
            this.siparisListesi.AllowUserToDeleteRows = false;
            this.siparisListesi.AllowUserToOrderColumns = true;
            this.siparisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.siparisListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.siparisListesi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.siparisListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.siparisListesi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siparisListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siparisListesi.Location = new System.Drawing.Point(0, 202);
            this.siparisListesi.Name = "siparisListesi";
            this.siparisListesi.ReadOnly = true;
            this.siparisListesi.RowHeadersVisible = false;
            this.siparisListesi.RowHeadersWidth = 4;
            this.siparisListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.siparisListesi.Size = new System.Drawing.Size(337, 150);
            this.siparisListesi.TabIndex = 5;
            // 
            // zamanBildirgesi
            // 
            this.zamanBildirgesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zamanBildirgesi.AutoSize = true;
            this.zamanBildirgesi.Location = new System.Drawing.Point(132, 185);
            this.zamanBildirgesi.Name = "zamanBildirgesi";
            this.zamanBildirgesi.Size = new System.Drawing.Size(73, 13);
            this.zamanBildirgesi.TabIndex = 6;
            this.zamanBildirgesi.Text = "Açık Siparişler";
            // 
            // siparisGoster
            // 
            this.siparisGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisGoster.Location = new System.Drawing.Point(103, 159);
            this.siparisGoster.Name = "siparisGoster";
            this.siparisGoster.Size = new System.Drawing.Size(130, 23);
            this.siparisGoster.TabIndex = 7;
            this.siparisGoster.Text = "Siparişleri Göster";
            this.siparisGoster.UseVisualStyleBackColor = true;
            this.siparisGoster.Click += new System.EventHandler(this.siparisGoster_Click);
            // 
            // siparisNoGirdiBilgi
            // 
            this.siparisNoGirdiBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisNoGirdiBilgi.AutoSize = true;
            this.siparisNoGirdiBilgi.Location = new System.Drawing.Point(68, 42);
            this.siparisNoGirdiBilgi.Name = "siparisNoGirdiBilgi";
            this.siparisNoGirdiBilgi.Size = new System.Drawing.Size(211, 26);
            this.siparisNoGirdiBilgi.TabIndex = 8;
            this.siparisNoGirdiBilgi.Text = "         Birden çok SiparişNO girmek için\n\r SiparişNOların aralarına virgül koyab" +
    "ilirsiniz.";
            // 
            // sonXGun
            // 
            this.sonXGun.Location = new System.Drawing.Point(25, 176);
            this.sonXGun.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sonXGun.Name = "sonXGun";
            this.sonXGun.Size = new System.Drawing.Size(50, 20);
            this.sonXGun.TabIndex = 9;
            this.sonXGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sonXGun.ValueChanged += new System.EventHandler(this.sonXGun_ValueChanged);
            // 
            // sonXGunLabel
            // 
            this.sonXGunLabel.AutoSize = true;
            this.sonXGunLabel.Location = new System.Drawing.Point(22, 159);
            this.sonXGunLabel.Name = "sonXGunLabel";
            this.sonXGunLabel.Size = new System.Drawing.Size(57, 13);
            this.sonXGunLabel.TabIndex = 10;
            this.sonXGunLabel.Text = "Son X gün";
            // 
            // Uygulama
            // 
            this.AcceptButton = this.siparisGoster;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 352);
            this.Controls.Add(this.sonXGunLabel);
            this.Controls.Add(this.sonXGun);
            this.Controls.Add(this.siparisNoGirdiBilgi);
            this.Controls.Add(this.siparisGoster);
            this.Controls.Add(this.zamanBildirgesi);
            this.Controls.Add(this.siparisListesi);
            this.Controls.Add(this.teslimButonu);
            this.Controls.Add(this.iptalButonu);
            this.Controls.Add(this.siparisNOGirdisi);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.YemekPOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Uygulama";
            this.Text = "YemekPOS Sıpariş İptal/Teslim Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonXGun)).EndInit();
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
        private System.Windows.Forms.Label siparisNoGirdiBilgi;
        private NumericUpDown sonXGun;
        private Label sonXGunLabel;
    }
}

