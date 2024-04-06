namespace kütüphane_otomasyonu
{
    partial class KullanıcıEkranı
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            kirala = new Button();
            kitap_arama = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            kiralanamaz = new RadioButton();
            kiralanabilir = new RadioButton();
            eklenme_tarihi = new TextBox();
            sayfa_sayisi = new TextBox();
            kitap_ad = new TextBox();
            cikis_tarihi = new TextBox();
            turu = new TextBox();
            yazar = new TextBox();
            aciklama = new RichTextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            resim_kutusu = new PictureBox();
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            label15 = new Label();
            label16 = new Label();
            kitap_vt = new DataGridView();
            tabPage2 = new TabPage();
            label23 = new Label();
            label22 = new Label();
            babasoniki_check = new CheckBox();
            parola_check = new CheckBox();
            tel_check = new CheckBox();
            sifre_durumu = new Label();
            ilerleme_cubugu = new ProgressBar();
            guncelle = new Button();
            label21 = new Label();
            tel_no = new MaskedTextBox();
            baba_soniki = new MaskedTextBox();
            parolatekrar_goster = new Button();
            parola_goster = new Button();
            kiralanan_resim = new PictureBox();
            panel1 = new Panel();
            kadin = new RadioButton();
            erkek = new RadioButton();
            dogum_tarih = new DateTimePicker();
            ad = new TextBox();
            parola_tekrar = new TextBox();
            parola = new TextBox();
            soyad = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            kiralanan_kitap_vt = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resim_kutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitap_vt).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kiralanan_resim).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kiralanan_kitap_vt).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1096, 984);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "        ";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Wheat;
            tabPage1.Controls.Add(kirala);
            tabPage1.Controls.Add(kitap_arama);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(eklenme_tarihi);
            tabPage1.Controls.Add(sayfa_sayisi);
            tabPage1.Controls.Add(kitap_ad);
            tabPage1.Controls.Add(cikis_tarihi);
            tabPage1.Controls.Add(turu);
            tabPage1.Controls.Add(yazar);
            tabPage1.Controls.Add(aciklama);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(resim_kutusu);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(kitap_vt);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1088, 951);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "                                                  Kitap Bilgileri                                                       ";
            // 
            // kirala
            // 
            kirala.Location = new Point(807, 591);
            kirala.Name = "kirala";
            kirala.Size = new Size(243, 44);
            kirala.TabIndex = 28;
            kirala.Text = "KİRALA";
            kirala.UseVisualStyleBackColor = true;
            kirala.Click += kirala_Click;
            // 
            // kitap_arama
            // 
            kitap_arama.Location = new Point(277, 19);
            kitap_arama.Name = "kitap_arama";
            kitap_arama.Size = new Size(397, 27);
            kitap_arama.TabIndex = 27;
            kitap_arama.TextChanged += kitap_arama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 22);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 26;
            label3.Text = "Kitap Ara :";
            // 
            // panel2
            // 
            panel2.Controls.Add(kiralanamaz);
            panel2.Controls.Add(kiralanabilir);
            panel2.Enabled = false;
            panel2.Location = new Point(778, 532);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 32);
            panel2.TabIndex = 24;
            // 
            // kiralanamaz
            // 
            kiralanamaz.AutoSize = true;
            kiralanamaz.Location = new Point(161, 4);
            kiralanamaz.Name = "kiralanamaz";
            kiralanamaz.Size = new Size(112, 24);
            kiralanamaz.TabIndex = 0;
            kiralanamaz.TabStop = true;
            kiralanamaz.Text = "Kiralanamaz";
            kiralanamaz.UseVisualStyleBackColor = true;
            // 
            // kiralanabilir
            // 
            kiralanabilir.AutoSize = true;
            kiralanabilir.Location = new Point(13, 4);
            kiralanabilir.Name = "kiralanabilir";
            kiralanabilir.Size = new Size(110, 24);
            kiralanabilir.TabIndex = 0;
            kiralanabilir.TabStop = true;
            kiralanabilir.Text = "Kiralanabilir";
            kiralanabilir.UseVisualStyleBackColor = true;
            // 
            // eklenme_tarihi
            // 
            eklenme_tarihi.Location = new Point(778, 475);
            eklenme_tarihi.Name = "eklenme_tarihi";
            eklenme_tarihi.ReadOnly = true;
            eklenme_tarihi.Size = new Size(285, 27);
            eklenme_tarihi.TabIndex = 18;
            // 
            // sayfa_sayisi
            // 
            sayfa_sayisi.Location = new Point(778, 425);
            sayfa_sayisi.Name = "sayfa_sayisi";
            sayfa_sayisi.ReadOnly = true;
            sayfa_sayisi.Size = new Size(285, 27);
            sayfa_sayisi.TabIndex = 18;
            // 
            // kitap_ad
            // 
            kitap_ad.Location = new Point(144, 425);
            kitap_ad.Name = "kitap_ad";
            kitap_ad.ReadOnly = true;
            kitap_ad.Size = new Size(285, 27);
            kitap_ad.TabIndex = 18;
            // 
            // cikis_tarihi
            // 
            cikis_tarihi.Location = new Point(144, 575);
            cikis_tarihi.Name = "cikis_tarihi";
            cikis_tarihi.ReadOnly = true;
            cikis_tarihi.Size = new Size(285, 27);
            cikis_tarihi.TabIndex = 18;
            // 
            // turu
            // 
            turu.Location = new Point(144, 525);
            turu.Name = "turu";
            turu.ReadOnly = true;
            turu.Size = new Size(285, 27);
            turu.TabIndex = 18;
            // 
            // yazar
            // 
            yazar.Location = new Point(144, 475);
            yazar.Name = "yazar";
            yazar.ReadOnly = true;
            yazar.Size = new Size(285, 27);
            yazar.TabIndex = 18;
            // 
            // aciklama
            // 
            aciklama.Location = new Point(17, 655);
            aciklama.Name = "aciklama";
            aciklama.ReadOnly = true;
            aciklama.Size = new Size(1046, 278);
            aciklama.TabIndex = 17;
            aciklama.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(61, 632);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 16;
            label10.Text = "Açıklama";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(600, 532);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 15;
            label11.Text = "Kiralık Durumu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(600, 482);
            label12.Name = "label12";
            label12.Size = new Size(104, 20);
            label12.TabIndex = 14;
            label12.Text = "Eklenme Tarihi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(600, 433);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 13;
            label13.Text = "Sayfa Sayısı";
            // 
            // resim_kutusu
            // 
            resim_kutusu.BorderStyle = BorderStyle.Fixed3D;
            resim_kutusu.Location = new Point(878, 69);
            resim_kutusu.Name = "resim_kutusu";
            resim_kutusu.Size = new Size(185, 290);
            resim_kutusu.SizeMode = PictureBoxSizeMode.Zoom;
            resim_kutusu.TabIndex = 12;
            resim_kutusu.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 582);
            label14.Name = "label14";
            label14.Size = new Size(78, 20);
            label14.TabIndex = 10;
            label14.Text = "Çıkış Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 432);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 9;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 486);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 9;
            label2.Text = "Yazarı";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 536);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 9;
            label15.Text = "Türü";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 381);
            label16.Name = "label16";
            label16.Size = new Size(59, 20);
            label16.TabIndex = 11;
            label16.Text = "Kitabın:";
            // 
            // kitap_vt
            // 
            kitap_vt.BackgroundColor = SystemColors.ButtonHighlight;
            kitap_vt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kitap_vt.Location = new Point(28, 69);
            kitap_vt.Name = "kitap_vt";
            kitap_vt.ReadOnly = true;
            kitap_vt.RowHeadersWidth = 51;
            kitap_vt.Size = new Size(837, 290);
            kitap_vt.TabIndex = 8;
            kitap_vt.SelectionChanged += kitap_vt_SelectionChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Wheat;
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(babasoniki_check);
            tabPage2.Controls.Add(parola_check);
            tabPage2.Controls.Add(tel_check);
            tabPage2.Controls.Add(sifre_durumu);
            tabPage2.Controls.Add(ilerleme_cubugu);
            tabPage2.Controls.Add(guncelle);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(tel_no);
            tabPage2.Controls.Add(baba_soniki);
            tabPage2.Controls.Add(parolatekrar_goster);
            tabPage2.Controls.Add(parola_goster);
            tabPage2.Controls.Add(kiralanan_resim);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(dogum_tarih);
            tabPage2.Controls.Add(ad);
            tabPage2.Controls.Add(parola_tekrar);
            tabPage2.Controls.Add(parola);
            tabPage2.Controls.Add(soyad);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(kiralanan_kitap_vt);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1088, 951);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "                                                          Kişisel Bilgiler                                                          ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 7.5F);
            label23.Location = new Point(25, 836);
            label23.Name = "label23";
            label23.Size = new Size(741, 17);
            label23.TabIndex = 17;
            label23.Text = "Şifrenin minimum 6, maksimum 10 karakter olmasına, en az bir küçük harf, bir büyük harf ve bir rakam içermesine dikkat ediniz";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 7.5F);
            label22.Location = new Point(25, 803);
            label22.Name = "label22";
            label22.Size = new Size(535, 17);
            label22.TabIndex = 17;
            label22.Text = "Değiştirmek istediğiniz bilgilerin yanında bulunan kutucukların işaretlenmesi gerekmektedir.";
            // 
            // babasoniki_check
            // 
            babasoniki_check.AutoSize = true;
            babasoniki_check.Location = new Point(189, 738);
            babasoniki_check.Name = "babasoniki_check";
            babasoniki_check.Size = new Size(18, 17);
            babasoniki_check.TabIndex = 16;
            babasoniki_check.UseVisualStyleBackColor = true;
            babasoniki_check.CheckedChanged += tel_check_CheckedChanged;
            // 
            // parola_check
            // 
            parola_check.AutoSize = true;
            parola_check.Location = new Point(189, 619);
            parola_check.Name = "parola_check";
            parola_check.Size = new Size(18, 17);
            parola_check.TabIndex = 16;
            parola_check.UseVisualStyleBackColor = true;
            parola_check.CheckedChanged += tel_check_CheckedChanged;
            // 
            // tel_check
            // 
            tel_check.AutoSize = true;
            tel_check.Location = new Point(189, 560);
            tel_check.Name = "tel_check";
            tel_check.Size = new Size(18, 17);
            tel_check.TabIndex = 16;
            tel_check.UseVisualStyleBackColor = true;
            tel_check.CheckedChanged += tel_check_CheckedChanged;
            // 
            // sifre_durumu
            // 
            sifre_durumu.AutoSize = true;
            sifre_durumu.Location = new Point(767, 673);
            sifre_durumu.Name = "sifre_durumu";
            sifre_durumu.Size = new Size(18, 20);
            sifre_durumu.TabIndex = 15;
            sifre_durumu.Text = "...";
            // 
            // ilerleme_cubugu
            // 
            ilerleme_cubugu.Location = new Point(654, 610);
            ilerleme_cubugu.Name = "ilerleme_cubugu";
            ilerleme_cubugu.Size = new Size(326, 29);
            ilerleme_cubugu.TabIndex = 14;
            // 
            // guncelle
            // 
            guncelle.Location = new Point(460, 888);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(119, 55);
            guncelle.TabIndex = 13;
            guncelle.Text = "GÜNCELLE";
            guncelle.UseVisualStyleBackColor = true;
            guncelle.Click += guncelle_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(654, 673);
            label21.Name = "label21";
            label21.Size = new Size(107, 20);
            label21.TabIndex = 12;
            label21.Text = "Şifre Durumu : ";
            // 
            // tel_no
            // 
            tel_no.Location = new Point(223, 554);
            tel_no.Name = "tel_no";
            tel_no.Size = new Size(216, 27);
            tel_no.TabIndex = 11;
            // 
            // baba_soniki
            // 
            baba_soniki.Location = new Point(223, 728);
            baba_soniki.Name = "baba_soniki";
            baba_soniki.Size = new Size(216, 27);
            baba_soniki.TabIndex = 11;
            // 
            // parolatekrar_goster
            // 
            parolatekrar_goster.Location = new Point(460, 671);
            parolatekrar_goster.Name = "parolatekrar_goster";
            parolatekrar_goster.Size = new Size(83, 29);
            parolatekrar_goster.TabIndex = 10;
            parolatekrar_goster.Text = "Göster";
            parolatekrar_goster.UseVisualStyleBackColor = true;
            parolatekrar_goster.Click += parolatekrar_goster_Click;
            // 
            // parola_goster
            // 
            parola_goster.Location = new Point(460, 612);
            parola_goster.Name = "parola_goster";
            parola_goster.Size = new Size(83, 29);
            parola_goster.TabIndex = 10;
            parola_goster.Text = "Göster";
            parola_goster.UseVisualStyleBackColor = true;
            parola_goster.Click += parola_goster_Click;
            // 
            // kiralanan_resim
            // 
            kiralanan_resim.BorderStyle = BorderStyle.Fixed3D;
            kiralanan_resim.Location = new Point(922, 46);
            kiralanan_resim.Name = "kiralanan_resim";
            kiralanan_resim.Size = new Size(158, 260);
            kiralanan_resim.SizeMode = PictureBoxSizeMode.Zoom;
            kiralanan_resim.TabIndex = 9;
            kiralanan_resim.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(kadin);
            panel1.Controls.Add(erkek);
            panel1.Location = new Point(783, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 34);
            panel1.TabIndex = 8;
            // 
            // kadin
            // 
            kadin.AutoSize = true;
            kadin.Enabled = false;
            kadin.Location = new Point(129, 4);
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
            erkek.Enabled = false;
            erkek.Location = new Point(6, 4);
            erkek.Name = "erkek";
            erkek.Size = new Size(65, 24);
            erkek.TabIndex = 0;
            erkek.TabStop = true;
            erkek.Text = "Erkek";
            erkek.UseVisualStyleBackColor = true;
            // 
            // dogum_tarih
            // 
            dogum_tarih.Enabled = false;
            dogum_tarih.Format = DateTimePickerFormat.Short;
            dogum_tarih.Location = new Point(783, 409);
            dogum_tarih.Name = "dogum_tarih";
            dogum_tarih.Size = new Size(216, 27);
            dogum_tarih.TabIndex = 7;
            // 
            // ad
            // 
            ad.Location = new Point(223, 414);
            ad.Name = "ad";
            ad.ReadOnly = true;
            ad.Size = new Size(216, 27);
            ad.TabIndex = 6;
            // 
            // parola_tekrar
            // 
            parola_tekrar.Location = new Point(223, 670);
            parola_tekrar.Name = "parola_tekrar";
            parola_tekrar.Size = new Size(216, 27);
            parola_tekrar.TabIndex = 6;
            parola_tekrar.TextChanged += parola_TextChanged;
            parola_tekrar.KeyPress += parola_KeyPress;
            // 
            // parola
            // 
            parola.Location = new Point(223, 612);
            parola.Name = "parola";
            parola.Size = new Size(216, 27);
            parola.TabIndex = 6;
            parola.TextChanged += parola_TextChanged;
            parola.KeyPress += parola_KeyPress;
            // 
            // soyad
            // 
            soyad.Location = new Point(223, 467);
            soyad.Name = "soyad";
            soyad.ReadOnly = true;
            soyad.Size = new Size(216, 27);
            soyad.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(25, 561);
            label20.Name = "label20";
            label20.Size = new Size(82, 20);
            label20.TabIndex = 4;
            label20.Text = "Telefon No";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 735);
            label19.Name = "label19";
            label19.Size = new Size(148, 20);
            label19.TabIndex = 3;
            label19.Text = "Babanın Son İki Harfi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 677);
            label18.Name = "label18";
            label18.Size = new Size(94, 20);
            label18.TabIndex = 3;
            label18.Text = "Parola Tekrar";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 619);
            label17.Name = "label17";
            label17.Size = new Size(50, 20);
            label17.TabIndex = 3;
            label17.Text = "Parola";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(642, 480);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 3;
            label9.Text = "Cinsiyet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(642, 416);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 3;
            label8.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 473);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 3;
            label7.Text = "Soyad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 416);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 3;
            label6.Text = "Ad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 350);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 2;
            label5.Text = "Kişisel Bilgiler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 20);
            label4.Name = "label4";
            label4.Size = new Size(258, 20);
            label4.TabIndex = 1;
            label4.Text = "Kiralamış Olduğunuz Kitapların Listesi";
            // 
            // kiralanan_kitap_vt
            // 
            kiralanan_kitap_vt.BackgroundColor = Color.White;
            kiralanan_kitap_vt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kiralanan_kitap_vt.Location = new Point(25, 46);
            kiralanan_kitap_vt.MultiSelect = false;
            kiralanan_kitap_vt.Name = "kiralanan_kitap_vt";
            kiralanan_kitap_vt.ReadOnly = true;
            kiralanan_kitap_vt.RowHeadersWidth = 51;
            kiralanan_kitap_vt.Size = new Size(866, 260);
            kiralanan_kitap_vt.TabIndex = 0;
            kiralanan_kitap_vt.SelectionChanged += kiralanan_kitap_vt_SelectionChanged;
            // 
            // KullanıcıEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 984);
            Controls.Add(tabControl1);
            Name = "KullanıcıEkranı";
            Text = "Kullanıcı Bilgi Ekranı";
            Load += KullanıcıEkranı_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resim_kutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitap_vt).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kiralanan_resim).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kiralanan_kitap_vt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private Label label4;
        private Label label9;
        private TextBox parola_tekrar;
        private TextBox parola;
        private TextBox soyad;
        private Panel panel2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox yazar;
        private RichTextBox aciklama;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox resim_kutusu;
        private Label label14;
        private Label label15;
        private Label label16;
        private DataGridView kitap_vt;
        private TextBox kitap_arama;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox eklenme_tarihi;
        private TextBox sayfa_sayisi;
        private TextBox kitap_ad;
        private TextBox cikis_tarihi;
        private TextBox turu;
        private RadioButton kiralanamaz;
        private RadioButton kiralanabilir;
        private Button kirala;
        private Label label18;
        private Label label17;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView kiralanan_kitap_vt;
        private Panel panel1;
        private RadioButton kadin;
        private RadioButton erkek;
        private DateTimePicker dogum_tarih;
        private TextBox ad;
        private Label label20;
        private Label label19;
        private Button parolatekrar_goster;
        private Button parola_goster;
        private PictureBox kiralanan_resim;
        private MaskedTextBox tel_no;
        private MaskedTextBox baba_soniki;
        private Label sifre_durumu;
        private ProgressBar ilerleme_cubugu;
        private Button guncelle;
        private Label label21;
        private Label label23;
        private Label label22;
        private CheckBox babasoniki_check;
        private CheckBox parola_check;
        private CheckBox tel_check;
    }
}