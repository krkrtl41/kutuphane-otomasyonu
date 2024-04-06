using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyonu
{
    public partial class YoneticiSifreUnutma : Form
    {
        public OleDbConnection baglanti;
        public YoneticiSifreUnutma()
        {
            InitializeComponent();
        }

        private void YoneticiSifreUnutma_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            tel_no.Mask = "(999) 000-0000";
            tel_no.PasswordChar = '\0';
            tel_no.PromptChar = '_';
            tel_no.BeepOnError = false;

            baba_soniki.Mask = "??";
            baba_soniki.PasswordChar = '\0';
            baba_soniki.PromptChar = '_';
            baba_soniki.BeepOnError = false;
        }

        private void kullanici_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.tabControl.SelectedTab = f1.tabPage2;
            f1.ShowDialog();
        }
        private void Sorgula()
        {
            if (kullanici_ad.Text == "")
                kullanici_ad_lbl.ForeColor = Color.Red;
            else
                kullanici_ad_lbl.ForeColor = Color.Black;

            if (tel_no.Text.Trim().Length != 14)
                telno_lbl.ForeColor = Color.Red;
            else
                telno_lbl.ForeColor = Color.Black;

            if (baba_soniki.Text.Trim().Length != 2)
                babasoniki_lbl.ForeColor = Color.Red;
            else
                babasoniki_lbl.ForeColor = Color.Black;
        }
        private void devam_Click(object sender, EventArgs e)
        {
            if (kullanici_ad.Text == "" || tel_no.Text.Trim().Length != 14 || baba_soniki.Text.Trim().Length != 2)
            {
                Sorgula();
                MessageBox.Show("Bütün bölümlerin eksiksiz şekilde dolu olmasına dikkat ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new("SELECT * FROM kullanicilar WHERE pozisyon = 'Yönetici'", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (kullanici_ad.Text == (string)okuma["kullanici_ad"] && tel_no.Text == (string)okuma["telefon_no"] && baba_soniki.Text == (string)okuma["baba_sonharfler"])
                        sayac++;
                }
                baglanti.Close();
                if (sayac == 0)
                {
                    Sorgula();
                    MessageBox.Show("Böyle bir yönetici bulunmamaktadır. Lütfen bilgilerini doğru ve eksiksiz bir şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    YoneticiSifreDegistirme degistir = new();
                    degistir.baglanti = this.baglanti;
                    degistir.kullanici_ad = this.kullanici_ad.Text;
                    this.Hide();
                    degistir.ShowDialog();
                }
            }
        }
    }
}
