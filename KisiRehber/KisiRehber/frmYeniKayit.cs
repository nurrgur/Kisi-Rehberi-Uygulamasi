using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiRehber
{
    public partial class frmYeniKayit : BaseForm
    {
        public frmYeniKayit()
        {
            InitializeComponent();
        }

        private void frmYeniKayit_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.KullaniciBilgileri.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri tbl = new KullaniciBilgileri();
            tbl.KullaniciAdi = TxtYeniKullanici.Text;
            tbl.KullaniciSifresi = TxtSifre.Text;
            tbl.MailAdresi = TxtMail.Text;
            db.KullaniciBilgileri.Add(tbl);
            db.SaveChanges();
            //dataGridView1.DataSource = db.KullaniciBilgileri.ToList();
            MessageBox.Show("Hoşgeldiniz! \n Kayıt işlemi başarıyla tamamlanmıştır,");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris fr = new frmGiris();
            fr.Show();
            this.Hide();
        }

        
    }
 }

