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
    public partial class KullanıcıSifreDegistirme : Form
    {
        private int sifre_oluru;
        public string kullanici_ad;
        public OleDbConnection baglanti;
        public KullanıcıSifreDegistirme()
        {
            InitializeComponent();
        }

        private void KullanıcıSifreDegistirme_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            ilerleme_cubugu.Minimum = 0;
            ilerleme_cubugu.Maximum = 10;
            ilerleme_cubugu.Dock = DockStyle.None;
            ilerleme_cubugu.Style = ProgressBarStyle.Blocks;
        }
        private void parola_TextChanged(object sender, EventArgs e)
        {
            ilerleme_cubugu.Value = parola.TextLength;
            if (parola.Text.Trim().Length < 6 && parola.Text.Trim() != parola_tekrar.Text.Trim())
            {
                sifre_durum.Text = "Zayıf - Parolalar uyuşmuyor.";
                sifre_durum.ForeColor = Color.Red;
            }
            else if (parola.Text.Trim().Length >= 6 && parola.Text.Trim() != parola_tekrar.Text.Trim())
            {
                sifre_durum.Text = "Parolalar uyuşmuyor.";
                sifre_durum.ForeColor = Color.Red;
            }
            else if (parola.Text.Trim().Length < 6 && parola.Text.Trim() == parola_tekrar.Text.Trim())
            {
                sifre_durum.Text = "Zayıf";
                sifre_durum.ForeColor = Color.Red;
            }
            else if (parola.Text.Trim().Length >= 6 && parola.Text.Trim() == parola_tekrar.Text.Trim())
            {
                sifre_durum.Text = "Güçlü";
                sifre_durum.ForeColor = Color.Green;
            }
        }
        private void parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$";
            if (!Regex.IsMatch(parola.Text, pattern))
                sifre_oluru = 0;
            else
                sifre_oluru = 1;

            if (sifre_oluru == 0 || parola.Text.Trim().Length < 6 || parola.Text != parola_tekrar.Text)
            {
                parola_lbl.ForeColor = Color.Red;
                parolatekrar_lbl.ForeColor = Color.Red;
                MessageBox.Show("Şifrelerin karakter uyumunu sağladığından, minimum 6 karakter içerdiğinden ve birbirleriyle aynı olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                OleDbCommand guncelle = new OleDbCommand("UPDATE kullanicilar SET parola = '" + parola.Text.Trim() + "' WHERE kullanici_ad = '" + kullanici_ad + "'", baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                parola_lbl.ForeColor = Color.Black;
                parolatekrar_lbl.ForeColor = Color.Black;
                MessageBox.Show(kullanici_ad + " numaralı kullanıcının bilgileri güncellendi." + "\n" + "Yeni şifre : " + parola.Text.Trim(), "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f1 = new Form1();
                this.Hide();
                f1.tabControl.SelectedTab = f1.tabPage1;
                f1.ShowDialog();

            }
        }

        private void giris_ekranı_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Ana ekrana yönlendiriliyorsunuz. Kabul ediyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == sonuc)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.tabControl.SelectedTab = f1.tabPage1;
                f1.ShowDialog();
            }
        }


    }
}
