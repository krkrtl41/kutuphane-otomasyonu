using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyonu
{
    public partial class KullanıcıEkranı : Form
    {
        public OleDbConnection baglanti;
        public string kullanici_ad;
        public int sifre_oluru;
        public int kiralanan_kitap_adedi;
        public KullanıcıEkranı()
        {
            InitializeComponent();
        }

        private void KullanıcıEkranı_Load(object sender, EventArgs e)
        {
            Listele();
            KiralıkKitapListele();
            BilgiGetir();
            this.CenterToParent();

            kitap_vt.Columns[0].Width = 200;
            kitap_vt.Columns[1].Width = 150;
            kitap_vt.Columns[2].Width = 170;
            resim_kutusu.SizeMode = PictureBoxSizeMode.Zoom;

            kiralanan_kitap_vt.Columns[0].Width = 200;
            kiralanan_kitap_vt.Columns[1].Width = 150;

            parola.UseSystemPasswordChar = true;
            parola_tekrar.UseSystemPasswordChar = true;

            tel_no.Mask = "(999) 000-0000";
            tel_no.PasswordChar = '\0';
            tel_no.PromptChar = '_';
            tel_no.BeepOnError = false;

            baba_soniki.Mask = "??";
            baba_soniki.PasswordChar = '\0';
            baba_soniki.PromptChar = '_';
            baba_soniki.BeepOnError = false;

            kitap_vt.MultiSelect = false;
            kiralanan_kitap_vt.MultiSelect = false;

            tel_no.Enabled = false;
            baba_soniki.Enabled = false;
            parola.Enabled = false;
            parola_tekrar.Enabled = false;

            parola.MaxLength = 10;
            parola_tekrar.MaxLength = 10;

            ilerleme_cubugu.Minimum = 0;
            ilerleme_cubugu.Maximum = 10;
            ilerleme_cubugu.Dock = DockStyle.None;
            ilerleme_cubugu.Style = ProgressBarStyle.Blocks;

        }
        private void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new OleDbDataAdapter("SELECT ad, yazar, türü, sayfa_sayisi, cikis_tarih FROM kitaplar ORDER BY ad ASC", baglanti);
            DataSet ds = new();
            listele.Fill(ds);
            kitap_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void KiralıkKitapListele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new OleDbDataAdapter("SELECT ad, yazar, sayfa_sayisi, kiralama_tarih, getirme_tarih FROM kitaplar WHERE kiralayan = '" + kullanici_ad + "'", baglanti);
            DataSet ds = new();
            listele.Fill(ds);
            kiralanan_kitap_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void kitap_arama_TextChanged(object sender, EventArgs e)
        {
            if (kitap_arama.Text.Trim().Length == 0)
            {
                Listele();
            }
            else
            {
                baglanti.Open();
                OleDbDataAdapter arama = new("SELECT ad, yazar, türü, sayfa_sayisi, cikis_tarih FROM kitaplar WHERE ad LIKE '" + kitap_arama.Text + "%' ORDER BY ad ASC", baglanti);
                DataSet ds = new();
                arama.Fill(ds);
                kitap_vt.DataSource = ds.Tables[0];
                baglanti.Close();
            }

        }

        private void kitap_vt_SelectionChanged(object sender, EventArgs e)
        {
            if (kitap_vt.SelectedRows.Count == 0)
            {
                kitap_ad.Clear();
                yazar.Clear();
                turu.Clear();
                cikis_tarihi.Clear();
                sayfa_sayisi.Clear();
                eklenme_tarihi.Clear();
                kiralanabilir.Checked = false;
                kiralanamaz.Checked = false;
                aciklama.Clear();
                resim_kutusu.Image = null;
            }
            else
            {
                string deger = (string)kitap_vt.SelectedRows[0].Cells[0].Value;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kitaplar WHERE ad = '" + deger + "'", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    kitap_ad.Text = deger;
                    yazar.Text = (string)okuma["yazar"];
                    turu.Text = (string)okuma["türü"];
                    cikis_tarihi.Text = (string)okuma["cikis_tarih"];
                    sayfa_sayisi.Text = (string)okuma["sayfa_sayisi"];
                    eklenme_tarihi.Text = (string)okuma["eklenme_tarih"];
                    if ((string)okuma["kiralık"] == "Evet")
                        kiralanabilir.Checked = true;
                    else
                        kiralanamaz.Checked = true;
                    aciklama.Text = (string)okuma["acıklama"];
                    string foto = @"C:\Kitap Fotoğrafları\" + deger + ".jpeg";
                    resim_kutusu.Load(foto);
                }
                baglanti.Close();
            }
        }

        private void kirala_Click(object sender, EventArgs e)
        {
            int kiralık_sayac = 0;
            baglanti.Open();
            OleDbCommand arama_1 = new OleDbCommand("SELECT * FROM kitaplar", baglanti);
            OleDbDataReader okuma_1 = arama_1.ExecuteReader();
            while (okuma_1.Read())
            {
                if (kullanici_ad == (string)okuma_1["kiralayan"])
                    kiralık_sayac++;
            }
            baglanti.Close();
            if (kiralık_sayac == 5)
            {
                MessageBox.Show("Maksimum kitap kiralama adedine ulaştınız. Kitap kiralamak için elinizdeki kitapları geri vermeniz gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (kitap_vt.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Kiralamak istediğiniz kitabı listeden seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int sayac = 0;
                    string book_name = (string)kitap_vt.SelectedRows[0].Cells[0].Value;
                    baglanti.Open();
                    OleDbCommand arama = new OleDbCommand("SELECT kiralık FROM kitaplar WHERE ad = '" + book_name + "'", baglanti);
                    OleDbDataReader okuma = arama.ExecuteReader();
                    while (okuma.Read())
                    {
                        if ((string)okuma["kiralık"] == "Evet")
                        {
                            sayac++;
                        }
                    }
                    baglanti.Close();
                    if (sayac == 0)
                    {
                        MessageBox.Show("Bu kitap kıralık durumda değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DateTime bugun = DateTime.Today;
                        DateTime geri_getirme = bugun.AddDays(30);

                        DialogResult sonuc = MessageBox.Show(book_name + " adlı kitabı " + bugun.ToShortDateString() + " tarihinden " + geri_getirme.ToShortDateString() + " tarihine kadar kiralamak istiyorsunuz." + "\n" + "Belirtilen tarihe kadar geri getirilmezse hakkınızda yasal işlemler başlatılacaktır." + "\n" + "Onaylıyor musunuz?", "KİRALAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (sonuc == DialogResult.Yes)
                        {
                            baglanti.Open();
                            OleDbCommand kitaplar_guncelleme = new("UPDATE kitaplar SET kiralayan = '" + kullanici_ad + "', kiralama_tarih = '" + bugun.ToShortDateString() + "', getirme_tarih = '" + geri_getirme.ToShortDateString() + "', kiralık = 'Hayır' WHERE ad = '" + book_name + "'", baglanti);
                            kitaplar_guncelleme.ExecuteNonQuery();
                            baglanti.Close();
                            Listele();

                            KiralıkKitapListele();
                            MessageBox.Show("Kitabınız sizin üzerinize kiralanmıştır. Kitabınızı kütüphaneden gidip alabilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
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
                parolatekrar_goster.Text = "Gösterme";
            }
        }

        private void kiralanan_kitap_vt_SelectionChanged(object sender, EventArgs e)
        {
            if (kiralanan_kitap_vt.SelectedRows.Count != 0)
            {
                string kitabın_Adi = (string)kiralanan_kitap_vt.SelectedRows[0].Cells[0].Value;
                string dosya = @"C:\Kitap Fotoğrafları\" + kitabın_Adi + ".jpeg";
                kiralanan_resim.Load(dosya);
            }
            else
                kiralanan_resim.Image = null;
        }

        private void tel_check_CheckedChanged(object sender, EventArgs e)
        {
            if (tel_check.Checked == true)
                tel_no.Enabled = true;
            else
            {
                tel_no.Enabled = false;
                tel_no.Clear();
            }

            if (parola_check.Checked == true)
            {
                parola.Enabled = true;
                parola_tekrar.Enabled = true;
            }
            else
            {
                parola.Enabled = false;
                parola_tekrar.Enabled = false;
                ilerleme_cubugu.Value = 0;
                sifre_durumu.Text = "...";
                parola.Clear();
                parola_tekrar.Clear();
            }

            if (babasoniki_check.Checked == true)
                baba_soniki.Enabled = true;
            else
            {
                baba_soniki.Enabled = false;
                baba_soniki.Clear();
            }
        }
        private void BilgiGetir()
        {
            string cinsiyet = "";
            baglanti.Open();
            OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar WHERE kullanici_ad = '" + kullanici_ad + "'", baglanti);
            OleDbDataReader okuma = arama.ExecuteReader();
            while (okuma.Read())
            {
                ad.Text = (string)okuma["ad"];
                soyad.Text = (string)okuma["soyad"];
                dogum_tarih.Value = (DateTime)okuma["dogum_tarihi"];
                cinsiyet = (string)okuma["cinsiyet"];
                if (cinsiyet == "Erkek")
                    erkek.Checked = true;
                else
                    kadin.Checked = true;
            }
            baglanti.Close();
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
                sifre_durumu.Text = "Zayıf - Şifreler Uyuşmuyor";
                sifre_durumu.ForeColor = Color.Red;
            }
            else if (parola.Text.Length >= 6 && parola.Text != parola_tekrar.Text)
            {
                sifre_durumu.Text = "Şifreler uyuşmuyor";
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

        private void parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$";
            if (!Regex.IsMatch(parola.Text, pattern))
                sifre_oluru = 0;//olmaz
            else
                sifre_oluru = 1;//olur

            if (tel_check.Checked == false && babasoniki_check.Checked == false && parola_check.Checked == false)
                MessageBox.Show("Lütfen değişecek olan verileri seiçiniz ve düzenleyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if ((tel_check.Checked == true && tel_no.Text.Length != 14) || (babasoniki_check.Checked == true && baba_soniki.Text.Trim().Length != 2))
                MessageBox.Show("Bilgileri doğru ve eksiksiz şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (parola_check.Checked == true && (parola.Text.Length < 6 || parola.Text != parola_tekrar.Text || sifre_oluru == 0))
                MessageBox.Show("Bilgileri doğru ve eksiksiz şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                if (tel_check.Checked == true)
                {
                    string duzenlenecek_yer = "telefon_no";
                    Kaydet(duzenlenecek_yer, tel_no.Text);
                }

                if (parola_check.Checked == true)
                {
                    string duzenlenecek_yer = "parola";
                    Kaydet(duzenlenecek_yer, parola.Text);
                }

                if (babasoniki_check.Checked)
                {
                    string duzenlenecek_yer = "baba_sonharfler";
                    Kaydet(duzenlenecek_yer, baba_soniki.Text);
                }
                parola_check.Checked = false;
                tel_check.Checked = false;
                babasoniki_check.Checked = false;
                MessageBox.Show("Veriler başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void Kaydet(string duzenlenecek_yer, string duzenlenecek_bilgi)
        {
            baglanti.Open();
            OleDbCommand duzenle = new OleDbCommand("UPDATE kullanicilar SET " + duzenlenecek_yer + " = '" + duzenlenecek_bilgi + "' WHERE kullanici_ad = '" + kullanici_ad + "'", baglanti);
            duzenle.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
