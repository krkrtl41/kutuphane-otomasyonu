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
    public partial class KullanıcıSifreUnutma : Form
    {
        public OleDbConnection baglanti;
        public KullanıcıSifreUnutma()
        {
            InitializeComponent();
        }

        private void KullanıcıSifreUnutma_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            k_telno.Mask = "(999) 000-0000";
            k_telno.PasswordChar = '\0';
            k_telno.PromptChar = '_';
            k_telno.BeepOnError = false;

            k_babanınsonikiharf.Mask = "??";
            k_babanınsonikiharf.PasswordChar = '\0';
            k_babanınsonikiharf.PromptChar = '_';
            k_babanınsonikiharf.BeepOnError = false;
        }

        private void k_telno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Lüften geçerli bir değer giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void k_babanınsonikiharf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Lüften geçerli bir değer giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void devam_Click(object sender, EventArgs e)
        {
            if (k_kullaniciad.Text.Trim() == "" || k_babanınsonikiharf.Text.Trim().Length != 2 || k_telno.Text.Trim().Length != 14)
            {
                Sorgula();
                MessageBox.Show("Bütün bölümlerin dolu olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new("SELECT * FROM kullanicilar", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (k_kullaniciad.Text.Trim() == (string)okuma["kullanici_ad"] && k_telno.Text == (string)okuma["telefon_no"] && k_babanınsonikiharf.Text.ToUpper() == (string)okuma["baba_sonharfler"])
                    {
                        sayac++;
                    }
                }
                baglanti.Close();
                if (sayac == 0)
                {
                    Sorgula();
                    MessageBox.Show("Bu bilgilere ait kullanıcı bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    KullanıcıSifreDegistirme degistir = new();
                    degistir.kullanici_ad = this.k_kullaniciad.Text;
                    degistir.baglanti = this.baglanti;
                    this.Hide();
                    degistir.ShowDialog();
                }
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.tabControl.SelectedTab = f1.tabPage1;
            f1.ShowDialog();
        }
        private void Sorgula()
        {
            if (k_kullaniciad.Text.Trim() == "")
                kullaniciad_lbl.ForeColor = Color.Red;
            else
                kullaniciad_lbl.ForeColor = Color.Black;

            if (k_telno.Text.Trim().Length != 14)
                telno_lbl.ForeColor = Color.Red;
            else
                telno_lbl.ForeColor = Color.Black;

            if (k_babanınsonikiharf.Text.Trim().Length != 2)
                babasoniki_lbl.ForeColor = Color.Red;
            else
                babasoniki_lbl.ForeColor = Color.Black;
        }


    }
}
