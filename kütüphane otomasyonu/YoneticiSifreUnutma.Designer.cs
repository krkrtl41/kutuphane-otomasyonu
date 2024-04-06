namespace kütüphane_otomasyonu
{
    partial class YoneticiSifreUnutma
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
            kullanici_ad_lbl = new Label();
            telno_lbl = new Label();
            babasoniki_lbl = new Label();
            kullanici_ad = new TextBox();
            tel_no = new MaskedTextBox();
            baba_soniki = new MaskedTextBox();
            devam = new Button();
            geri = new Button();
            SuspendLayout();
            // 
            // kullanici_ad_lbl
            // 
            kullanici_ad_lbl.AutoSize = true;
            kullanici_ad_lbl.Location = new Point(146, 53);
            kullanici_ad_lbl.Name = "kullanici_ad_lbl";
            kullanici_ad_lbl.Size = new Size(115, 20);
            kullanici_ad_lbl.TabIndex = 0;
            kullanici_ad_lbl.Text = "Kullanıcı Adınız ";
            // 
            // telno_lbl
            // 
            telno_lbl.AutoSize = true;
            telno_lbl.Location = new Point(146, 113);
            telno_lbl.Name = "telno_lbl";
            telno_lbl.Size = new Size(134, 20);
            telno_lbl.TabIndex = 0;
            telno_lbl.Text = "Telefon Numaranız";
            // 
            // babasoniki_lbl
            // 
            babasoniki_lbl.AutoSize = true;
            babasoniki_lbl.Location = new Point(146, 173);
            babasoniki_lbl.Name = "babasoniki_lbl";
            babasoniki_lbl.Size = new Size(159, 20);
            babasoniki_lbl.TabIndex = 0;
            babasoniki_lbl.Text = "Babanızın Son İki Harfi";
            // 
            // kullanici_ad
            // 
            kullanici_ad.Location = new Point(405, 50);
            kullanici_ad.Name = "kullanici_ad";
            kullanici_ad.Size = new Size(263, 27);
            kullanici_ad.TabIndex = 1;
            kullanici_ad.KeyPress += kullanici_ad_KeyPress;
            // 
            // tel_no
            // 
            tel_no.Location = new Point(405, 110);
            tel_no.Name = "tel_no";
            tel_no.Size = new Size(263, 27);
            tel_no.TabIndex = 2;
            // 
            // baba_soniki
            // 
            baba_soniki.Location = new Point(405, 166);
            baba_soniki.Name = "baba_soniki";
            baba_soniki.Size = new Size(263, 27);
            baba_soniki.TabIndex = 2;
            baba_soniki.KeyPress += kullanici_ad_KeyPress;
            // 
            // devam
            // 
            devam.Location = new Point(405, 278);
            devam.Name = "devam";
            devam.Size = new Size(108, 45);
            devam.TabIndex = 3;
            devam.Text = "DEVAM ET";
            devam.UseVisualStyleBackColor = true;
            devam.Click += devam_Click;
            // 
            // geri
            // 
            geri.Location = new Point(560, 278);
            geri.Name = "geri";
            geri.Size = new Size(108, 45);
            geri.TabIndex = 3;
            geri.Text = "GERİ";
            geri.UseVisualStyleBackColor = true;
            geri.Click += geri_Click;
            // 
            // YoneticiSifreUnutma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 373);
            Controls.Add(geri);
            Controls.Add(devam);
            Controls.Add(baba_soniki);
            Controls.Add(tel_no);
            Controls.Add(kullanici_ad);
            Controls.Add(babasoniki_lbl);
            Controls.Add(telno_lbl);
            Controls.Add(kullanici_ad_lbl);
            Name = "YoneticiSifreUnutma";
            Text = "Yönetici Şifre Değiştrime Ekranı - 1";
            Load += YoneticiSifreUnutma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullanici_ad_lbl;
        private Label telno_lbl;
        private Label babasoniki_lbl;
        private TextBox kullanici_ad;
        private MaskedTextBox tel_no;
        private MaskedTextBox baba_soniki;
        private Button devam;
        private Button geri;
    }
}