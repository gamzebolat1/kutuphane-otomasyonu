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
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        List<kitap> kitaplarim=new List<kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text=string.Empty;
            txt_kullaniciSifre.Text=string.Empty;
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullaniciAdi.Text;
            sifre = txt_kullaniciSifre.Text;

            bool kontrol = false;

            foreach (kisi kisi in kisilerim)

            {
                if (kullaniciadi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    //ADMİN SAYFASINA YÖNLENDİR
                    adminSayfasi adminSayfasi = new adminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    //UYE SAYFASINA YÖNLENDİR
                    uyeSayfasi uyeSayfasi = new uyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                
            }
            if(!kontrol)
                MessageBox.Show("Hatalı giriş","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1,"gamze","bolat",DateTime.Now,"gamzebolat","1","admin"));
            kisilerim.Add(new kisi(2, "ece", "bolat", DateTime.Now, "ecebolat", "2", "uye"));
            kisilerim.Add(new kisi(3, "mahmut", "bolat", DateTime.Now, "mahmutbolat", "3", "uye"));
            kisilerim.Add(new kisi(4, "zehra", "bolat", DateTime.Now, "zehrabolat", "4", "uye"));

            kitaplarim.Add(new kitap(1, "içimizdeki şeytan", "sabahattin ali", "türkçe", "yapı kredi yayınları", "roman", 100, 250, 2016));
            kitaplarim.Add(new kitap(2, "tutunamayanlar", "oğuz atay", "türkçe", "iletişim yayıncılık", "roman", 350, 760, 2015));
            kitaplarim.Add(new kitap(3, "uçurtma avcısı", "khaled hosseini", "ingilizce", "everest yayıncılık", "roman", 100, 350, 2010));
            kitaplarim.Add(new kitap(4, "küçük prens", "antoine de saint-exupery", "ingilizce", "can çocuk yayınları", "roman", 50, 60, 2018));
            kitaplarim.Add(new kitap(5, "kürk mantolu madonna", "sabahattin ali", "türkçe", "yapı kredi yayınları", "roman", 650, 220, 2015));
            //kitaplarim.Add(new kitap(6, "tehlikeli oyunlar", "oğuz atay", "türkçe", "iletişim yayıncılık", "roman", 420, 500, 2018));










        }
    }
}
