using System.Data.OleDb;

namespace kütüphane_otomasyonu
{
    public partial class Form1 : Form
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Hp\\Documents\\kutuphane.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            k_sifre.UseSystemPasswordChar = true;
            y_sifre.UseSystemPasswordChar = true;
        }

        private void k_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void k_giris_Click(object sender, EventArgs e)
        {
            if (k_kullaniciad.Text.Trim() == "" || k_sifre.Text.Trim() == "")
            {
                Sorgula();
                MessageBox.Show("Bütün bölümlerin doldurulduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar WHERE pozisyon = 'Kullanıcı'", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (k_kullaniciad.Text.Trim() == (string)okuma["kullanici_ad"] && k_sifre.Text.Trim() == (string)okuma["parola"])
                        sayac++;
                }
                baglanti.Close();
                if (sayac == 0)
                {
                    Sorgula();
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı." + "\n" + "Kullanıcı adının ve şifrenin doğru girildiğinden emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    KullanıcıEkranı ekran = new();
                    ekran.kullanici_ad = k_kullaniciad.Text;
                    ekran.baglanti = this.baglanti;
                    this.Hide();
                    ekran.ShowDialog();
                }
            }
        }
        private void k_sifregoster_Click(object sender, EventArgs e)
        {
            if (k_sifre.UseSystemPasswordChar == true)
            {
                k_sifre.UseSystemPasswordChar = false;
                k_sifregoster.Text = "Gösterme";
            }
            else
            {
                k_sifre.UseSystemPasswordChar = true;
                k_sifregoster.Text = "Göster";
            }
        }

        private void k_sifreunut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullanıcıSifreUnutma unutma = new();
            unutma.baglanti = this.baglanti;
            this.Hide();
            unutma.ShowDialog();
        }

        private void üye_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullanıcıUyeOlma uye_ol = new();
            uye_ol.baglantim = this.baglanti;
            this.Hide();
            uye_ol.ShowDialog();
        }
        private void Sorgula()
        {
            if (k_kullaniciad.Text.Trim() == "")
                k_kullaniciad_lbl.ForeColor = Color.Red;
            else
                k_kullaniciad_lbl.ForeColor = Color.Black;

            if (k_sifre.Text.Trim() == "")
                k_sifre_lbl.ForeColor = Color.Red;
            else
                k_sifre_lbl.ForeColor = Color.Black;
        }

        private void y_sifregoster_Click(object sender, EventArgs e)
        {
            if (y_sifre.UseSystemPasswordChar == true)
            {
                y_sifre.UseSystemPasswordChar = false;
                y_sifregoster.Text = "Gösterme";
            }
            else
            {
                y_sifre.UseSystemPasswordChar = true;
                y_sifregoster.Text = "Göster";
            }
        }
        private void YoneticiSorgula()
        {
            if (y_kullaniciad.Text.Length == 0)
                y_kullaniciad_lbl.ForeColor = Color.Red;
            else
                y_kullaniciad_lbl.ForeColor = Color.Black;

            if (y_sifre.Text.Length == 0)
                y_sifre_lbl.ForeColor = Color.Red;
            else
                y_sifre_lbl.ForeColor = Color.Black;
        }

        private void k_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }

        private void y_giris_Click(object sender, EventArgs e)
        {
            if (y_kullaniciad.Text.Length == 0 || y_sifre.Text.Length == 0)
            {
                YoneticiSorgula();
                MessageBox.Show("Bütün bölümlerin doldurulduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar WHERE pozisyon = 'Yönetici'", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (y_kullaniciad.Text == (string)okuma["kullanici_ad"] && y_sifre.Text == (string)okuma["parola"])
                        sayac++;
                }
                baglanti.Close();
                if (sayac == 0)
                {
                    YoneticiSorgula();
                    MessageBox.Show("Böyle bir yönetici bulunmamaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    YoneticiEkranı ekran = new();
                    ekran.yonetici_ad = this.y_kullaniciad.Text;
                    ekran.baglanti = this.baglanti;
                    this.Hide();
                    ekran.ShowDialog();
                }
            }
        }
        private void y_sifreunut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YoneticiSifreUnutma unutma = new();
            unutma.baglanti = this.baglanti;
            this.Hide();
            unutma.ShowDialog();
        }
    }
}