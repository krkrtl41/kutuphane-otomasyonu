using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyonu
{
    public partial class YoneticiSifreDegistirme : Form
    {
        public OleDbConnection baglanti;
        public string kullanici_ad;
        public int sifre_oluru;
        public YoneticiSifreDegistirme()
        {
            InitializeComponent();
        }

        private void YoneticiSifreDegistirme_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            parola.UseSystemPasswordChar = true;
            parola_tekrar.UseSystemPasswordChar = true;

            ilerleme_cubugu.Minimum = 0;
            ilerleme_cubugu.Maximum = 10;
            ilerleme_cubugu.Dock = DockStyle.None;
            ilerleme_cubugu.Style = ProgressBarStyle.Blocks;
        }

        private void parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }

        private void parola_goster_Click(object sender, EventArgs e)
        {
            if (parola.UseSystemPasswordChar == true)
            {
                parola.UseSystemPasswordChar = false;
                parola_goster.Text = "Gösterme";
            }
            else
            {
                parola.UseSystemPasswordChar = true;
                parola_goster.Text = "Göster";
            }
        }

        private void parolatekrar_goster_Click(object sender, EventArgs e)
        {
            if (parola_tekrar.UseSystemPasswordChar == true)
            {
                parola_tekrar.UseSystemPasswordChar = false;
                parolatekrar_goster.Text = "Gösterme";
            }
            else
            {
                parola_tekrar.UseSystemPasswordChar = true;
                parolatekrar_goster.Text = "Göster";
            }
        }

        private void giris_ekranı_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Ana ekrana yönlendiriliyorsunuz. Kabul ediyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == sonuc)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.tabControl.SelectedTab = f1.tabPage2;
                f1.ShowDialog();
            }
        }

        public void parola_TextChanged(object sender, EventArgs e)
        {
            ilerleme_cubugu.Value = parola.Text.Length;
            if (parola.Text.Length == 0)
            {
                sifre_durumu.Text = "...";
                sifre_durumu.ForeColor = Color.Black;
            }
            else if (parola.Text.Length < 6 && parola.Text != parola_tekrar.Text)
            {
                sifre_durumu.Text = "Zayıf - Parolalar uyuşmuyor.";
                sifre_durumu.ForeColor = Color.Red;
            }
            else if (parola.Text.Length >= 6 && parola.Text != parola_tekrar.Text)
            {
                sifre_durumu.Text = "Parolalar uyuşmuyor.";
                sifre_durumu.ForeColor = Color.Red;
            }
            else if (parola.Text.Length < 6 && parola.Text == parola_tekrar.Text)
            {
                sifre_durumu.Text = "Zayıf";
                sifre_durumu.ForeColor = Color.Red;
            }
            else if (parola.Text.Length >= 6 && parola.Text == parola_tekrar.Text)
            {
                sifre_durumu.Text = "Güçlü";
                sifre_durumu.ForeColor = Color.Green;
            }
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$";
            if (!Regex.IsMatch(parola.Text, pattern))
                sifre_oluru = 0;//sifre olmaz
            else
                sifre_oluru = 1;

            if (sifre_oluru == 0 || parola.Text.Length < 6 || parola.Text != parola_tekrar.Text)
            {
                parola_lbl.ForeColor = Color.Red;
                parolatekrar_lbl.ForeColor = Color.Red;
                MessageBox.Show("Şifrelerin biribiriyle aynı olmasına, koşulları sağlamasına ve minimum 6 karakter içermesine dikkat ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                baglanti.Open();
                OleDbCommand guncelle = new OleDbCommand("UPDATE kullanicilar SET parola = '" + parola.Text + "' WHERE kullanici_ad = '" + kullanici_ad + "'", baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                parola_lbl.ForeColor = Color.Black;
                parolatekrar_lbl.ForeColor = Color.Black;
                MessageBox.Show("Şifre başarıyla güncellendi." + "\n" + "Yeni Şifreniz : " + parola.Text, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f1 = new();
                this.Hide();
                f1.tabControl.SelectedTab = f1.tabPage2;
                f1.ShowDialog();
            }
        }


    }
}
