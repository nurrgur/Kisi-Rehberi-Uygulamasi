using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace KisiRehber
{
    public partial class frmSifremiUnuttum : BaseForm
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }


        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            frmGiris fr = new frmGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSifreGonder_Click(object sender, EventArgs e)
        {
            var isim = textBox1.Text;
            var mail = textBox2.Text;
            var deneme = db.KullaniciBilgileri.Where(w => w.KullaniciAdi == isim).FirstOrDefault();

            if (deneme.MailAdresi == mail)
            {
                try
                {
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;

                    string icerik = deneme.KullaniciSifresi;

                    sc.Credentials = new System.Net.NetworkCredential("glryz.ceyda@gmail.com", "ceydaguleryuz.805");

                    MailMessage email = new MailMessage();
                    email.From = new MailAddress("glryz.ceyda@gmail.com");
                    email.To.Add(mail);
                    email.Subject = "şifre bilgilendirme";
                    email.IsBodyHtml = true;
                    email.Body = icerik;
                    sc.Send(email);

                    frmGiris frm = new frmGiris();
                    frm.Show();
                    this.Close();
                }

                catch (Exception)
                {
                    MessageBox.Show("mail gönderme hatası! \n İnternet bağlantınızı kontrol ediniz!");
                }

            }
            else
                MessageBox.Show("yanlış mail girdiniz!");
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
