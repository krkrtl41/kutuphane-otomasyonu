namespace kütüphane_otomasyonu
{
    partial class KullanıcıUyeOlma
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
            ad_lbl = new Label();
            soyad_lbl = new Label();
            dogum_lbl = new Label();
            cinsiyet_lbl = new Label();
            kullaniciad_lbl = new Label();
            parola_lbl = new Label();
            parolatekrar_lbl = new Label();
            babasoniki_lbl = new Label();
            ad = new TextBox();
            soyad = new TextBox();
            dogum_tarihi = new DateTimePicker();
            panel1 = new Panel();
            kadin = new RadioButton();
            erkek = new RadioButton();
            tel_no = new MaskedTextBox();
            telno_lbl = new Label();
            baba_soniki = new MaskedTextBox();
            parola_tekrar = new TextBox();
            parola = new TextBox();
            kullanici_ad = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            kaydet = new Button();
            ilerleme_cubugu = new ProgressBar();
            label7 = new Label();
            sifre_durumu = new Label();
            parola_goster = new Button();
            parolatekrar_goster = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ad_lbl
            // 
            ad_lbl.AutoSize = true;
            ad_lbl.Location = new Point(27, 81);
            ad_lbl.Name = "ad_lbl";
            ad_lbl.Size = new Size(28, 20);
            ad_lbl.TabIndex = 0;
            ad_lbl.Text = "Ad";
            // 
            // soyad_lbl
            // 
            soyad_lbl.AutoSize = true;
            soyad_lbl.Location = new Point(27, 126);
            soyad_lbl.Name = "soyad_lbl";
            soyad_lbl.Size = new Size(50, 20);
            soyad_lbl.TabIndex = 0;
            soyad_lbl.Text = "Soyad";
            // 
            // dogum_lbl
            // 
            dogum_lbl.AutoSize = true;
            dogum_lbl.Location = new Point(27, 171);
            dogum_lbl.Name = "dogum_lbl";
            dogum_lbl.Size = new Size(98, 20);
            dogum_lbl.TabIndex = 0;
            dogum_lbl.Text = "Doğum Tarihi";
            // 
            // cinsiyet_lbl
            // 
            cinsiyet_lbl.AutoSize = true;
            cinsiyet_lbl.Location = new Point(27, 216);
            cinsiyet_lbl.Name = "cinsiyet_lbl";
            cinsiyet_lbl.Size = new Size(60, 20);
            cinsiyet_lbl.TabIndex = 0;
            cinsiyet_lbl.Text = "Cinsiyet";
            // 
            // kullaniciad_lbl
            // 
            kullaniciad_lbl.AutoSize = true;
            kullaniciad_lbl.Location = new Point(571, 77);
            kullaniciad_lbl.Name = "kullaniciad_lbl";
            kullaniciad_lbl.Size = new Size(88, 20);
            kullaniciad_lbl.TabIndex = 0;
            kullaniciad_lbl.Text = "Kullanıcı Ad";
            // 
            // parola_lbl
            // 
            parola_lbl.AutoSize = true;
            parola_lbl.Location = new Point(571, 126);
            parola_lbl.Name = "parola_lbl";
            parola_lbl.Size = new Size(50, 20);
            parola_lbl.TabIndex = 0;
            parola_lbl.Text = "Parola";
            // 
            // parolatekrar_lbl
            // 
            parolatekrar_lbl.AutoSize = true;
            parolatekrar_lbl.Location = new Point(571, 171);
            parolatekrar_lbl.Name = "parolatekrar_lbl";
            parolatekrar_lbl.Size = new Size(94, 20);
            parolatekrar_lbl.TabIndex = 0;
            parolatekrar_lbl.Text = "Parola Tekrar";
            // 
            // babasoniki_lbl
            // 
            babasoniki_lbl.AutoSize = true;
            babasoniki_lbl.Location = new Point(571, 222);
            babasoniki_lbl.Name = "babasoniki_lbl";
            babasoniki_lbl.Size = new Size(148, 20);
            babasoniki_lbl.TabIndex = 0;
            babasoniki_lbl.Text = "Babanın Son İki Harfi";
            // 
            // ad
            // 
            ad.Location = new Point(187, 74);
            ad.Name = "ad";
            ad.Size = new Size(250, 27);
            ad.TabIndex = 1;
            ad.KeyPress += ad_KeyPress;
            // 
            // soyad
            // 
            soyad.Location = new Point(187, 119);
            soyad.Name = "soyad";
            soyad.Size = new Size(250, 27);
            soyad.TabIndex = 2;
            soyad.KeyPress += ad_KeyPress;
            // 
            // dogum_tarihi
            // 
            dogum_tarihi.Format = DateTimePickerFormat.Short;
            dogum_tarihi.Location = new Point(187, 164);
            dogum_tarihi.Name = "dogum_tarihi";
            dogum_tarihi.Size = new Size(250, 27);
            dogum_tarihi.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(kadin);
            panel1.Controls.Add(erkek);
            panel1.Location = new Point(187, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 30);
            panel1.TabIndex = 4;
            // 
            // kadin
            // 
            kadin.AutoSize = true;
            kadin.Location = new Point(149, 4);
            kadin.Name = "kadin";
            kadin.Size = new Size(68, 24);
            kadin.TabIndex = 0;
            kadin.TabStop = true;
            kadin.Text = "Kadın";
            kadin.UseVisualStyleBackColor = true;
            // 
            // erkek
            // 
            erkek.AutoSize = true;
            erkek.Location = new Point(14, 4);
            erkek.Name = "erkek";
            erkek.Size = new Size(65, 24);
            erkek.TabIndex = 0;
            erkek.TabStop = true;
            erkek.Text = "Erkek";
            erkek.UseVisualStyleBackColor = true;
            // 
            // tel_no
            // 
            tel_no.Location = new Point(187, 254);
            tel_no.Name = "tel_no";
            tel_no.Size = new Size(250, 27);
            tel_no.TabIndex = 5;
            // 
            // telno_lbl
            // 
            telno_lbl.AutoSize = true;
            telno_lbl.Location = new Point(27, 261);
            telno_lbl.Name = "telno_lbl";
            telno_lbl.Size = new Size(82, 20);
            telno_lbl.TabIndex = 0;
            telno_lbl.Text = "Telefon No";
            // 
            // baba_soniki
            // 
            baba_soniki.Location = new Point(732, 219);
            baba_soniki.Name = "baba_soniki";
            baba_soniki.Size = new Size(250, 27);
            baba_soniki.TabIndex = 5;
            // 
            // parola_tekrar
            // 
            parola_tekrar.Location = new Point(732, 168);
            parola_tekrar.MaxLength = 10;
            parola_tekrar.Name = "parola_tekrar";
            parola_tekrar.Size = new Size(250, 27);
            parola_tekrar.TabIndex = 7;
            parola_tekrar.TextChanged += parola_TextChanged;
            parola_tekrar.KeyPress += parola_KeyPress;
            // 
            // parola
            // 
            parola.Location = new Point(732, 119);
            parola.MaxLength = 10;
            parola.Name = "parola";
            parola.Size = new Size(250, 27);
            parola.TabIndex = 8;
            parola.TextChanged += parola_TextChanged;
            parola.KeyPress += parola_KeyPress;
            // 
            // kullanici_ad
            // 
            kullanici_ad.Location = new Point(732, 70);
            kullanici_ad.Name = "kullanici_ad";
            kullanici_ad.Size = new Size(250, 27);
            kullanici_ad.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 5F);
            label10.Location = new Point(555, 222);
            label10.Name = "label10";
            label10.Size = new Size(9, 12);
            label10.TabIndex = 10;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.5F);
            label11.Location = new Point(732, 547);
            label11.Name = "label11";
            label11.Size = new Size(558, 17);
            label11.TabIndex = 11;
            label11.Text = "Şifrede en az bir büyük harf, en az bir küçük harf ve en az bir rakam bulunmasına dikkat ediniz.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.5F);
            label12.Location = new Point(732, 490);
            label12.Name = "label12";
            label12.Size = new Size(450, 17);
            label12.TabIndex = 11;
            label12.Text = "* Babanın son iki harfi, çeşitli güvenlik sorularında sorulacağı için girilmelidir.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.5F);
            label13.Location = new Point(732, 575);
            label13.Name = "label13";
            label13.Size = new Size(283, 17);
            label13.TabIndex = 11;
            label13.Text = "Şifre en az 6, en fazla 10 karakterden oluşabilir.";
            // 
            // kaydet
            // 
            kaydet.Location = new Point(460, 371);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(147, 58);
            kaydet.TabIndex = 12;
            kaydet.Text = "BİLGİLERİ KAYDET";
            kaydet.UseVisualStyleBackColor = true;
            kaydet.Click += kaydet_Click;
            // 
            // ilerleme_cubugu
            // 
            ilerleme_cubugu.Location = new Point(1102, 117);
            ilerleme_cubugu.Name = "ilerleme_cubugu";
            ilerleme_cubugu.Size = new Size(280, 29);
            ilerleme_cubugu.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1102, 171);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 14;
            label7.Text = "Şifre Durumu : ";
            // 
            // sifre_durumu
            // 
            sifre_durumu.AutoSize = true;
            sifre_durumu.Location = new Point(1221, 170);
            sifre_durumu.Name = "sifre_durumu";
            sifre_durumu.Size = new Size(18, 20);
            sifre_durumu.TabIndex = 15;
            sifre_durumu.Text = "...";
            // 
            // parola_goster
            // 
            parola_goster.Location = new Point(988, 117);
            parola_goster.Name = "parola_goster";
            parola_goster.Size = new Size(82, 29);
            parola_goster.TabIndex = 16;
            parola_goster.Text = "Göster";
            parola_goster.UseVisualStyleBackColor = true;
            parola_goster.Click += parola_goster_Click;
            // 
            // parolatekrar_goster
            // 
            parolatekrar_goster.Location = new Point(988, 167);
            parolatekrar_goster.Name = "parolatekrar_goster";
            parolatekrar_goster.Size = new Size(82, 29);
            parolatekrar_goster.TabIndex = 16;
            parolatekrar_goster.Text = "Göster";
            parolatekrar_goster.UseVisualStyleBackColor = true;
            parolatekrar_goster.Click += parolatekrar_goster_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F);
            label1.Location = new Point(732, 519);
            label1.Name = "label1";
            label1.Size = new Size(371, 17);
            label1.TabIndex = 11;
            label1.Text = "** Kaydolabilmek için en az 16 yaşında olmanız gerekmektedir.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 5F);
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(13, 12);
            label2.TabIndex = 17;
            label2.Text = "**";
            // 
            // KullanıcıUyeOlma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 601);
            Controls.Add(label2);
            Controls.Add(parolatekrar_goster);
            Controls.Add(parola_goster);
            Controls.Add(sifre_durumu);
            Controls.Add(label7);
            Controls.Add(ilerleme_cubugu);
            Controls.Add(kaydet);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(kullanici_ad);
            Controls.Add(parola);
            Controls.Add(parola_tekrar);
            Controls.Add(baba_soniki);
            Controls.Add(tel_no);
            Controls.Add(panel1);
            Controls.Add(dogum_tarihi);
            Controls.Add(soyad);
            Controls.Add(ad);
            Controls.Add(babasoniki_lbl);
            Controls.Add(parolatekrar_lbl);
            Controls.Add(telno_lbl);
            Controls.Add(cinsiyet_lbl);
            Controls.Add(parola_lbl);
            Controls.Add(dogum_lbl);
            Controls.Add(kullaniciad_lbl);
            Controls.Add(soyad_lbl);
            Controls.Add(ad_lbl);
            Name = "KullanıcıUyeOlma";
            Text = "Üyelik İşlemleri";
            Load += KullanıcıUyeOlma_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ad_lbl;
        private Label soyad_lbl;
        private Label dogum_lbl;
        private Label cinsiyet_lbl;
        private Label kullaniciad_lbl;
        private Label parola_lbl;
        private Label parolatekrar_lbl;
        private Label babasoniki_lbl;
        private TextBox ad;
        private TextBox soyad;
        private DateTimePicker dogum_tarihi;
        private Panel panel1;
        private MaskedTextBox tel_no;
        private Label telno_lbl;
        private MaskedTextBox baba_soniki;
        private TextBox parola_tekrar;
        private TextBox parola;
        private TextBox kullanici_ad;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private RadioButton kadin;
        private RadioButton erkek;
        private Button kaydet;
        private ProgressBar ilerleme_cubugu;
        private Label label7;
        private Label sifre_durumu;
        private Button parola_goster;
        private Button parolatekrar_goster;
        private Label label1;
        private Label label2;
    }
}