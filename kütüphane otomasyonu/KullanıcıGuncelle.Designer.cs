namespace kütüphane_otomasyonu
{
    partial class KullanıcıGuncelle
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
            telno_lbl = new Label();
            parola_lbl = new Label();
            parolatekrar_lbl = new Label();
            babasoniki_lbl = new Label();
            label5 = new Label();
            kullanici_ad = new TextBox();
            parola = new TextBox();
            parola_tekrar = new TextBox();
            tel_no = new MaskedTextBox();
            baba_soniki = new MaskedTextBox();
            kaydet = new Button();
            cikis = new Button();
            ilerleme_cubugu = new ProgressBar();
            label6 = new Label();
            sifre_durumu = new Label();
            parola_check = new CheckBox();
            telno_check = new CheckBox();
            babasoniki_check = new CheckBox();
            parola_goster = new Button();
            parolatekrar_goster = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // telno_lbl
            // 
            telno_lbl.AutoSize = true;
            telno_lbl.Location = new Point(91, 102);
            telno_lbl.Name = "telno_lbl";
            telno_lbl.Size = new Size(125, 20);
            telno_lbl.TabIndex = 0;
            telno_lbl.Text = "Telefon Numarası";
            // 
            // parola_lbl
            // 
            parola_lbl.AutoSize = true;
            parola_lbl.Location = new Point(91, 161);
            parola_lbl.Name = "parola_lbl";
            parola_lbl.Size = new Size(50, 20);
            parola_lbl.TabIndex = 0;
            parola_lbl.Text = "Parola";
            // 
            // parolatekrar_lbl
            // 
            parolatekrar_lbl.AutoSize = true;
            parolatekrar_lbl.Location = new Point(91, 220);
            parolatekrar_lbl.Name = "parolatekrar_lbl";
            parolatekrar_lbl.Size = new Size(94, 20);
            parolatekrar_lbl.TabIndex = 0;
            parolatekrar_lbl.Text = "Parola Tekrar";
            // 
            // babasoniki_lbl
            // 
            babasoniki_lbl.AutoSize = true;
            babasoniki_lbl.Location = new Point(91, 279);
            babasoniki_lbl.Name = "babasoniki_lbl";
            babasoniki_lbl.Size = new Size(148, 20);
            babasoniki_lbl.TabIndex = 0;
            babasoniki_lbl.Text = "Babanın Son İki Harfi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 43);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 0;
            label5.Text = "Kullanıcı Ad";
            // 
            // kullanici_ad
            // 
            kullanici_ad.Enabled = false;
            kullanici_ad.Location = new Point(285, 36);
            kullanici_ad.Name = "kullanici_ad";
            kullanici_ad.ReadOnly = true;
            kullanici_ad.Size = new Size(301, 27);
            kullanici_ad.TabIndex = 1;
            // 
            // parola
            // 
            parola.Location = new Point(285, 154);
            parola.Name = "parola";
            parola.Size = new Size(301, 27);
            parola.TabIndex = 2;
            parola.TextChanged += parola_TextChanged;
            parola.KeyPress += parola_KeyPress;
            // 
            // parola_tekrar
            // 
            parola_tekrar.Location = new Point(285, 213);
            parola_tekrar.Name = "parola_tekrar";
            parola_tekrar.Size = new Size(301, 27);
            parola_tekrar.TabIndex = 1;
            parola_tekrar.TextChanged += parola_TextChanged;
            parola_tekrar.KeyPress += parola_KeyPress;
            // 
            // tel_no
            // 
            tel_no.Location = new Point(285, 95);
            tel_no.Name = "tel_no";
            tel_no.Size = new Size(301, 27);
            tel_no.TabIndex = 3;
            tel_no.TextChanged += tel_no_TextChanged;
            tel_no.KeyPress += parola_KeyPress;
            // 
            // baba_soniki
            // 
            baba_soniki.Location = new Point(285, 272);
            baba_soniki.Name = "baba_soniki";
            baba_soniki.ResetOnSpace = false;
            baba_soniki.Size = new Size(301, 27);
            baba_soniki.TabIndex = 3;
            baba_soniki.TabStop = false;
            baba_soniki.KeyPress += parola_KeyPress;
            // 
            // kaydet
            // 
            kaydet.Location = new Point(357, 369);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(162, 49);
            kaydet.TabIndex = 4;
            kaydet.Text = "KAYDET";
            kaydet.UseVisualStyleBackColor = true;
            kaydet.Click += kaydet_Click;
            // 
            // cikis
            // 
            cikis.Location = new Point(892, 369);
            cikis.Name = "cikis";
            cikis.Size = new Size(145, 49);
            cikis.TabIndex = 4;
            cikis.Text = "ÇIKIŞ";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // ilerleme_cubugu
            // 
            ilerleme_cubugu.Location = new Point(801, 152);
            ilerleme_cubugu.Name = "ilerleme_cubugu";
            ilerleme_cubugu.Size = new Size(306, 29);
            ilerleme_cubugu.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(801, 216);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 6;
            label6.Text = "Şifre Durumu : ";
            // 
            // sifre_durumu
            // 
            sifre_durumu.AutoSize = true;
            sifre_durumu.Location = new Point(905, 216);
            sifre_durumu.Name = "sifre_durumu";
            sifre_durumu.Size = new Size(18, 20);
            sifre_durumu.TabIndex = 7;
            sifre_durumu.Text = "...";
            // 
            // parola_check
            // 
            parola_check.AutoSize = true;
            parola_check.Location = new Point(51, 165);
            parola_check.Name = "parola_check";
            parola_check.Size = new Size(18, 17);
            parola_check.TabIndex = 8;
            parola_check.UseVisualStyleBackColor = true;
            parola_check.CheckedChanged += telno_check_CheckedChanged;
            // 
            // telno_check
            // 
            telno_check.AutoSize = true;
            telno_check.Location = new Point(51, 107);
            telno_check.Name = "telno_check";
            telno_check.Size = new Size(18, 17);
            telno_check.TabIndex = 8;
            telno_check.UseVisualStyleBackColor = true;
            telno_check.CheckedChanged += telno_check_CheckedChanged;
            // 
            // babasoniki_check
            // 
            babasoniki_check.AutoSize = true;
            babasoniki_check.Location = new Point(51, 279);
            babasoniki_check.Name = "babasoniki_check";
            babasoniki_check.Size = new Size(18, 17);
            babasoniki_check.TabIndex = 8;
            babasoniki_check.UseVisualStyleBackColor = true;
            babasoniki_check.CheckedChanged += telno_check_CheckedChanged;
            // 
            // parola_goster
            // 
            parola_goster.Location = new Point(616, 154);
            parola_goster.Name = "parola_goster";
            parola_goster.Size = new Size(94, 29);
            parola_goster.TabIndex = 9;
            parola_goster.Text = "Göster";
            parola_goster.UseVisualStyleBackColor = true;
            parola_goster.Click += parola_goster_Click;
            // 
            // parolatekrar_goster
            // 
            parolatekrar_goster.Location = new Point(616, 211);
            parolatekrar_goster.Name = "parolatekrar_goster";
            parolatekrar_goster.Size = new Size(94, 29);
            parolatekrar_goster.TabIndex = 9;
            parolatekrar_goster.Text = "Göster";
            parolatekrar_goster.UseVisualStyleBackColor = true;
            parolatekrar_goster.Click += parolatekrar_goster_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F);
            label1.Location = new Point(41, 455);
            label1.Name = "label1";
            label1.Size = new Size(490, 17);
            label1.TabIndex = 10;
            label1.Text = "Parolanın en az bir küçük harf, bir büyük harf ve bir rakam içermesine dikkat ediniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.5F);
            label2.Location = new Point(41, 484);
            label2.Name = "label2";
            label2.Size = new Size(319, 17);
            label2.TabIndex = 10;
            label2.Text = "Parola minimum 6, maksimum 10 karakter içermelidir.";
            // 
            // KullanıcıGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1160, 524);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(parolatekrar_goster);
            Controls.Add(parola_goster);
            Controls.Add(babasoniki_check);
            Controls.Add(telno_check);
            Controls.Add(parola_check);
            Controls.Add(sifre_durumu);
            Controls.Add(label6);
            Controls.Add(ilerleme_cubugu);
            Controls.Add(cikis);
            Controls.Add(kaydet);
            Controls.Add(baba_soniki);
            Controls.Add(tel_no);
            Controls.Add(parola);
            Controls.Add(parola_tekrar);
            Controls.Add(kullanici_ad);
            Controls.Add(babasoniki_lbl);
            Controls.Add(parolatekrar_lbl);
            Controls.Add(parola_lbl);
            Controls.Add(label5);
            Controls.Add(telno_lbl);
            Name = "KullanıcıGuncelle";
            Text = "Kullanıcı Güncelleme";
            Load += KullanıcıGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label telno_lbl;
        private Label parola_lbl;
        private Label parolatekrar_lbl;
        private Label babasoniki_lbl;
        private Label label5;
        private TextBox kullanici_ad;
        private TextBox parola;
        private TextBox parola_tekrar;
        private MaskedTextBox tel_no;
        private MaskedTextBox baba_soniki;
        private Button kaydet;
        private Button cikis;
        private ProgressBar ilerleme_cubugu;
        private Label label6;
        private Label sifre_durumu;
        private CheckBox parola_check;
        private CheckBox telno_check;
        private CheckBox babasoniki_check;
        private Button parola_goster;
        private Button parolatekrar_goster;
        private Label label1;
        private Label label2;
    }
}