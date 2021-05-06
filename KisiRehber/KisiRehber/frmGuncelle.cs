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
    public partial class frmGuncelle : BaseForm
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }

        public frmGuncelle(int id,frmRehber frmRehber)
        {
            InitializeComponent();

            this.id = id;
            this.frmRehber = frmRehber;
        }
        public int id;
        public frmRehber frmRehber;

        private void frmGuncelle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(400, 250);
            var deneme = db.RehberBilgileri.Where(w => w.id == id).FirstOrDefault();

            txtNumara.Text = deneme.TelefonNo;
            txtKullaniciAdi.Text = deneme.İsim;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.RehberBilgileri.Where(w => w.id == id).FirstOrDefault();
            guncelle.İsim = txtKullaniciAdi.Text;
            guncelle.TelefonNo = txtNumara.Text;
            db.SaveChanges();

            frmRehber.Listele();
            MessageBox.Show("güncelleme başarılı");
            this.Hide();
               
        }
    }
}
