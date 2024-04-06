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
    public partial class YoneticiEkranı : Form
    {
        int dogum_oluru;
        int sifre_oluru;
        public OleDbConnection baglanti;
        public string yonetici_ad;
        public YoneticiEkranı()
        {
            InitializeComponent();
        }
        private void Sorgulat()
        {
            int sayac = 0;
            baglanti.Open();
            OleDbCommand arama = new OleDbCommand("SELECT * FROM kitaplar WHERE kiralık = 'Hayır'", baglanti);
            OleDbDataReader okuma = arama.ExecuteReader();
            while (okuma.Read())
            {
                string tarih = (string)okuma["getirme_tarih"];
                if (Convert.ToDateTime(tarih) < DateTime.Today)
                    sayac++;
            }
            baglanti.Close();
            if (sayac != 0)
                MessageBox.Show("Kitabı geri getirme süresi dolmuş bazı kullanıcılar var. Lütfen kontrol ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Sorgulat_2()
        {
            baglanti.Open();
            OleDbCommand duzenle = new OleDbCommand("UPDATE kitaplar SET durum = 'Doldu' WHERE CDate(getirme_tarih) < Date() and kiralık = 'Hayır'", baglanti);
            duzenle.ExecuteNonQuery();
            baglanti.Close();
        }
        private void YoneticiEkranı_Load(object sender, EventArgs e)
        {
            KayıtListele();
            KullaniciListele();
            KiralanacakListele();

            k_telno.Mask = "(999) 000-0000";
            k_telno.PasswordChar = '\0';
            k_telno.PromptChar = '_';
            k_telno.BeepOnError = false;

            k_babasoniki.Mask = "??";
            k_babasoniki.PasswordChar = '\0';
            k_babasoniki.PromptChar = '_';
            k_babasoniki.BeepOnError = false;

            k_parola.MaxLength = 10;
            k_parolatekrar.MaxLength = 10;

            k_ilerlemecubugu.Minimum = 0;
            k_ilerlemecubugu.Maximum = 10;
            k_ilerlemecubugu.Dock = DockStyle.None;
            k_ilerlemecubugu.Style = ProgressBarStyle.Blocks;

            kitaplar_vt.Columns[0].Width = 300;
            kitaplar_vt.Columns[1].Width = 250;
            kitaplar_vt.Columns[2].Width = 175;

            kullanici_vt.Columns[0].Width = 250;
            kullanici_vt.Columns[1].Width = 200;
            kullanici_vt.Columns[4].Width = 300;
            kullanici_vt.Columns[5].Width = 250;

            kiralanacak_vt.Columns[0].Width = 300;
            kiralanacak_vt.Columns[1].Width = 250;
            kiralanacak_vt.Columns[2].Width = 175;

            kitaplar_vt.AllowUserToAddRows = false;
            kullanici_vt.AllowUserToAddRows = false;
            kiralanacak_vt.AllowUserToAddRows = false;

            eklenme_tarihi.MaxDate = DateTime.Today;
            k_dogum.MaxDate = DateTime.Today;

            cikis_tarihi.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int a = 2023; a >= -500; a--)
            {
                cikis_tarihi.Items.Add(a.ToString());
            }

            durum.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] durumlar = { "Devam", "Doldu", "Yok" };
            durum.Items.AddRange(durumlar);

            this.WindowState = FormWindowState.Maximized;

            resim_kutusu.SizeMode = PictureBoxSizeMode.Zoom;

            dosya_acici.Title = "Resim seç";
            dosya_acici.FileName = "Bir resim seçiniz";
            dosya_acici.InitialDirectory = @"C:\Users\Hp\Pictures";
            dosya_acici.Filter = "(jpeg) Dosyaları|*.jpeg";

            k_parola.UseSystemPasswordChar = true;
            k_parolatekrar.UseSystemPasswordChar = true;

            kiralama_tarih.Value = DateTime.Today;
            gerigetirme_tarih.Value = kiralama_tarih.Value.AddDays(30);

            Sorgulat();
            Sorgulat_2();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Bilgiler kaydedilecektir. Çıkış yapmak istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void gozat_Click(object sender, EventArgs e)
        {
            if (dosya_acici.ShowDialog() == DialogResult.OK)
                resim_kutusu.Load(dosya_acici.FileName);
        }
        private void KayıtListele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new("SELECT * FROM kitaplar ORDER BY id ASC", baglanti);
            DataSet ds = new();
            listele.Fill(ds);
            kitaplar_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        public void KullaniciListele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new("SELECT * FROM kullanicilar ORDER BY ad ASC", baglanti);
            DataSet ds = new();
            listele.Fill(ds);
            kullanici_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void KiralanacakListele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new("SELECT * FROM kitaplar ORDER BY id ASC", baglanti);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            kiralanacak_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void kitap_arama_TextChanged(object sender, EventArgs e)
        {
            if (kitap_arama.Text.Trim().Length == 0)
                KayıtListele();
            else
            {
                baglanti.Open();
                OleDbDataAdapter listele = new("SELECT * FROM kitaplar WHERE ad LIKE '" + kitap_arama.Text.Trim() + "%'", baglanti);
                DataSet ds = new();
                listele.Fill(ds);
                kitaplar_vt.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void sayfa_sayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitap_yazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitap_ekle_Click(object sender, EventArgs e)
        {
            if (ıd.Text.Length == 0)
                ıd.Text = "0";
            int sayac = 0;
            string kitap_ismi = "";
            baglanti.Open();
            OleDbCommand arama = new("SELECT id FROM kitaplar", baglanti);
            OleDbDataReader okuma = arama.ExecuteReader();
            while (okuma.Read())
            {
                if (Convert.ToInt32(ıd.Text) == (int)okuma["id"])
                {
                    sayac++;
                    kitap_ismi = (string)okuma["ad"];
                }

            }
            baglanti.Close();

            if (kitap_ad.Text.Trim().Length == 0 || kitap_yazar.Text.Trim().Length == 0 || turu.Text.Trim().Length == 0 || cikis_tarihi.SelectedItem == null || aciklama.Text.Trim().Length < 50 || sayfa_sayisi.Text.Trim().Length == 0 || (kiralanabilir.Checked == false && kiralanamaz.Checked == false) || resim_kutusu.Image == null)
            {
                Sorgula();
                MessageBox.Show("Tüm böülümlerin doğru ve eksiksiz bir şekilde doldurulduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sayac == 1)
                MessageBox.Show("Bu ID numarasına ait bir kitap bulunmaktadır." + "\n" + "Kitap Adı : " + kitap_ismi, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult sonuc = MessageBox.Show("Bu kitabı eklemek istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == sonuc)
                {
                    string rent = "";
                    if (kiralanabilir.Checked)
                        rent = "Evet";
                    else
                        rent = "Hayır";
                    baglanti.Open();
                    OleDbCommand ekleme = new OleDbCommand("INSERT INTO kitaplar (ad, yazar, türü, cikis_tarih, eklenme_tarih, sayfa_sayisi, kiralık, acıklama, kiralayan, durum) VALUES ('" + kitap_ad.Text.Trim() + "', '" + kitap_yazar.Text.Trim() + "', '" + turu.Text.Trim() + "', '" + cikis_tarihi.SelectedItem.ToString() + "', '" + eklenme_tarihi.Value.ToShortDateString() + "', '" + sayfa_sayisi.Text.Trim() + "', '" + rent + "', '" + aciklama.Text.Trim() + "', 'Yok', 'Yok')", baglanti);
                    ekleme.ExecuteNonQuery();
                    baglanti.Close();
                    KayıtListele();
                    KiralanacakListele();
                    string dosya = @"C:\Kitap Fotoğrafları\" + kitap_ad.Text + ".jpeg";
                    resim_kutusu.Image.Save(dosya);
                    MessageBox.Show("Kitap veri tabanına başarıyla eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Sorgula()
        {
            if (kitap_ad.Text.Trim().Length == 0)
                kitapad_lbl.ForeColor = Color.Red;
            else
                kitapad_lbl.ForeColor = Color.Black;

            if (kitap_yazar.Text.Trim().Length == 0)
                yazar_lbl.ForeColor = Color.Red;
            else
                yazar_lbl.ForeColor = Color.Black;

            if (turu.Text.Trim().Length == 0)
                tur_lbl.ForeColor = Color.Red;
            else
                tur_lbl.ForeColor = Color.Black;

            if (cikis_tarihi.SelectedItem == null)
                cikistarihi_lbl.ForeColor = Color.Red;
            else
                cikistarihi_lbl.ForeColor = Color.Black;

            if (sayfa_sayisi.Text.Trim().Length == 0)
                sayfa_lbl.ForeColor = Color.Red;
            else
                sayfa_lbl.ForeColor = Color.Black;

            if (kiralanabilir.Checked == false && kiralanamaz.Checked == false)
                kiralıkdurum_lbl.ForeColor = Color.Red;
            else
                kiralıkdurum_lbl.ForeColor = Color.Black;

            if (aciklama.Text.Trim().Length < 50)
                aciklama_lbl.ForeColor = Color.Red;
            else
                aciklama_lbl.ForeColor = Color.Black;

            if (resim_kutusu.Image == null)
                gozat.ForeColor = Color.Red;
            else
                gozat.ForeColor = Color.Black;

        }

        private void kitap_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '?' || e.KeyChar == '*' || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == ':' || e.KeyChar == '"' || e.KeyChar == '/' || e.KeyChar == '\\' || e.KeyChar == '|')
                e.Handled = true;
        }

        private void kitap_sil_Click(object sender, EventArgs e)
        {
            Siyahlat();
            if (kitaplar_vt.Rows.Count == 0 || kitaplar_vt.SelectedRows.Count == 0)
                MessageBox.Show("Silme işlemi için veri tabanından bir kayıt seçmeniz gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int ifade = (int)kitaplar_vt.SelectedRows[0].Cells[8].Value;
                string kitap_ismi = (string)kitaplar_vt.SelectedRows[0].Cells[0].Value;
                int sayac = 0;

                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT kiralık FROM kitaplar WHERE id = " + ifade, baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if ((string)okuma["kiralık"] == "Hayır")
                        sayac++;
                }
                baglanti.Close();

                if (sayac != 0)
                    MessageBox.Show("Bu kitap kiralanmış durumdadır. Kitabın silinmesi için rafta bulunmalı ve anlık olarak kiralanmamamış olmalıdır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    DialogResult sonuc = MessageBox.Show(kitap_ismi + " adlı, " + ifade + " ID numaralı kitabı silmek istediğnizden emin misiniz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand silme = new OleDbCommand("DELETE FROM kitaplar WHERE id = " + ifade, baglanti);
                        silme.ExecuteNonQuery();
                        baglanti.Close();
                        KayıtListele();
                        KiralanacakListele();
                        string dosya = @"C:\Kitap Fotoğrafları\" + kitap_ismi + ".jpeg";
                        File.Delete(dosya);
                        MessageBox.Show("Kitap veri tabanından silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Siyahlat();
        }
        private void Temizle()
        {
            kitap_ad.Clear();
            kitap_yazar.Clear();
            turu.Clear();
            aciklama.Clear();
            cikis_tarihi.SelectedItem = null;
            sayfa_sayisi.Clear();
            eklenme_tarihi.Value = DateTime.Today;
            kiralanabilir.Checked = false;
            kiralanamaz.Checked = false;
            ıd.Text = "0";
            resim_kutusu.Image = null;
            durum.SelectedItem = null;
        }
        private void Siyahlat()
        {
            kitapad_lbl.ForeColor = Color.Black;
            yazar_lbl.ForeColor = Color.Black;
            tur_lbl.ForeColor = Color.Black;
            aciklama_lbl.ForeColor = Color.Black;
            cikistarihi_lbl.ForeColor = Color.Black;
            sayfa_lbl.ForeColor = Color.Black;
            kiralıkdurum_lbl.ForeColor = Color.Black;
            gozat.ForeColor = Color.Black;
        }

        private void kitaplar_vt_SelectionChanged(object sender, EventArgs e)
        {
            Siyahlat();
            if (kitaplar_vt.SelectedRows.Count == 0)
                Temizle();
            else
            {
                string kitap_ismi = (string)kitaplar_vt.SelectedRows[0].Cells[0].Value;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kitaplar", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if ((string)okuma["ad"] == kitap_ismi)
                    {
                        kitap_ad.Text = kitap_ismi;
                        kitap_yazar.Text = (string)okuma["yazar"];
                        turu.Text = (string)okuma["türü"];
                        cikis_tarihi.SelectedItem = okuma["cikis_tarih"];
                        string tarih = (string)okuma["eklenme_tarih"];
                        eklenme_tarihi.Value = Convert.ToDateTime(tarih);
                        sayfa_sayisi.Text = (string)okuma["sayfa_sayisi"];
                        if ((string)okuma["kiralık"] == "Evet")
                            kiralanabilir.Checked = true;
                        else
                            kiralanamaz.Checked = true;
                        aciklama.Text = (string)okuma["acıklama"];
                        durum.SelectedItem = okuma["durum"];
                        int deger = (int)okuma["id"];
                        ıd.Text = deger.ToString();
                        string dosya = @"C:\Kitap Fotoğrafları\" + kitap_ismi + ".jpeg";
                        resim_kutusu.Load(dosya);
                    }
                }
                baglanti.Close();
            }
        }

        private void k_kullaniciad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }

        private void k_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void Sorgula_2()
        {
            DateTime bugun = DateTime.Today;
            DateTime secilenyas = k_dogum.Value.AddYears(16);
            if (secilenyas > bugun)
                dogum_oluru = 0;//olmaz
            else
                dogum_oluru = 1;//olur

            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$";
            if (!Regex.IsMatch(k_parola.Text, pattern))
                sifre_oluru = 0;//olmaz
            else
                sifre_oluru = 1;//olur


            if (k_ad.Text.Trim().Length == 0)
                k_ad_lbl.ForeColor = Color.Red;
            else
                k_ad_lbl.ForeColor = Color.Black;

            if (k_soyad.Text.Trim().Length == 0)
                k_soyad_lbl.ForeColor = Color.Red;
            else
                k_soyad_lbl.ForeColor = Color.Black;

            if (dogum_oluru == 0)
                k_dogum_lbl.ForeColor = Color.Red;
            else
                k_dogum_lbl.ForeColor = Color.Black;

            if (k_telno.Text.Trim().Length != 14)
                k_tel_lbl.ForeColor = Color.Red;
            else
                k_tel_lbl.ForeColor = Color.Black;

            if (k_erkek.Checked == false && k_kadin.Checked == false)
                k_cinsiyet_lbl.ForeColor = Color.Red;
            else
                k_cinsiyet_lbl.ForeColor = Color.Black;

            if (k_kullaniciad.Text.Trim().Length == 0)
                k_kullaniciad_lbl.ForeColor = Color.Red;
            else
                k_kullaniciad_lbl.ForeColor = Color.Black;

            if (k_babasoniki.Text.Trim().Length != 2)
                k_babasoniki_lbl.ForeColor = Color.Red;
            else
                k_babasoniki_lbl.ForeColor = Color.Black;

            if (k_parola.Text.Length < 6 || k_parola.Text != k_parolatekrar.Text || sifre_oluru == 0)
            {
                k_parola_lbl.ForeColor = Color.Red;
                k_parolatekrar_lbl.ForeColor = Color.Red;
            }
            else
            {
                k_parola_lbl.ForeColor = Color.Black;
                k_parolatekrar_lbl.ForeColor = Color.Black;
            }
            if (kullanici.Checked == false && yonetici.Checked == false)
                pozisyon_lbl.ForeColor = Color.Red;
            else
                pozisyon_lbl.ForeColor = Color.Black;


        }
        private void Siyahlat_2()
        {
            k_ad_lbl.ForeColor = Color.Black;
            k_soyad_lbl.ForeColor = Color.Black;
            k_dogum_lbl.ForeColor = Color.Black;
            k_cinsiyet_lbl.ForeColor = Color.Black;
            k_tel_lbl.ForeColor = Color.Black;
            k_kullaniciad_lbl.ForeColor = Color.Black;
            k_parola_lbl.ForeColor = Color.Black;
            k_parolatekrar_lbl.ForeColor = Color.Black;
            k_babasoniki_lbl.ForeColor = Color.Black;
            pozisyon_lbl.ForeColor = Color.Black;
        }

        private void k_sil_Click(object sender, EventArgs e)
        {
            Siyahlat_2();
            if (kullanici_vt.SelectedRows.Count != 1 || kullanici_vt.Rows.Count == 0)
                MessageBox.Show("Listede kullanıcı bulunduğundan ve silinecek kaydı seçtiğinizden emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kitaplar", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if ((string)okuma["kiralayan"] == k_kullaniciad.Text)
                        sayac++;
                }
                baglanti.Close();
                if (sayac != 0)
                    MessageBox.Show("Bu kişinin " + sayac + " adet kiralanmış kitabı bulunmaktadır. Silme işlemi için kiralık kitabının bulunmaması gerekir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    string kullananın_adi = (string)kullanici_vt.SelectedRows[0].Cells[0].Value;
                    string kullananın_soyadi = (string)kullanici_vt.SelectedRows[0].Cells[1].Value;
                    string kullananın_kullaniciadi = (string)kullanici_vt.SelectedRows[0].Cells[5].Value;

                    DialogResult sonuc = MessageBox.Show("'" + kullananın_kullaniciadi + "' kullanıcı adlı, '" + kullananın_adi + " " + kullananın_soyadi + "' kişisini silmek istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand silme = new("DELETE FROM kullanicilar WHERE kullanici_ad = '" + kullananın_kullaniciadi + "'", baglanti);
                        silme.ExecuteNonQuery();
                        baglanti.Close();
                        KullaniciListele();
                        Temizle_2();
                        kullanici_ara.Clear();
                        MessageBox.Show("Kişi başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
        private void k_parola_TextChanged(object sender, EventArgs e)
        {
            k_ilerlemecubugu.Value = k_parola.Text.Length;
            if (k_parola.Text.Length == 0)
            {
                k_sifredurum.Text = "...";
                k_sifredurum.ForeColor = Color.Black;
            }
            else if (k_parola.Text.Length < 6 && k_parola.Text != k_parolatekrar.Text)
            {
                k_sifredurum.Text = "Zayıf - Parolalar Uyuşmuyor";
                k_sifredurum.ForeColor = Color.Red;
            }
            else if (k_parola.Text.Length < 6 && k_parola.Text == k_parolatekrar.Text)
            {
                k_sifredurum.Text = "Zayıf";
                k_sifredurum.ForeColor = Color.Red;
            }
            else if (k_parola.Text.Length >= 6 && k_parola.Text != k_parolatekrar.Text)
            {
                k_sifredurum.Text = "Parolalar Uyuşmuyor";
                k_sifredurum.ForeColor = Color.Red;
            }
            else if (k_parola.Text.Length >= 6 && k_parola.Text == k_parolatekrar.Text)
            {
                k_sifredurum.Text = "Güçlü";
                k_sifredurum.ForeColor = Color.Green;
            }

        }

        private void k_temizle_Click(object sender, EventArgs e)
        {
            Siyahlat_2();
            Temizle_2();
        }
        private void Temizle_2()
        {
            Siyahlat_2();
            k_ad.Clear();
            k_soyad.Clear();
            k_telno.Clear();
            k_dogum.Value = DateTime.Today;
            k_erkek.Checked = false;
            k_kadin.Checked = false;
            k_kullaniciad.Clear();
            k_parola.Clear();
            k_parolatekrar.Clear();
            k_babasoniki.Clear();
            kullanici.Checked = false;
            yonetici.Checked = false;
        }

        private void kullanici_vt_SelectionChanged(object sender, EventArgs e)
        {
            Siyahlat_2();
            if (kullanici_vt.Rows.Count == 0 || kullanici_vt.SelectedRows.Count == 0)
                Temizle_2();
            else
            {
                string ifade = (string)kullanici_vt.SelectedRows[0].Cells[0].Value;
                k_ad.Text = ifade;
                k_soyad.Text = (string)kullanici_vt.SelectedRows[0].Cells[1].Value;

                DateTime tarih = (DateTime)kullanici_vt.SelectedRows[0].Cells[2].Value;
                k_dogum.Value = tarih;

                if ((string)kullanici_vt.SelectedRows[0].Cells[3].Value == "Erkek")
                    k_erkek.Checked = true;
                else
                    k_kadin.Checked = true;

                k_telno.Text = (string)kullanici_vt.SelectedRows[0].Cells[4].Value;

                k_kullaniciad.Text = (string)kullanici_vt.SelectedRows[0].Cells[5].Value;
                k_parola.Text = (string)kullanici_vt.SelectedRows[0].Cells[6].Value;
                k_parolatekrar.Text = k_parola.Text;
                k_babasoniki.Text = (string)kullanici_vt.SelectedRows[0].Cells[7].Value;

                if ((string)kullanici_vt.SelectedRows[0].Cells[8].Value == "Kullanıcı")
                    kullanici.Checked = true;
                else
                    yonetici.Checked = true;
            }
        }

        private void kullanici_ara_TextChanged(object sender, EventArgs e)
        {
            Siyahlat_2();
            if (kullanici_ara.Text.Length == 0)
                KullaniciListele();
            else
            {
                baglanti.Open();
                OleDbDataAdapter listele = new("SELECT * FROM kullanicilar WHERE ad LIKE '" + kullanici_ara.Text + "%'", baglanti);
                DataSet ds = new();
                listele.Fill(ds);
                kullanici_vt.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void k_parola_goster_Click(object sender, EventArgs e)
        {
            if (k_parola.UseSystemPasswordChar == true)
            {
                k_parola.UseSystemPasswordChar = false;
                k_parola_goster.Text = "Gösterme";
            }
            else
            {
                k_parola.UseSystemPasswordChar = true;
                k_parola_goster.Text = "Göster";
            }
        }

        private void k_parolatekrar_goster_Click(object sender, EventArgs e)
        {
            if (k_parolatekrar.UseSystemPasswordChar == true)
            {
                k_parolatekrar.UseSystemPasswordChar = false;
                k_parolatekrar_goster.Text = "Gösterme";
            }
            else
            {
                k_parolatekrar.UseSystemPasswordChar = true;
                k_parolatekrar_goster.Text = "Göster";
            }
        }

        private void k_ekle_Click(object sender, EventArgs e)
        {
            Sorgula_2();
            if (k_ad.Text.Trim().Length == 0 || k_soyad.Text.Trim().Length == 0 || dogum_oluru == 0 || k_telno.Text.Trim().Length != 14 || (k_erkek.Checked == false && k_kadin.Checked == false) || k_kullaniciad.Text.Length == 0 || k_babasoniki.Text.Trim().Length != 2 || k_parola.Text.Length < 6 || k_parola.Text != k_parolatekrar.Text || sifre_oluru == 0 || (yonetici.Checked == false && kullanici.Checked == false))
                MessageBox.Show("Tüm bilgilerin eksiksiz ve doğru şekilde doldurulduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (k_kullaniciad.Text == (string)okuma["kullanici_ad"] || k_telno.Text.Trim() == (string)okuma["telefon_no"])
                        sayac++;
                }
                baglanti.Close();
                if (sayac != 0)
                    MessageBox.Show("Kullanıcı adı veya telefon numarası başka bir kullanıcıya aittir. Lütfen kullanıcı adınızın ve telefon numaranızın sadece ama sadece size ait olmasına dikkat ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string cinsiyet;
                    string position;
                    if (k_erkek.Checked)
                        cinsiyet = "Erkek";
                    else
                        cinsiyet = "Kadın";
                    if (kullanici.Checked)
                        position = "Kullanıcı";
                    else
                        position = "Yönetici";

                    baglanti.Open();
                    OleDbCommand ekleme = new OleDbCommand("INSERT INTO kullanicilar VALUES ('" + k_ad.Text.Trim() + "', '" + k_soyad.Text.Trim() + "', '" + k_dogum.Value.ToShortDateString() + "', '" + cinsiyet + "', '" + k_telno.Text.Trim() + "', '" + k_kullaniciad.Text + "', '" + k_parola.Text + "', '" + k_babasoniki.Text.Trim() + "', '" + position + "')", baglanti);
                    ekleme.ExecuteNonQuery();
                    baglanti.Close();
                    Siyahlat_2();
                    Temizle_2();
                    KullaniciListele();
                    MessageBox.Show("Kişi veri tabanına başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void kiralanacak_arama_TextChanged(object sender, EventArgs e)
        {
            kiralanacak_kullaniciad.ForeColor = Color.Black;
            if (kiralanacak_arama.Text.Trim().Length == 0)
                KiralanacakListele();
            else
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("SELECT * FROM kitaplar WHERE ad LIKE '" + kiralanacak_arama.Text.Trim() + "%'", baglanti);
                DataSet ds = new();
                listele.Fill(ds);
                kiralanacak_vt.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }
        private void kirala_Click(object sender, EventArgs e)
        {
            if (kiralanacak_kullaniciad.Text.Length == 0 || kiralanacak_vt.SelectedRows.Count == 0)
                MessageBox.Show("Kiralanacak kitabı seçtiğinizden ve kullanıcı adının girildiğinden emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int kiralanacak_id = (int)kiralanacak_vt.SelectedRows[0].Cells[8].Value;
                string kiralanacak_kitap_ad = (string)kiralanacak_vt.SelectedRows[0].Cells[0].Value;

                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama_1 = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
                OleDbDataReader okuma_1 = arama_1.ExecuteReader();
                while (okuma_1.Read())
                {
                    if ((string)okuma_1["kullanici_ad"] == kiralanacak_kullaniciad.Text)
                        sayac++;
                }
                baglanti.Close();
                if (sayac == 0)
                    MessageBox.Show("Kullanıcı adı bulunamadı. Lütfen geçerli bir kullanıcı adı giriniz ve tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int kiralanmıs_kitap_sayisi = 0;
                    int dolma = 0;
                    int sayac_2 = 0;
                    baglanti.Open();
                    OleDbCommand arama_2 = new OleDbCommand("SELECT * FROM kitaplar WHERE id = " + kiralanacak_id + " or kiralayan = '" + kiralanacak_kullaniciad.Text + "'", baglanti);
                    OleDbDataReader okuma_2 = arama_2.ExecuteReader();
                    while (okuma_2.Read())
                    {
                        if ((string)okuma_2["kiralayan"] == kiralanacak_kullaniciad.Text)
                            kiralanmıs_kitap_sayisi++;

                        if ((string)okuma_2["durum"] == "Doldu" && (string)okuma_2["kiralık"] == "Hayır")//Kiralık = "Evet" olan yere giderse null değer döner ilk ifade için
                            dolma++;

                        if ((int)okuma_2["id"] == kiralanacak_id && (string)okuma_2["kiralayan"] != "Yok")
                            sayac_2++;
                    }
                    baglanti.Close();

                    if (kiralanmıs_kitap_sayisi == 5)
                        MessageBox.Show(kiralanacak_kullaniciad.Text + " kullanıcı adlı kişi, kiralayabileceği maksimum kitap adedine ulaşmıştır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (sayac_2 != 0)
                        MessageBox.Show(kiralanacak_id + " ID numaralı kitap kiralık durumdadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (dolma != 0)
                        MessageBox.Show("Bu kullanıcının süresi dolmuş bir kitap geri getirme tarihi var. İlk önce kitabı teslim etmelidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        DialogResult sonuc = MessageBox.Show(kiralanacak_id + " ID numaralı " + kiralanacak_kitap_ad + " adlı kitap, " + kiralanacak_kullaniciad.Text + " kullanıcı adlı kişiye kiralanacaktır." + "\n" + "Onaylıyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (sonuc == DialogResult.Yes)
                        {
                            baglanti.Open();
                            OleDbCommand duzenle = new OleDbCommand("UPDATE kitaplar SET kiralık = 'Hayır', kiralayan = '" + kiralanacak_kullaniciad.Text + "', kiralama_tarih = '" + kiralama_tarih.Value.ToShortDateString() + "', getirme_tarih = '" + gerigetirme_tarih.Value.ToShortDateString() + "', durum = 'Devam' WHERE id = " + kiralanacak_id, baglanti);
                            duzenle.ExecuteNonQuery();
                            baglanti.Close();
                            kitap_arama.Clear();
                            KiralanacakListele();
                            KayıtListele();
                            MessageBox.Show("Kitap başarılı bir şekilde kiralandı." + "\n" + "Kiralayanın Kullanıcı Adı : " + kiralanacak_kullaniciad.Text + "\n" + "Kiralanma Tarihi : " + kiralama_tarih.Value.ToShortDateString() + "\n" + "Geri Getirilecek Tarih : " + gerigetirme_tarih.Value.ToShortDateString() + "\n" + "\n" + "Kitap ID : " + kiralanacak_id + "\n" + "Kitabın Adı : " + kiralanacak_kitap_ad, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            kiralanacak_kullaniciad.Clear();
                        }
                    }
                }
            }

        }

        private void geri_al_Click(object sender, EventArgs e)
        {
            if (kiralanacak_vt.SelectedRows.Count == 0)
                MessageBox.Show("Geri alınacak kitabı sseçtiğinizden emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int gerial_id = (int)kiralanacak_vt.SelectedRows[0].Cells[8].Value;
                string gerial_kitap = (string)kiralanacak_vt.SelectedRows[0].Cells[0].Value;

                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kitaplar WHERE id = " + gerial_id, baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if ((string)okuma["kiralayan"] == "Yok")
                        sayac++;
                }
                baglanti.Close();
                if (sayac != 0)
                    MessageBox.Show("Bu kitap kiralık durumda değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult sonuc = MessageBox.Show(gerial_id + " ID numaralı, " + gerial_kitap + " adlı kitap geri alınacaktır. Onaylıyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand duzenleme = new OleDbCommand("UPDATE kitaplar SET kiralık = 'Evet', kiralayan = 'Yok', kiralama_tarih = '', getirme_tarih = '', durum = 'Yok' WHERE id = " + gerial_id, baglanti);
                        duzenleme.ExecuteNonQuery();
                        baglanti.Close();
                        KayıtListele();
                        KiralanacakListele();
                        MessageBox.Show("Kitap geri alma işlemi başarıyla tamamlandı." + "\n" + "Kitap Adı : " + gerial_kitap + "\n" + "Kitap ID : " + gerial_id, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void k_guncelle_Click(object sender, EventArgs e)
        {
            if (kullanici_vt.SelectedRows.Count == 0)
                MessageBox.Show("Güncellenecek kaydı seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string kullanacak_ad = (string)kullanici_vt.SelectedRows[0].Cells[5].Value;
                KullanıcıGuncelle guncelle = new();
                guncelle.kullanan_ad = kullanacak_ad;
                guncelle.baglanti = this.baglanti;
                Temizle_2();
                Siyahlat_2();
                guncelle.ShowDialog();
                KullaniciListele();
            }

        }

        private void kitap_guncelle_Click(object sender, EventArgs e)
        {
            Siyahlat();
            if (kitaplar_vt.SelectedRows.Count == 0)
                MessageBox.Show("Güncellemek istediğiniz kitabı seçmeniz gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (aciklama.Text.Trim().Length < 50 && aciklama.Text.Trim() != "")
                    MessageBox.Show("Açıklama kısmını güncellemek istiyorsanız, en az 50 karakter girmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string bilgi = "";
                    string ad = (string)kitaplar_vt.SelectedRows[0].Cells[0].Value;
                    int _ıd = (int)kitaplar_vt.SelectedRows[0].Cells[8].Value;

                    if (kitap_ad.Text.Trim().Length != 0 && kitap_ad.Text.Trim() != ad)
                    {
                        Guncelleme("ad", kitap_ad.Text.Trim(), _ıd);
                        bilgi = "Ad : " + kitap_ad.Text.Trim() + "\n";
                    }
                    if (kitap_yazar.Text.Trim().Length != 0 && kitap_yazar.Text.Trim() != (string)kitaplar_vt.SelectedRows[0].Cells[1].Value)
                    {
                        Guncelleme("yazar", kitap_yazar.Text.Trim(), _ıd);
                        bilgi += "Yazar : " + kitap_yazar.Text.Trim() + "\n";
                    }
                    if (turu.Text.Trim().Length != 0 && turu.Text.Trim() != (string)kitaplar_vt.SelectedRows[0].Cells[2].Value)
                    {
                        Guncelleme("türü", turu.Text.Trim(), _ıd);
                        bilgi += "Türü : " + turu.Text.Trim() + "\n";
                    }
                    if (cikis_tarihi.SelectedItem != null && cikis_tarihi.Text.Trim() != (string)kitaplar_vt.SelectedRows[0].Cells[3].Value)
                    {
                        Guncelleme("cikis_tarih", cikis_tarihi.Text.Trim(), _ıd);
                        bilgi += "Çıkış Tarihi : " + cikis_tarihi.Text.Trim() + "\n";
                    }
                    if (aciklama.Text.Trim().Length != 0 && aciklama.Text.Trim() != (string)kitaplar_vt.SelectedRows[0].Cells[7].Value)
                    {
                        Guncelleme("acıklama", aciklama.Text.Trim(), _ıd);
                        bilgi += "Açıklama : " + aciklama.Text.Trim() + "\n";
                    }
                    if (sayfa_sayisi.Text.Trim().Length != 0 && sayfa_sayisi.Text.Trim() != (string)kitaplar_vt.SelectedRows[0].Cells[5].Value)
                    {
                        Guncelleme("sayfa_sayisi", sayfa_sayisi.Text.Trim(), _ıd);
                        bilgi += "Sayfa Sayısı : " + sayfa_sayisi.Text.Trim() + "\n";
                    }
                    DialogResult sonuc = MessageBox.Show("Güncellenecek Bilgiler" + "\n" + bilgi + "\n" + "Güncellenecek Kitap" + "\n" + "Kitap ID : " + _ıd + "\n" + "Kitap Adı : " + ad + "\n" + "\n" + "Değişiklikleri onaylıyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        Temizle();
                        KayıtListele();
                        KiralanacakListele();
                        MessageBox.Show("Değişiklikler başarıyla tamamlandı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Guncelleme(string duzenlenecek_yer, string duzenlenecek_bilgi, int id)
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand("UPDATE kitaplar SET " + duzenlenecek_yer + " = '" + duzenlenecek_bilgi + "' WHERE id = " + id, baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }
        private void turu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }
    }
}
