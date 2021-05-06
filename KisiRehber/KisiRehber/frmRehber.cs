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
    public partial class frmRehber : BaseForm
    {
        public frmRehber()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            db = new UyelerEntities4();
            dataGridView1.DataSource = db.RehberBilgileri.ToList();
        }

        private void frmRehber_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            RehberBilgileri tbl = new RehberBilgileri();
            tbl.İsim = TxtYeniKisi.Text;
            tbl.TelefonNo = TxtNumara.Text;
            db.RehberBilgileri.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.RehberBilgileri.ToList();
            MessageBox.Show("Kişi Kaydedildi");


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.RehberBilgileri.Where(w => w.id == Id).FirstOrDefault();
            db.RehberBilgileri.Remove(sil);
            db.SaveChanges();
            dataGridView1.DataSource = db.RehberBilgileri.ToList();
            MessageBox.Show("kişi rehberinizden silindi");
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            frmGiris fr = new frmGiris();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            frmGuncelle popUp = new frmGuncelle(Convert.ToInt32(row.Cells[0].Value.ToString()), this);
            popUp.Show();

            dataGridView1.DataSource = db.RehberBilgileri.ToList();

        }
    }
}
