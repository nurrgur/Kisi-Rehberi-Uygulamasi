using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KisiRehber
{
    public partial class frmGiris : BaseForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var isim  = TxtKullanici.Text;
            var sifre = TxtSifre.Text;

            var kontrol =db.KullaniciBilgileri.Where(w=>w.KullaniciAdi == isim).FirstOrDefault();
            if(kontrol != null)
            {
                if (kontrol.KullaniciSifresi == sifre)
                {
                    frmRehber frrm = new frmRehber();
                    frrm.Show();
                    this.Hide();
                }
            }
        }

        private void ChckSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckSifreyiGoster.Checked)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum fr = new frmSifremiUnuttum();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit fr = new frmYeniKayit();

            fr.Show();
            this.Hide();
        }
    }
}
