namespace ELEKTRIK
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTuketim = new System.Windows.Forms.TextBox();
            this.btnTuketimKaydet = new System.Windows.Forms.Button();
            this.btnTuketimYeni = new System.Windows.Forms.Button();
            this.btnTuketimHesapla = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgvAbone = new System.Windows.Forms.DataGridView();
            this.dgvTuketim = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuketim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(87, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(87, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(87, 125);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(156, 20);
            this.txtTC.TabIndex = 4;
            this.txtTC.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC Kimlik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "dgvAbone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(822, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "dgvTuketim";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(87, 282);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(67, 23);
            this.btnYeni.TabIndex = 10;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(176, 282);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(67, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sayac Numara:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sayac Seri:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sayac Marka:";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(87, 242);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(156, 20);
            this.txtNumara.TabIndex = 14;
            this.txtNumara.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(87, 200);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(156, 20);
            this.txtSeri.TabIndex = 13;
            this.txtSeri.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(87, 161);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(156, 20);
            this.txtMarka.TabIndex = 12;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Yeni Tüketim:";
            // 
            // txtTuketim
            // 
            this.txtTuketim.Location = new System.Drawing.Point(87, 383);
            this.txtTuketim.Name = "txtTuketim";
            this.txtTuketim.Size = new System.Drawing.Size(156, 20);
            this.txtTuketim.TabIndex = 20;
            this.txtTuketim.TextChanged += new System.EventHandler(this.txtTuketim_TextChanged);
            // 
            // btnTuketimKaydet
            // 
            this.btnTuketimKaydet.Location = new System.Drawing.Point(176, 423);
            this.btnTuketimKaydet.Name = "btnTuketimKaydet";
            this.btnTuketimKaydet.Size = new System.Drawing.Size(67, 23);
            this.btnTuketimKaydet.TabIndex = 19;
            this.btnTuketimKaydet.Text = "Kaydet";
            this.btnTuketimKaydet.UseVisualStyleBackColor = true;
            this.btnTuketimKaydet.Click += new System.EventHandler(this.btnTuketimKaydet_Click);
            // 
            // btnTuketimYeni
            // 
            this.btnTuketimYeni.Location = new System.Drawing.Point(87, 423);
            this.btnTuketimYeni.Name = "btnTuketimYeni";
            this.btnTuketimYeni.Size = new System.Drawing.Size(67, 23);
            this.btnTuketimYeni.TabIndex = 18;
            this.btnTuketimYeni.Text = "Yeni";
            this.btnTuketimYeni.UseVisualStyleBackColor = true;
            this.btnTuketimYeni.Click += new System.EventHandler(this.btnTuketimYeni_Click);
            // 
            // btnTuketimHesapla
            // 
            this.btnTuketimHesapla.Location = new System.Drawing.Point(1092, 53);
            this.btnTuketimHesapla.Name = "btnTuketimHesapla";
            this.btnTuketimHesapla.Size = new System.Drawing.Size(162, 23);
            this.btnTuketimHesapla.TabIndex = 22;
            this.btnTuketimHesapla.Text = "Elektrik Tuketimi Hesapla";
            this.btnTuketimHesapla.UseVisualStyleBackColor = true;
            this.btnTuketimHesapla.Click += new System.EventHandler(this.btnTuketimHesapla_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(597, 53);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(156, 20);
            this.txtAra.TabIndex = 24;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dgvAbone
            // 
            this.dgvAbone.AllowUserToAddRows = false;
            this.dgvAbone.AllowUserToDeleteRows = false;
            this.dgvAbone.AllowUserToResizeRows = false;
            this.dgvAbone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAbone.Location = new System.Drawing.Point(258, 86);
            this.dgvAbone.MultiSelect = false;
            this.dgvAbone.Name = "dgvAbone";
            this.dgvAbone.ReadOnly = true;
            this.dgvAbone.RowHeadersVisible = false;
            this.dgvAbone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbone.Size = new System.Drawing.Size(495, 391);
            this.dgvAbone.TabIndex = 25;
            this.dgvAbone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbone_CellClick);
            // 
            // dgvTuketim
            // 
            this.dgvTuketim.AllowUserToAddRows = false;
            this.dgvTuketim.AllowUserToDeleteRows = false;
            this.dgvTuketim.AllowUserToResizeRows = false;
            this.dgvTuketim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuketim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuketim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTuketim.Location = new System.Drawing.Point(759, 86);
            this.dgvTuketim.MultiSelect = false;
            this.dgvTuketim.Name = "dgvTuketim";
            this.dgvTuketim.ReadOnly = true;
            this.dgvTuketim.RowHeadersVisible = false;
            this.dgvTuketim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuketim.Size = new System.Drawing.Size(495, 391);
            this.dgvTuketim.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "TC Kimlik, Ad, Soyad Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 510);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvTuketim);
            this.Controls.Add(this.dgvAbone);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnTuketimHesapla);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTuketim);
            this.Controls.Add(this.btnTuketimKaydet);
            this.Controls.Add(this.btnTuketimYeni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSeri);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuketim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTuketim;
        private System.Windows.Forms.Button btnTuketimKaydet;
        private System.Windows.Forms.Button btnTuketimYeni;
        private System.Windows.Forms.Button btnTuketimHesapla;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgvAbone;
        private System.Windows.Forms.DataGridView dgvTuketim;
        private System.Windows.Forms.Label label10;
    }
}

