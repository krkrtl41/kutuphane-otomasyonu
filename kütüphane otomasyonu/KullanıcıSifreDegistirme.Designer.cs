namespace kütüphane_otomasyonu
{
    partial class KullanıcıSifreDegistirme
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
            parola_lbl = new Label();
            parolatekrar_lbl = new Label();
            parola = new TextBox();
            parola_tekrar = new TextBox();
            ilerleme_cubugu = new ProgressBar();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            kaydet = new Button();
            sifre_durum = new Label();
            giris_ekranı = new Button();
            SuspendLayout();
            // 
            // parola_lbl
            // 
            parola_lbl.AutoSize = true;
            parola_lbl.Location = new Point(43, 57);
            parola_lbl.Name = "parola_lbl";
            parola_lbl.Size = new Size(50, 20);
            parola_lbl.TabIndex = 0;
            parola_lbl.Text = "Parola";
            // 
            // parolatekrar_lbl
            // 
            parolatekrar_lbl.AutoSize = true;
            parolatekrar_lbl.Location = new Point(43, 129);
            parolatekrar_lbl.Name = "parolatekrar_lbl";
            parolatekrar_lbl.Size = new Size(94, 20);
            parolatekrar_lbl.TabIndex = 1;
            parolatekrar_lbl.Text = "Parola Tekrar";
            // 
            // parola
            // 
            parola.Location = new Point(186, 50);
            parola.MaxLength = 10;
            parola.Name = "parola";
            parola.Size = new Size(231, 27);
            parola.TabIndex = 2;
            parola.TextChanged += parola_TextChanged;
            parola.KeyPress += parola_KeyPress;
            // 
            // parola_tekrar
            // 
            parola_tekrar.Location = new Point(186, 122);
            parola_tekrar.MaxLength = 10;
            parola_tekrar.Name = "parola_tekrar";
            parola_tekrar.Size = new Size(231, 27);
            parola_tekrar.TabIndex = 2;
            parola_tekrar.TextChanged += parola_TextChanged;
            parola_tekrar.KeyPress += parola_KeyPress;
            // 
            // ilerleme_cubugu
            // 
            ilerleme_cubugu.Location = new Point(597, 48);
            ilerleme_cubugu.Name = "ilerleme_cubugu";
            ilerleme_cubugu.Size = new Size(285, 29);
            ilerleme_cubugu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.5F);
            label3.Location = new Point(56, 319);
            label3.Name = "label3";
            label3.Size = new Size(335, 17);
            label3.TabIndex = 4;
            label3.Text = "*Şifre minimum 6, maksmum 10 karakterden oluşmalıdır.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 129);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 4;
            label4.Text = "Şifre Durumu : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.5F);
            label5.Location = new Point(56, 349);
            label5.Name = "label5";
            label5.Size = new Size(493, 17);
            label5.TabIndex = 4;
            label5.Text = "*Şifrede en az bir büyük harf, bir küçük harf ve bir rakam bulunmasına dikkat ediniz.";
            // 
            // kaydet
            // 
            kaydet.Location = new Point(238, 200);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(132, 47);
            kaydet.TabIndex = 5;
            kaydet.Text = "KAYDET";
            kaydet.UseVisualStyleBackColor = true;
            kaydet.Click += kaydet_Click;
            // 
            // sifre_durum
            // 
            sifre_durum.AutoSize = true;
            sifre_durum.Location = new Point(710, 129);
            sifre_durum.Name = "sifre_durum";
            sifre_durum.Size = new Size(18, 20);
            sifre_durum.TabIndex = 4;
            sifre_durum.Text = "...";
            // 
            // giris_ekranı
            // 
            giris_ekranı.Location = new Point(650, 209);
            giris_ekranı.Name = "giris_ekranı";
            giris_ekranı.Size = new Size(187, 29);
            giris_ekranı.TabIndex = 8;
            giris_ekranı.Text = "GİRİŞ EKRANINA DÖN";
            giris_ekranı.UseVisualStyleBackColor = true;
            giris_ekranı.Click += giris_ekranı_Click;
            // 
            // KullanıcıSifreDegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 443);
            Controls.Add(giris_ekranı);
            Controls.Add(kaydet);
            Controls.Add(sifre_durum);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(ilerleme_cubugu);
            Controls.Add(parola_tekrar);
            Controls.Add(parola);
            Controls.Add(parolatekrar_lbl);
            Controls.Add(parola_lbl);
            Name = "KullanıcıSifreDegistirme";
            Text = "Şifre Değiştirme Ekranı - 2";
            Load += KullanıcıSifreDegistirme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label parola_lbl;
        private Label parolatekrar_lbl;
        private TextBox parola;
        private TextBox parola_tekrar;
        private ProgressBar ilerleme_cubugu;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button kaydet;
        private Label sifre_durum;
        private Button giris_ekranı;
    }
}