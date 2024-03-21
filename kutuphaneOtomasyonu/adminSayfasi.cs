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
    public partial class adminSayfasi : Form
    {
       
         List<kisi> kisilerim;
        List<kitap> kitaplarim;

        
        public adminSayfasi(List<kisi> kisilerim, List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarih(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 30;
            dataGridView1.Columns[6].Width = 45;

            foreach(kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(),kitap.getkitapIsmi(),kitap.getkitapYazar(),kitap.getkitapDili(),kitap.getyayinEvi(),kitap.gettur(),kitap.getadet(),kitap.getsayfaSayisi(),kitap.getbasimYili());
            }


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text),txt_isim.Text,txt_soyisim.Text,maskedTextBox1.Text,txt_kullaniciAdi.Text,txt_Sifre.Text,txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
           string id=txt_id.Text;
           string isim=txt_isim.Text;
           string soyisim=txt_soyisim.Text;
           string olusturmaTarih= maskedTextBox1 .Text;
           string kullaniciAdi=txt_kullaniciAdi .Text;
           string sifre=txt_Sifre .Text;
           string yetki=txt_yetki.Text;

            dataGridView1 .Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmaTarih, kullaniciAdi, sifre, yetki);
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBoxUye.Controls.Count; i++)
            {
                if (groupBoxUye.Controls[i] is TextBox || groupBoxUye.Controls[i] is MaskedTextBox)
                {
                    groupBoxUye.Controls[i].Text=string.Empty;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapismi.Text, txt_yazar.Text, txt_kitapdili.Text, txt_yayinevi.Text, txt_kitapturu.Text, txt_kitapadet.Text, txt_sayfaSayisi.Text, txt_basimyili.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            string kitapId = txt_kitapid.Text;
            string kitapisim=txt_kitapismi.Text;
            string kitapYazar = txt_yazar.Text;
            string kitapDili=txt_kitapdili.Text;
            string yayinevi=txt_yayinevi.Text;
            string tur = txt_kitapturu.Text;
            string adet = txt_kitapadet.Text;
            string sayfaSayisi=txt_sayfaSayisi.Text;
            string basimYili=txt_basimyili.Text;
            dataGridView2.Rows.Remove (dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapId,kitapisim,kitapYazar,kitapDili,yayinevi,tur,adet,sayfaSayisi,basimYili);
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBoxKitap.Controls.Count; i++)
            {
                if (groupBoxKitap.Controls[i] is TextBox)
                {
                    groupBoxKitap.Controls[i].Text=string.Empty;
                }
                        
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapismi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_yazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitapturu.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapadet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfaSayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            kisi hedefKisi = null;
            int secilenKisiID=Convert.ToInt32(txt_kisiAra.Text);
            foreach(kisi kisi in kisilerim)
            {
                if (kisi.getId() == secilenKisiID)
                {
                    hedefKisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
        }

        private void btn_kisiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            kitap hedefKitap = null;
            int secilenKitapID = Convert.ToInt32(txt_kitapAra.Text);
            foreach (kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == secilenKitapID)
                {
                    hedefKitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsmi(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(),hedefKitap.getsayfaSayisi(),hedefKitap.getbasimYili());
        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getkitapIsmi(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getyayinEvi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfaSayisi(), hedefKitap.getbasimYili());
            }
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
