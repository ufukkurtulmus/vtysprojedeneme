
namespace vtysprojedeneme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.musteriId = new System.Windows.Forms.TextBox();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stoktakiUrun = new System.Windows.Forms.TextBox();
            this.urunAdı = new System.Windows.Forms.TextBox();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yeniMusteri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.urunTarih = new System.Windows.Forms.TextBox();
            this.urunFiyat = new System.Windows.Forms.TextBox();
            this.musteriListele = new System.Windows.Forms.Button();
            this.urunEkle = new System.Windows.Forms.Button();
            this.urunListele = new System.Windows.Forms.Button();
            this.musteriBorc = new System.Windows.Forms.Button();
            this.satilanUrun = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.urunKodu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriId);
            this.groupBox1.Controls.Add(this.adSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // musteriId
            // 
            this.musteriId.Location = new System.Drawing.Point(67, 52);
            this.musteriId.Name = "musteriId";
            this.musteriId.Size = new System.Drawing.Size(100, 20);
            this.musteriId.TabIndex = 4;
            // 
            // adSoyad
            // 
            this.adSoyad.Location = new System.Drawing.Point(67, 20);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(100, 20);
            this.adSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urunKodu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.urunFiyat);
            this.groupBox2.Controls.Add(this.urunTarih);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.stoktakiUrun);
            this.groupBox2.Controls.Add(this.urunAdı);
            this.groupBox2.Controls.Add(this.barkodNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(351, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // stoktakiUrun
            // 
            this.stoktakiUrun.Location = new System.Drawing.Point(96, 75);
            this.stoktakiUrun.Name = "stoktakiUrun";
            this.stoktakiUrun.Size = new System.Drawing.Size(100, 20);
            this.stoktakiUrun.TabIndex = 8;
            // 
            // urunAdı
            // 
            this.urunAdı.Location = new System.Drawing.Point(96, 49);
            this.urunAdı.Name = "urunAdı";
            this.urunAdı.Size = new System.Drawing.Size(100, 20);
            this.urunAdı.TabIndex = 7;
            // 
            // barkodNo
            // 
            this.barkodNo.Location = new System.Drawing.Point(96, 23);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(100, 20);
            this.barkodNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stoktaki Ürünler  :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Adı              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barkod Numarası :";
            // 
            // yeniMusteri
            // 
            this.yeniMusteri.Location = new System.Drawing.Point(34, 24);
            this.yeniMusteri.Name = "yeniMusteri";
            this.yeniMusteri.Size = new System.Drawing.Size(114, 23);
            this.yeniMusteri.TabIndex = 3;
            this.yeniMusteri.Text = "Yeni Müşteri";
            this.yeniMusteri.UseVisualStyleBackColor = true;
            this.yeniMusteri.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ürün Fiyatı  :";
            // 
            // urunTarih
            // 
            this.urunTarih.Location = new System.Drawing.Point(269, 23);
            this.urunTarih.Name = "urunTarih";
            this.urunTarih.Size = new System.Drawing.Size(100, 20);
            this.urunTarih.TabIndex = 11;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Location = new System.Drawing.Point(269, 49);
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.Size = new System.Drawing.Size(100, 20);
            this.urunFiyat.TabIndex = 12;
            // 
            // musteriListele
            // 
            this.musteriListele.Location = new System.Drawing.Point(34, 71);
            this.musteriListele.Name = "musteriListele";
            this.musteriListele.Size = new System.Drawing.Size(114, 23);
            this.musteriListele.TabIndex = 4;
            this.musteriListele.Text = "Müşterileri Listele";
            this.musteriListele.UseVisualStyleBackColor = true;
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(34, 121);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(114, 23);
            this.urunEkle.TabIndex = 5;
            this.urunEkle.Text = "Ürün Ekle";
            this.urunEkle.UseVisualStyleBackColor = true;
            // 
            // urunListele
            // 
            this.urunListele.Location = new System.Drawing.Point(34, 169);
            this.urunListele.Name = "urunListele";
            this.urunListele.Size = new System.Drawing.Size(114, 23);
            this.urunListele.TabIndex = 6;
            this.urunListele.Text = "Ürünleri Listele";
            this.urunListele.UseVisualStyleBackColor = true;
            // 
            // musteriBorc
            // 
            this.musteriBorc.Location = new System.Drawing.Point(34, 223);
            this.musteriBorc.Name = "musteriBorc";
            this.musteriBorc.Size = new System.Drawing.Size(114, 23);
            this.musteriBorc.TabIndex = 7;
            this.musteriBorc.Text = "Müşteri Borçları";
            this.musteriBorc.UseVisualStyleBackColor = true;
            // 
            // satilanUrun
            // 
            this.satilanUrun.Location = new System.Drawing.Point(34, 276);
            this.satilanUrun.Name = "satilanUrun";
            this.satilanUrun.Size = new System.Drawing.Size(114, 23);
            this.satilanUrun.TabIndex = 8;
            this.satilanUrun.Text = "Satılan Ürünler";
            this.satilanUrun.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ürün Kodu  :";
            // 
            // urunKodu
            // 
            this.urunKodu.Location = new System.Drawing.Point(269, 75);
            this.urunKodu.Name = "urunKodu";
            this.urunKodu.Size = new System.Drawing.Size(100, 20);
            this.urunKodu.TabIndex = 14;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(718, 218);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSatis.Location = new System.Drawing.Point(718, 276);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(70, 23);
            this.btnSatis.TabIndex = 10;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(718, 247);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.satilanUrun);
            this.Controls.Add(this.musteriBorc);
            this.Controls.Add(this.urunListele);
            this.Controls.Add(this.urunEkle);
            this.Controls.Add(this.musteriListele);
            this.Controls.Add(this.yeniMusteri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox musteriId;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stoktakiUrun;
        private System.Windows.Forms.TextBox urunAdı;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button yeniMusteri;
        private System.Windows.Forms.TextBox urunKodu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox urunFiyat;
        private System.Windows.Forms.TextBox urunTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button musteriListele;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.Button urunListele;
        private System.Windows.Forms.Button musteriBorc;
        private System.Windows.Forms.Button satilanUrun;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnSil;
    }
}

