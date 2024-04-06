namespace kütüphane_otomasyonu
{
    partial class YoneticiSifreDegistirme
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
            parolatekrar_goster = new Button();
            parola_goster = new Button();
            parola_lbl = new Label();
            parolatekrar_lbl = new Label();
            parola = new TextBox();
            parola_tekrar = new TextBox();
            ilerleme_cubugu = new ProgressBar();
            label3 = new Label();
            sifre_durumu = new Label();
            kaydet = new Button();
            giris_ekranı = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // parolatekrar_goster
            // 
            parolatekrar_goster.Location = new Point(413, 106);
            parolatekrar_goster.Name = "parolatekrar_goster";
            parolatekrar_goster.Size = new Size(94, 29);
            parolatekrar_goster.TabIndex = 0;
            parolatekrar_goster.Text = "Göster";
            parolatekrar_goster.UseVisualStyleBackColor = true;
            parolatekrar_goster.Click += parolatekrar_goster_Click;
            // 
            // parola_goster
            // 
            parola_goster.Location = new Point(413, 49);
            parola_goster.Name = "parola_goster";
            parola_goster.Size = new Size(94, 29);
            parola_goster.TabIndex = 0;
            parola_goster.Text = "Göster";
            parola_goster.UseVisualStyleBackColor = true;
            parola_goster.Click += parola_goster_Click;
            // 
            // parola_lbl
            // 
            parola_lbl.AutoSize = true;
            parola_lbl.Location = new Point(36, 58);
            parola_lbl.Name = "parola_lbl";
            parola_lbl.Size = new Size(50, 20);
            parola_lbl.TabIndex = 1;
            parola_lbl.Text = "Parola";
            // 
            // parolatekrar_lbl
            // 
            parolatekrar_lbl.AutoSize = true;
            parolatekrar_lbl.Location = new Point(36, 115);
            parolatekrar_lbl.Name = "parolatekrar_lbl";
            parolatekrar_lbl.Size = new Size(94, 20);
            parolatekrar_lbl.TabIndex = 1;
            parolatekrar_lbl.Text = "Parola Tekrar";
            // 
            // parola
            // 
            parola.Location = new Point(162, 51);
            parola.Name = "parola";
            parola.Size = new Size(202, 27);
            parola.TabIndex = 2;
            parola.TextChanged += parola_TextChanged;
            parola.KeyPress += parola_KeyPress;
            // 
            // parola_tekrar
            // 
            parola_tekrar.Location = new Point(162, 108);
            parola_tekrar.Name = "parola_tekrar";
            parola_tekrar.Size = new Size(202, 27);
            parola_tekrar.TabIndex = 2;
            parola_tekrar.TextChanged += parola_TextChanged;
            parola_tekrar.KeyPress += parola_KeyPress;
            // 
            // ilerleme_cubugu
            // 
            ilerleme_cubugu.Location = new Point(680, 49);
            ilerleme_cubugu.Name = "ilerleme_cubugu";
            ilerleme_cubugu.Size = new Size(263, 29);
            ilerleme_cubugu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 110);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 4;
            label3.Text = "Şifre Durumu : ";
            // 
            // sifre_durumu
            // 
            sifre_durumu.AutoSize = true;
            sifre_durumu.Location = new Point(793, 111);
            sifre_durumu.Name = "sifre_durumu";
            sifre_durumu.Size = new Size(18, 20);
            sifre_durumu.TabIndex = 5;
            sifre_durumu.Text = "...";
            // 
            // kaydet
            // 
            kaydet.Location = new Point(203, 186);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(134, 48);
            kaydet.TabIndex = 6;
            kaydet.Text = "KAYDET";
            kaydet.UseVisualStyleBackColor = true;
            kaydet.Click += kaydet_Click;
            // 
            // giris_ekranı
            // 
            giris_ekranı.Location = new Point(722, 196);
            giris_ekranı.Name = "giris_ekranı";
            giris_ekranı.Size = new Size(187, 29);
            giris_ekranı.TabIndex = 7;
            giris_ekranı.Text = "GİRİŞ EKRANINA DÖN";
            giris_ekranı.UseVisualStyleBackColor = true;
            giris_ekranı.Click += giris_ekranı_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.5F);
            label5.Location = new Point(46, 325);
            label5.Name = "label5";
            label5.Size = new Size(539, 17);
            label5.TabIndex = 8;
            label5.Text = "Şifrenizde en az bir küçük harf, en az bir büyük harf ve bir rakam bulunmasına dikkat ediniz.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.5F);
            label6.Location = new Point(46, 354);
            label6.Name = "label6";
            label6.Size = new Size(338, 17);
            label6.TabIndex = 8;
            label6.Text = "Şİfreniz minimum 6, maksimum 10 karakterden oluşabilir.";
            // 
            // YoneticiSifreDegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 443);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(giris_ekranı);
            Controls.Add(kaydet);
            Controls.Add(sifre_durumu);
            Controls.Add(label3);
            Controls.Add(ilerleme_cubugu);
            Controls.Add(parola_tekrar);
            Controls.Add(parola);
            Controls.Add(parolatekrar_lbl);
            Controls.Add(parola_lbl);
            Controls.Add(parola_goster);
            Controls.Add(parolatekrar_goster);
            Name = "YoneticiSifreDegistirme";
            Text = "Yönetici Şifre Değitirme Ekranı - 2";
            Load += YoneticiSifreDegistirme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button parolatekrar_goster;
        private Button parola_goster;
        private Label parola_lbl;
        private Label parolatekrar_lbl;
        private TextBox parola;
        private TextBox parola_tekrar;
        private ProgressBar ilerleme_cubugu;
        private Label label3;
        private Label sifre_durumu;
        private Button kaydet;
        private Button giris_ekranı;
        private Label label5;
        private Label label6;
    }
}