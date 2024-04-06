namespace kütüphane_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            k_sifregoster = new Button();
            k_cikis = new Button();
            k_giris = new Button();
            üye_ol = new LinkLabel();
            label3 = new Label();
            k_sifreunut = new LinkLabel();
            k_sifre = new TextBox();
            k_kullaniciad = new TextBox();
            k_kullaniciad_lbl = new Label();
            k_sifre_lbl = new Label();
            tabPage2 = new TabPage();
            y_sifregoster = new Button();
            y_cikis = new Button();
            y_giris = new Button();
            y_sifreunut = new LinkLabel();
            y_sifre = new TextBox();
            y_kullaniciad = new TextBox();
            y_kullaniciad_lbl = new Label();
            y_sifre_lbl = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(740, 314);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(k_sifregoster);
            tabPage1.Controls.Add(k_cikis);
            tabPage1.Controls.Add(k_giris);
            tabPage1.Controls.Add(üye_ol);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(k_sifreunut);
            tabPage1.Controls.Add(k_sifre);
            tabPage1.Controls.Add(k_kullaniciad);
            tabPage1.Controls.Add(k_kullaniciad_lbl);
            tabPage1.Controls.Add(k_sifre_lbl);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(732, 281);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "                                     Kullanıcı Girişi                                  ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // k_sifregoster
            // 
            k_sifregoster.Font = new Font("Segoe UI", 8F);
            k_sifregoster.Location = new Point(648, 94);
            k_sifregoster.Name = "k_sifregoster";
            k_sifregoster.Size = new Size(78, 29);
            k_sifregoster.TabIndex = 6;
            k_sifregoster.Text = "Göster";
            k_sifregoster.UseVisualStyleBackColor = true;
            k_sifregoster.Click += k_sifregoster_Click;
            // 
            // k_cikis
            // 
            k_cikis.Location = new Point(503, 166);
            k_cikis.Name = "k_cikis";
            k_cikis.Size = new Size(102, 38);
            k_cikis.TabIndex = 5;
            k_cikis.Text = "ÇIKIŞ";
            k_cikis.UseVisualStyleBackColor = true;
            k_cikis.Click += k_cikis_Click;
            // 
            // k_giris
            // 
            k_giris.Location = new Point(300, 166);
            k_giris.Name = "k_giris";
            k_giris.Size = new Size(102, 38);
            k_giris.TabIndex = 5;
            k_giris.Text = "GİRİŞ";
            k_giris.UseVisualStyleBackColor = true;
            k_giris.Click += k_giris_Click;
            // 
            // üye_ol
            // 
            üye_ol.AutoSize = true;
            üye_ol.Location = new Point(589, 246);
            üye_ol.Name = "üye_ol";
            üye_ol.Size = new Size(53, 20);
            üye_ol.TabIndex = 4;
            üye_ol.TabStop = true;
            üye_ol.Text = "Üye Ol";
            üye_ol.LinkClicked += üye_ol_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(571, 246);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 3;
            label3.Text = "/";
            // 
            // k_sifreunut
            // 
            k_sifreunut.AutoSize = true;
            k_sifreunut.Location = new Point(452, 246);
            k_sifreunut.Name = "k_sifreunut";
            k_sifreunut.Size = new Size(117, 20);
            k_sifreunut.TabIndex = 2;
            k_sifreunut.TabStop = true;
            k_sifreunut.Text = "Şifremi Unuttum";
            k_sifreunut.LinkClicked += k_sifreunut_LinkClicked;
            // 
            // k_sifre
            // 
            k_sifre.Location = new Point(264, 95);
            k_sifre.Name = "k_sifre";
            k_sifre.Size = new Size(378, 27);
            k_sifre.TabIndex = 1;
            k_sifre.KeyPress += k_sifre_KeyPress;
            // 
            // k_kullaniciad
            // 
            k_kullaniciad.Location = new Point(264, 28);
            k_kullaniciad.Name = "k_kullaniciad";
            k_kullaniciad.Size = new Size(378, 27);
            k_kullaniciad.TabIndex = 1;
            k_kullaniciad.KeyPress += k_sifre_KeyPress;
            // 
            // k_kullaniciad_lbl
            // 
            k_kullaniciad_lbl.AutoSize = true;
            k_kullaniciad_lbl.Location = new Point(74, 31);
            k_kullaniciad_lbl.Name = "k_kullaniciad_lbl";
            k_kullaniciad_lbl.Size = new Size(92, 20);
            k_kullaniciad_lbl.TabIndex = 0;
            k_kullaniciad_lbl.Text = "Kullanıcı Adı";
            // 
            // k_sifre_lbl
            // 
            k_sifre_lbl.AutoSize = true;
            k_sifre_lbl.Location = new Point(74, 98);
            k_sifre_lbl.Name = "k_sifre_lbl";
            k_sifre_lbl.Size = new Size(39, 20);
            k_sifre_lbl.TabIndex = 0;
            k_sifre_lbl.Text = "Şifre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(y_sifregoster);
            tabPage2.Controls.Add(y_cikis);
            tabPage2.Controls.Add(y_giris);
            tabPage2.Controls.Add(y_sifreunut);
            tabPage2.Controls.Add(y_sifre);
            tabPage2.Controls.Add(y_kullaniciad);
            tabPage2.Controls.Add(y_kullaniciad_lbl);
            tabPage2.Controls.Add(y_sifre_lbl);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(732, 281);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "                         Yönetici Girişi                                    ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // y_sifregoster
            // 
            y_sifregoster.Font = new Font("Segoe UI", 8F);
            y_sifregoster.Location = new Point(648, 94);
            y_sifregoster.Name = "y_sifregoster";
            y_sifregoster.Size = new Size(78, 29);
            y_sifregoster.TabIndex = 15;
            y_sifregoster.Text = "Göster";
            y_sifregoster.UseVisualStyleBackColor = true;
            y_sifregoster.Click += y_sifregoster_Click;
            // 
            // y_cikis
            // 
            y_cikis.Location = new Point(503, 166);
            y_cikis.Name = "y_cikis";
            y_cikis.Size = new Size(102, 38);
            y_cikis.TabIndex = 13;
            y_cikis.Text = "ÇIKIŞ";
            y_cikis.UseVisualStyleBackColor = true;
            y_cikis.Click += k_cikis_Click;
            // 
            // y_giris
            // 
            y_giris.Location = new Point(300, 166);
            y_giris.Name = "y_giris";
            y_giris.Size = new Size(102, 38);
            y_giris.TabIndex = 14;
            y_giris.Text = "GİRİŞ";
            y_giris.UseVisualStyleBackColor = true;
            y_giris.Click += y_giris_Click;
            // 
            // y_sifreunut
            // 
            y_sifreunut.AutoSize = true;
            y_sifreunut.Location = new Point(525, 246);
            y_sifreunut.Name = "y_sifreunut";
            y_sifreunut.Size = new Size(117, 20);
            y_sifreunut.TabIndex = 10;
            y_sifreunut.TabStop = true;
            y_sifreunut.Text = "Şifremi Unuttum";
            y_sifreunut.LinkClicked += y_sifreunut_LinkClicked;
            // 
            // y_sifre
            // 
            y_sifre.Location = new Point(264, 95);
            y_sifre.Name = "y_sifre";
            y_sifre.Size = new Size(378, 27);
            y_sifre.TabIndex = 8;
            y_sifre.KeyPress += k_sifre_KeyPress;
            // 
            // y_kullaniciad
            // 
            y_kullaniciad.Location = new Point(264, 28);
            y_kullaniciad.Name = "y_kullaniciad";
            y_kullaniciad.Size = new Size(378, 27);
            y_kullaniciad.TabIndex = 9;
            y_kullaniciad.KeyPress += k_sifre_KeyPress;
            // 
            // y_kullaniciad_lbl
            // 
            y_kullaniciad_lbl.AutoSize = true;
            y_kullaniciad_lbl.Location = new Point(74, 31);
            y_kullaniciad_lbl.Name = "y_kullaniciad_lbl";
            y_kullaniciad_lbl.Size = new Size(92, 20);
            y_kullaniciad_lbl.TabIndex = 6;
            y_kullaniciad_lbl.Text = "Kullanıcı Adı";
            // 
            // y_sifre_lbl
            // 
            y_sifre_lbl.AutoSize = true;
            y_sifre_lbl.Location = new Point(74, 98);
            y_sifre_lbl.Name = "y_sifre_lbl";
            y_sifre_lbl.Size = new Size(39, 20);
            y_sifre_lbl.TabIndex = 7;
            y_sifre_lbl.Text = "Şifre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 314);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Kütüphane Giriş Ekranı";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel k_sifreunut;
        private TextBox k_sifre;
        private TextBox k_kullaniciad;
        private Label k_kullaniciad_lbl;
        private Label k_sifre_lbl;
        private Button k_cikis;
        private Button k_giris;
        private LinkLabel üye_ol;
        private Label label3;
        private Button y_cikis;
        private Button y_giris;
        private LinkLabel y_sifreunut;
        private TextBox y_sifre;
        private TextBox y_kullaniciad;
        private Label y_kullaniciad_lbl;
        private Label y_sifre_lbl;
        private Button k_sifregoster;
        private Button y_sifregoster;
        public TabPage tabPage2;
        public TabControl tabControl;
        public TabPage tabPage1;
    }
}