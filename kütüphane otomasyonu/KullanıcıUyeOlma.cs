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
    public partial class KullanıcıUyeOlma : Form
    {
        public OleDbConnection baglantim;
        int sifre_oluru;
        int tarih_sayacı;
        public KullanıcıUyeOlma()
        {
            InitializeComponent();
        }

        private void KullanıcıUyeOlma_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            parola.UseSystemPasswordChar = true;
            parola_tekrar.UseSystemPasswordChar = true;

            ilerleme_cubugu.Minimum = 0;
            ilerleme_cubugu.Maximum = 10;
            ilerleme_cubugu.Dock = DockStyle.None;
            ilerleme_cubugu.Style = ProgressBarStyle.Blocks;

            tel_no.Mask = "(999) 000-0000";
            tel_no.PasswordChar = '\0';
            tel_no.PromptChar = '_';
            tel_no.BeepOnError = false;

            baba_soniki.Mask = "??";
            baba_soniki.PasswordChar = '\0';
            baba_soniki.PromptChar = '_';
            baba_soniki.BeepOnError = false;
        }
        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
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
        private void parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
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

        private void parola_TextChanged(object sender, EventArgs e)
        {
            ilerleme_cubugu.Value = parola.Text.Length;
            if (parola.Text.Length == 0)
            {
                sifre_durumu.Text = "...";
                sifre_durumu.BackColor = Color.Black;
            }
            else if (parola.Text.Length < 6 && parola.Text != parola_tekrar.Text)
            {
                sifre_durumu.Text = "Zayıf - Parolalar uyuşmuyor";
                sifre_durumu.ForeColor = Color.Red;
            }
            else if (parola.Text.Length >= 6 && parola.Text != parola_tekrar.Text)
            {
                sifre_durumu.Text = "Parolalar uyuşmuyor";
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
                sifre_oluru = 0;//şifre geçerli değil
            else
                sifre_oluru = 1;//sifre geçerli

            DateTime bugun = DateTime.Today;
            DateTime secili_tarih = dogum_tarihi.Value.AddYears(16);
            if (secili_tarih <= bugun)
                tarih_sayacı++;//16 yasından büyük

            if (ad.Text.Trim() == "" || soyad.Text.Trim() == "" || dogum_tarihi.Value == DateTime.Today || (erkek.Checked == false && kadin.Checked == false) || tel_no.Text.Trim().Length != 14 || kullanici_ad.Text.Trim() == "" || parola.Text.Trim() == "" || parola_tekrar.Text.Trim() == "" || baba_soniki.Text.Trim().Length != 2)
            {
                Sorgula();
                MessageBox.Show("Bütün bölümlerin doğru bir şekilde yapıldığından ve dolu olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sifre_oluru == 0 || parola.Text != parola_tekrar.Text || parola.Text.Length < 6)
            {
                Sorgula();
                MessageBox.Show("Bütün bölümlerin doğru bir şekilde yapıldığından ve dolu olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tarih_sayacı == 0)
            {
                Sorgula();
                MessageBox.Show("Bütün bölümlerin doğru bir şekilde yapıldığından ve dolu olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayac = 0;
                baglantim.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar", baglantim);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (kullanici_ad.Text.Trim() == (string)okuma["kullanici_ad"] || tel_no.Text == (string)okuma["telefon_no"])
                        sayac++;
                }
                baglantim.Close();
                if (sayac == 1)
                {
                    Sorgula();
                    MessageBox.Show("Böyle bir kullanıcı adı veya telefon numarası bulunmaktadır. Lütfen farklı bir kullanıcı adı veya telefon numarası giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string cinsiyet;
                    if (erkek.Checked == true)
                        cinsiyet = "Erkek";
                    else
                        cinsiyet = "Kadın";
                    baglantim.Open();
                    OleDbCommand ekleme = new("INSERT INTO kullanicilar VALUES ('" + ad.Text.Trim() + "', '" + soyad.Text.Trim() + "', '" + dogum_tarihi.Value.ToShortDateString() + "', '" + cinsiyet + "', '" + tel_no.Text + "', '" + kullanici_ad.Text.Trim() + "', '" + parola.Text + "', '" + baba_soniki.Text.ToUpper() + "', 'Kullanıcı')" , baglantim);
                    ekleme.ExecuteNonQuery();
                    baglantim.Close();

                    ad.Clear();
                    soyad.Clear();
                    dogum_tarihi.Value = DateTime.Today;
                    erkek.Checked = false;
                    kadin.Checked = false;
                    tel_no.Clear();
                    kullanici_ad.Clear();
                    parola.Clear();
                    parola_tekrar.Clear();
                    baba_soniki.Clear();
                    MessageBox.Show("Üyelik başarıyla eklenmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void Sorgula()
        {
            if (ad.Text.Trim() == "")
                ad_lbl.ForeColor = Color.Red;
            else
                ad_lbl.ForeColor = Color.Black;

            if (soyad.Text.Trim() == "")
                soyad_lbl.ForeColor = Color.Red;
            else
                soyad_lbl.ForeColor = Color.Black;

            if (dogum_tarihi.Value == DateTime.Today || tarih_sayacı == 0)
                dogum_lbl.ForeColor = Color.Red;
            else
                dogum_lbl.ForeColor = Color.Black;

            if (erkek.Checked == false && kadin.Checked == false)
                cinsiyet_lbl.ForeColor = Color.Red;
            else
                cinsiyet_lbl.ForeColor = Color.Black;

            if (tel_no.Text.Trim().Length != 14)
                telno_lbl.ForeColor = Color.Red;
            else
                telno_lbl.ForeColor = Color.Black;

            if (kullanici_ad.Text.Trim() == "")
                kullaniciad_lbl.ForeColor = Color.Red;
            else
                kullaniciad_lbl.ForeColor = Color.Black;

            if (baba_soniki.Text.Trim().Length != 2)
                babasoniki_lbl.ForeColor = Color.Red;
            else
                babasoniki_lbl.ForeColor = Color.Black;

            if (sifre_oluru == 0 || parola.Text != parola_tekrar.Text || parola.Text.Length < 6)
            {
                parola_lbl.ForeColor = Color.Red;
                parolatekrar_lbl.ForeColor = Color.Red;
            }
            else
            {
                parola_lbl.ForeColor = Color.Black;
                parolatekrar_lbl.ForeColor = Color.Black;
            }
        }


    }
}
