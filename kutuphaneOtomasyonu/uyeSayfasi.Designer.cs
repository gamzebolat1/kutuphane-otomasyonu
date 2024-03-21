namespace kutuphaneOtomasyonu
{
    partial class uyeSayfasi
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
            this.txt_usAra = new System.Windows.Forms.TextBox();
            this.btn_usAra = new System.Windows.Forms.Button();
            this.btn_usYenile = new System.Windows.Forms.Button();
            this.btn_usCikisYap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usAra
            // 
            this.txt_usAra.Location = new System.Drawing.Point(100, 17);
            this.txt_usAra.Name = "txt_usAra";
            this.txt_usAra.Size = new System.Drawing.Size(154, 26);
            this.txt_usAra.TabIndex = 0;
            // 
            // btn_usAra
            // 
            this.btn_usAra.Location = new System.Drawing.Point(19, 12);
            this.btn_usAra.Name = "btn_usAra";
            this.btn_usAra.Size = new System.Drawing.Size(75, 36);
            this.btn_usAra.TabIndex = 1;
            this.btn_usAra.Text = "Ara";
            this.btn_usAra.UseVisualStyleBackColor = true;
            this.btn_usAra.Click += new System.EventHandler(this.btn_usAra_Click);
            // 
            // btn_usYenile
            // 
            this.btn_usYenile.Location = new System.Drawing.Point(260, 12);
            this.btn_usYenile.Name = "btn_usYenile";
            this.btn_usYenile.Size = new System.Drawing.Size(75, 36);
            this.btn_usYenile.TabIndex = 1;
            this.btn_usYenile.Text = "Yenile";
            this.btn_usYenile.UseVisualStyleBackColor = true;
            this.btn_usYenile.Click += new System.EventHandler(this.btn_usYenile_Click);
            // 
            // btn_usCikisYap
            // 
            this.btn_usCikisYap.Location = new System.Drawing.Point(693, 390);
            this.btn_usCikisYap.Name = "btn_usCikisYap";
            this.btn_usCikisYap.Size = new System.Drawing.Size(95, 39);
            this.btn_usCikisYap.TabIndex = 3;
            this.btn_usCikisYap.Text = "Çıkış Yap";
            this.btn_usCikisYap.UseVisualStyleBackColor = true;
            this.btn_usCikisYap.Click += new System.EventHandler(this.btn_usCikisYap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(143)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapIsim,
            this.kitapYazar,
            this.kitapDili,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfaSayisi,
            this.basimYili});
            this.dataGridView1.Location = new System.Drawing.Point(1, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 289);
            this.dataGridView1.TabIndex = 4;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KitapID";
            this.kitapid.MinimumWidth = 8;
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 75;
            // 
            // kitapIsim
            // 
            this.kitapIsim.HeaderText = "Kitap İsmi";
            this.kitapIsim.MinimumWidth = 8;
            this.kitapIsim.Name = "kitapIsim";
            this.kitapIsim.Width = 75;
            // 
            // kitapYazar
            // 
            this.kitapYazar.HeaderText = "Kitap Yazarı";
            this.kitapYazar.MinimumWidth = 8;
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Width = 75;
            // 
            // kitapDili
            // 
            this.kitapDili.HeaderText = "Kitap Dili";
            this.kitapDili.MinimumWidth = 8;
            this.kitapDili.Name = "kitapDili";
            this.kitapDili.Width = 75;
            // 
            // yayinevi
            // 
            this.yayinevi.FillWeight = 150F;
            this.yayinevi.HeaderText = "Yayınevi";
            this.yayinevi.MinimumWidth = 8;
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Width = 150;
            // 
            // tur
            // 
            this.tur.HeaderText = "Tür";
            this.tur.MinimumWidth = 8;
            this.tur.Name = "tur";
            this.tur.Width = 75;
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.MinimumWidth = 8;
            this.adet.Name = "adet";
            this.adet.Width = 75;
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.HeaderText = "Sayfa Sayısı";
            this.sayfaSayisi.MinimumWidth = 8;
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.Width = 75;
            // 
            // basimYili
            // 
            this.basimYili.HeaderText = "Basım Yılı";
            this.basimYili.MinimumWidth = 8;
            this.basimYili.Name = "basimYili";
            this.basimYili.Width = 75;
            // 
            // uyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_usCikisYap);
            this.Controls.Add(this.btn_usYenile);
            this.Controls.Add(this.btn_usAra);
            this.Controls.Add(this.txt_usAra);
            this.Name = "uyeSayfasi";
            this.Text = "uyeSayfasi";
            this.Load += new System.EventHandler(this.uyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usAra;
        private System.Windows.Forms.Button btn_usAra;
        private System.Windows.Forms.Button btn_usYenile;
        private System.Windows.Forms.Button btn_usCikisYap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimYili;
    }
}