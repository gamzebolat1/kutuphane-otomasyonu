using kutuphaneOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonu
{
    public partial class uyeSayfasi : Form
    {
        List<kitap> kitaplarim;
        public uyeSayfasi(List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_usCikisYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi= new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void uyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(),kitap.getkitapIsmi(),kitap.getkitapYazar(),kitap.getkitapDili(),kitap.getyayinEvi(),kitap.gettur(),kitap.getadet(),kitap.getsayfaSayisi(),kitap.getbasimYili());
            }
        }

        private void btn_usAra_Click(object sender, EventArgs e)
        {
            int kitapID=Convert.ToInt32(txt_usAra.Text);
            kitap hedefKitap = null;
            foreach (kitap kitap in kitaplarim)
            {
                if(kitap.getKitapId() == kitapID)
                {
                hedefKitap = kitap;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsmi(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYili());


        }

        private void btn_usYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(kitap hedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsmi(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYili());
            }
        }
    }
}
