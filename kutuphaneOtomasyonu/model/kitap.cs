using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneOtomasyonu.model
{
    public class kitap
    {
        public int kitapId { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int  basimYili { get; set; }


        public kitap()
        {
                
        }
        public kitap(int kitapId,string kitapIsim,string kitapYazar,string kitapDili,string yayinEvi,string tur,int adet,int sayfaSayisi,int basimYili)
        {
            this.kitapId = kitapId;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYili = basimYili;
        }
        public int getKitapId()
        { 
            return this.kitapId; 
        }
        public string getkitapIsmi()
        {
            return this.kitapIsim;
        }
        public string getkitapYazar()
        {
            return this.kitapYazar;
        }
        public string getkitapDili()
        {
            return this.kitapDili;
        }
        public string getyayinEvi()
        {
            return this.yayinEvi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        { 
            return this.adet; 
        }
        public int getsayfaSayisi()
        {
            return this.sayfaSayisi;
        }
        public int getbasimYili()
        {
            return this.basimYili;
        }

    }
}
