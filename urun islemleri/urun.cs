using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urun_islemleri
{
    class urun
    {
        public string uruncesidi,urunkategorisi;
        public int urunno,fiyat,stokmiktarı,kasa,sayac;

        public void urunsat()
        {
            if (stokmiktarı <= sayac)
            {
                System.Windows.Forms.MessageBox.Show("Stokta ürün kalmadı");
            }
            else
            {
                kasa = kasa + fiyat;
                System.Windows.Forms.MessageBox.Show("ürün başarıyla satıldı");
                sayac++;
            }
        }
    }
}
