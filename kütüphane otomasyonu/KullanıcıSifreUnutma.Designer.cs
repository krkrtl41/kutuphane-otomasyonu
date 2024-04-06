namespace kütüphane_otomasyonu
{
    partial class KullanıcıSifreUnutma
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
            kullaniciad_lbl = new Label();
            telno_lbl = new Label();
            babasoniki_lbl = new Label();
            k_kullaniciad = new TextBox();
            k_telno = new MaskedTextBox();
            k_babanınsonikiharf = new MaskedTextBox();
            devam = new Button();
            geri = new Button();
            SuspendLayout();
            // 
            // kullaniciad_lbl
            // 
            kullaniciad_lbl.AutoSize = true;
            kullaniciad_lbl.Location = new Point(83, 97);
            kullaniciad_lbl.Name = "kullaniciad_lbl";
            kullaniciad_lbl.Size = new Size(92, 20);
            kullaniciad_lbl.TabIndex = 0;
            kullaniciad_lbl.Text = "Kullanıcı Adı";
            // 
            // telno_lbl
            // 
            telno_lbl.AutoSize = true;
            telno_lbl.Location = new Point(83, 156);
            telno_lbl.Name = "telno_lbl";
            telno_lbl.Size = new Size(125, 20);
            telno_lbl.TabIndex = 1;
            telno_lbl.Text = "Telefon Numarası";
            // 
            // babasoniki_lbl
            // 
            babasoniki_lbl.AutoSize = true;
            babasoniki_lbl.Location = new Point(83, 211);
            babasoniki_lbl.Name = "babasoniki_lbl";
            babasoniki_lbl.Size = new Size(195, 20);
            babasoniki_lbl.TabIndex = 2;
            babasoniki_lbl.Text = "Babanın Adının Son İki Harfi";
            // 
            // k_kullaniciad
            // 
            k_kullaniciad.Location = new Point(358, 94);
            k_kullaniciad.Name = "k_kullaniciad";
            k_kullaniciad.Size = new Size(285, 27);
            k_kullaniciad.TabIndex = 3;
            // 
            // k_telno
            // 
            k_telno.Location = new Point(358, 153);
            k_telno.Name = "k_telno";
            k_telno.Size = new Size(285, 27);
            k_telno.TabIndex = 4;
            k_telno.MaskInputRejected += k_telno_MaskInputRejected;
            // 
            // k_babanınsonikiharf
            // 
            k_babanınsonikiharf.Location = new Point(358, 208);
            k_babanınsonikiharf.Name = "k_babanınsonikiharf";
            k_babanınsonikiharf.Size = new Size(285, 27);
            k_babanınsonikiharf.TabIndex = 4;
            k_babanınsonikiharf.MaskInputRejected += k_babanınsonikiharf_MaskInputRejected;
            // 
            // devam
            // 
            devam.Location = new Point(358, 284);
            devam.Name = "devam";
            devam.Size = new Size(104, 48);
            devam.TabIndex = 5;
            devam.Text = "DEVAM ET";
            devam.UseVisualStyleBackColor = true;
            devam.Click += devam_Click;
            // 
            // geri
            // 
            geri.Location = new Point(539, 284);
            geri.Name = "geri";
            geri.Size = new Size(104, 48);
            geri.TabIndex = 6;
            geri.Text = "GERİ";
            geri.UseVisualStyleBackColor = true;
            geri.Click += geri_Click;
            // 
            // KullanıcıSifreUnutma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 478);
            Controls.Add(geri);
            Controls.Add(devam);
            Controls.Add(k_babanınsonikiharf);
            Controls.Add(k_telno);
            Controls.Add(k_kullaniciad);
            Controls.Add(babasoniki_lbl);
            Controls.Add(telno_lbl);
            Controls.Add(kullaniciad_lbl);
            Name = "KullanıcıSifreUnutma";
            Text = "Şifre Değiştirme Ekranı - 1";
            Load += KullanıcıSifreUnutma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullaniciad_lbl;
        private Label telno_lbl;
        private Label babasoniki_lbl;
        private TextBox k_kullaniciad;
        private MaskedTextBox k_telno;
        private MaskedTextBox k_babanınsonikiharf;
        private Button devam;
        private Button geri;
    }
}