
namespace Kitaplik_Proje
{
    partial class Kitaplik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplik));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKitapYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKitapSayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CmbTur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKitapid = new System.Windows.Forms.TextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtKitapBul = new System.Windows.Forms.TextBox();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtKitapBasim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbFiyat = new System.Windows.Forms.ComboBox();
            this.CmbDil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(8, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Ad:";
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAd.Location = new System.Drawing.Point(76, 97);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(144, 24);
            this.TxtKitapAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar:";
            // 
            // TxtKitapYazar
            // 
            this.TxtKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapYazar.Location = new System.Drawing.Point(76, 132);
            this.TxtKitapYazar.Name = "TxtKitapYazar";
            this.TxtKitapYazar.Size = new System.Drawing.Size(144, 24);
            this.TxtKitapYazar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sayfa:";
            // 
            // TxtKitapSayfa
            // 
            this.TxtKitapSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapSayfa.Location = new System.Drawing.Point(76, 168);
            this.TxtKitapSayfa.Name = "TxtKitapSayfa";
            this.TxtKitapSayfa.Size = new System.Drawing.Size(144, 24);
            this.TxtKitapSayfa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(40, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(263, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton1.Location = new System.Drawing.Point(329, 133);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2.EL";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioButton2.Location = new System.Drawing.Point(395, 134);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 22);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SIFIR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CmbTur
            // 
            this.CmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbTur.FormattingEnabled = true;
            this.CmbTur.Items.AddRange(new object[] {
            "HİKAYE ",
            "ROMAN\t",
            "TİYATRO",
            "ŞİİR"});
            this.CmbTur.Location = new System.Drawing.Point(76, 205);
            this.CmbTur.Name = "CmbTur";
            this.CmbTur.Size = new System.Drawing.Size(144, 26);
            this.CmbTur.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(14, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap id:";
            // 
            // TxtKitapid
            // 
            this.TxtKitapid.Enabled = false;
            this.TxtKitapid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapid.Location = new System.Drawing.Point(76, 61);
            this.TxtKitapid.Name = "TxtKitapid";
            this.TxtKitapid.Size = new System.Drawing.Size(144, 24);
            this.TxtKitapid.TabIndex = 1;
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnListele.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnListele.Location = new System.Drawing.Point(502, 65);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(98, 51);
            this.BtnListele.TabIndex = 8;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnKaydet.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnKaydet.Location = new System.Drawing.Point(502, 133);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(98, 49);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSil.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnSil.Location = new System.Drawing.Point(619, 132);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(98, 49);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnGuncelle.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnGuncelle.Location = new System.Drawing.Point(619, 65);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(98, 51);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 243);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(248, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kitap Adı:";
            // 
            // TxtKitapBul
            // 
            this.TxtKitapBul.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapBul.Location = new System.Drawing.Point(323, 205);
            this.TxtKitapBul.Name = "TxtKitapBul";
            this.TxtKitapBul.Size = new System.Drawing.Size(134, 31);
            this.TxtKitapBul.TabIndex = 13;
            // 
            // BtnBul
            // 
            this.BtnBul.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnBul.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBul.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnBul.Location = new System.Drawing.Point(463, 203);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(66, 37);
            this.BtnBul.TabIndex = 14;
            this.BtnBul.Text = "BUL";
            this.BtnBul.UseVisualStyleBackColor = false;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnAra.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnAra.Location = new System.Drawing.Point(535, 203);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(66, 37);
            this.BtnAra.TabIndex = 15;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // TxtKitapBasim
            // 
            this.TxtKitapBasim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapBasim.Location = new System.Drawing.Point(323, 173);
            this.TxtKitapBasim.Name = "TxtKitapBasim";
            this.TxtKitapBasim.Size = new System.Drawing.Size(134, 24);
            this.TxtKitapBasim.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(244, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Basım Yılı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(240, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Kitap Fiyat:";
            // 
            // CmbFiyat
            // 
            this.CmbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbFiyat.FormattingEnabled = true;
            this.CmbFiyat.Items.AddRange(new object[] {
            "15 TL",
            "30 TL",
            "35 TL",
            "40 TL",
            "45 TL",
            "50 TL",
            "55 TL",
            "60 TL",
            "65 TL",
            "70 TL",
            "75 TL",
            "85 TL",
            "90 TL",
            "95 TL",
            "100 TL",
            "105 TL",
            "125 TL",
            "135 TL",
            "140 TL",
            "150 TL",
            "155 TL",
            "185 TL",
            "195 TL",
            "200 TL",
            ""});
            this.CmbFiyat.Location = new System.Drawing.Point(323, 62);
            this.CmbFiyat.Name = "CmbFiyat";
            this.CmbFiyat.Size = new System.Drawing.Size(134, 24);
            this.CmbFiyat.TabIndex = 27;
            // 
            // CmbDil
            // 
            this.CmbDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDil.FormattingEnabled = true;
            this.CmbDil.Items.AddRange(new object[] {
            "TÜRKÇE",
            "İNGİLİZCE",
            "FRANSIZCA",
            "İTALYANCA",
            "ARAPÇA",
            "OSMANLICA",
            "FARSÇA",
            "PORTEKİZCE"});
            this.CmbDil.Location = new System.Drawing.Point(323, 97);
            this.CmbDil.Name = "CmbDil";
            this.CmbDil.Size = new System.Drawing.Size(134, 24);
            this.CmbDil.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(251, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kitap Dili:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(136, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(423, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "KİTAPLIĞIMIZA HOŞGELDİNİZ";
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCikis.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCikis.Location = new System.Drawing.Point(619, 197);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(98, 49);
            this.BtnCikis.TabIndex = 31;
            this.BtnCikis.Text = "ÇIKIŞ";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // Kitaplik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1071, 518);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbDil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbFiyat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtKitapBasim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.TxtKitapBul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.CmbTur);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TxtKitapSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapid);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kitaplik";
            this.Text = "KİTAPLIK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKitapYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKitapSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox CmbTur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKitapid;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtKitapBul;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtKitapBasim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbFiyat;
        private System.Windows.Forms.ComboBox CmbDil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnCikis;
    }
}

