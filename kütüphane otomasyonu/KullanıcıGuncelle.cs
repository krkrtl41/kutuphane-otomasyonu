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
    public partial class KullanıcıGuncelle : Form
    {
        public string kullanan_ad;
        public OleDbConnection baglanti;
        public KullanıcıGuncelle()
        {
            InitializeComponent();
        }

        private void KullanıcıGuncelle_Load(object sender, EventArgs e)
        {
            parola.MaxLength = 10;
            parola_tekrar.MaxLength = 10;

            this.CenterToParent();
            this.ControlBox = false;

            kullanici_ad.Text = kullanan_ad;

            tel_no.Mask = "(999) 000-0000";
            tel_no.PromptChar = '_';
            tel_no.BeepOnError = false;

            baba_soniki.Mask = "??";
            baba_soniki.PasswordChar = '\0';
            baba_soniki.PromptChar = '_';
            baba_soniki.BeepOnError = false;

            ilerleme_cubugu.Minimum = 0;
            ilerleme_cubugu.Maximum = 10;
            ilerleme_cubugu.Dock = DockStyle.None;
            ilerleme_cubugu.Style = ProgressBarStyle.Blocks;

            tel_no.Enabled = false;
            parola.Enabled = false;
            parola_tekrar.Enabled = false;
            baba_soniki.Enabled = false;

            parola.UseSystemPasswordChar = true;
            parola_tekrar.UseSystemPasswordChar = true;
        }
        private void parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void parola_TextChanged(object sender, EventArgs e)
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

        private void telno_check_CheckedChanged(object sender, EventArgs e)
        {
            if (telno_check.Checked == true)
                tel_no.Enabled = true;
            else
                tel_no.Enabled = false;

            if (parola_check.Checked == true)
            {
                parola.Enabled = true;
                parola_tekrar.Enabled = true;
            }
            else
            {
                parola.Enabled = false;
                parola_tekrar.Enabled = false;
            }

            if (babasoniki_check.Checked == true)
                baba_soniki.Enabled = true;
            else
                baba_soniki.Enabled = false;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            int sifre_oluru;
            string pattern = "^(?=.*[a-z])(?=.*\\d)(?=.*[A-Z]).+$";
            if (!Regex.IsMatch(parola.Text, pattern))
                sifre_oluru = 0;
            else
                sifre_oluru = 1;

            if ((telno_check.Checked == true && tel_no.Text.Trim().Length != 14) || (parola_check.Checked == true && (sifre_oluru == 0 || parola.Text.Length < 6 || parola.Text != parola_tekrar.Text)) || (babasoniki_check.Checked == true && baba_soniki.Text.Trim().Length != 2))
                MessageBox.Show("Seçili olan bilgileri doğru ve eksiksiz bir şekilde doldurduğunuzdan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar WHERE not kullanici_ad = '" + kullanan_ad + "'", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (tel_no.Text == (string)okuma["telefon_no"])
                        sayac++;
                }
                baglanti.Close();

                if (telno_check.Checked == true && sayac != 0)
                    MessageBox.Show("Bu telefon numarası başka bir kullanıcıya aittir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (telno_check.Checked == true)
                        Kaydetme(tel_no.Text, "telefon_no");

                    if (parola_check.Checked == true)
                        Kaydetme(parola.Text, "parola");

                    if (babasoniki_check.Checked == true)
                        Kaydetme(baba_soniki.Text, "baba_sonharfler");

                    telno_check.Checked = false;
                    parola_check.Checked = false;
                    babasoniki_check.Checked = false;
                    tel_no.Clear();
                    parola.Clear();
                    parola_tekrar.Clear();
                    baba_soniki.Clear();
                    MessageBox.Show("'" + kullanan_ad + "' kullanıcı adlı kişinin bilgileri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Kaydetme(string duzenlenecek_bilgi, string duzenlenecek_yer)
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand("UPDATE kullanicilar SET " + duzenlenecek_yer + " = '" + duzenlenecek_bilgi + "' WHERE kullanici_ad = '" + kullanan_ad + "'", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void tel_no_TextChanged(object sender, EventArgs e)
        {
            if (telno_check.Checked == true)
            {
                for (int a = 0; a < 14; a++)
                {
                    char karakter = tel_no.Text[a];
                    if (karakter == ' ')
                    {
                        for (int b = a; b < 14; b++)
                        {
                            char harf = tel_no.Text[b];
                            if (harf != ' ')
                            {
                                tel_no.Text.Insert(a, harf.ToString());
                                tel_no.Text.Remove(b, 1);
                                break;
                            }

                        }
                    }

                }
            }
           
        }
    }
}
