using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    // kalıtım ile fiyatlandırmayı yaptık
    internal class Fiyatlandirma
    {
        protected double kdv = 1.08; // kdv direkt buradan değişecek 

        public virtual double FiyatHesapla(int gun)
        {
            return 0;
        }
    }

    
    internal class NormalUyeFiyatlandirma : Fiyatlandirma
    {
        public override double FiyatHesapla(int gun)
        {
            double toplam = 0;
            if (gun >= 16)
            {
                toplam = ((gun - 15) * 4) * kdv;
            }
            return toplam;
        }
    }

    internal class LisansFiyatlandirma : Fiyatlandirma
    {
        public override double FiyatHesapla(int gun)
        {
            double toplam = 0;
            double ekstraToplam = 0;
            if (gun >= 16 && gun <= 23)
            {
                toplam = ((gun - 15) * 1) * kdv;
            }
            else if (gun >= 23)
            {
                toplam = ((gun - 15) * 1);
                ekstraToplam = (toplam + ((gun - 22) * 2)) * kdv;
                return ekstraToplam;
            }
            return toplam;
        }
    }

    internal class LisansUstuFiyatlandirma : Fiyatlandirma
    {
        public override double FiyatHesapla(int gun)
        {
            double toplam = 0;
            double ekstraToplam = 0;
            if (gun >= 31 && gun <= 38)
            {
                toplam = ((gun - 30) * 1.25) * kdv;
            }
            else if (gun >= 38)
            {
                toplam = ((gun - 30) * 1.25);
                ekstraToplam = (toplam + ((gun - 37) * 2.5)) * kdv;
                return ekstraToplam;
            }
            return toplam;
        }
    }

    internal class AkademikPersonelFiyatlandirma : Fiyatlandirma
    {
        public override double FiyatHesapla(int gun)
        {
            double toplam = 0;
            double ekstraToplam = 0;
            if (gun >= 61 && gun <= 68)
            {
                toplam = ((gun - 60) * 2) * kdv;
            }
            else if (gun >= 68)
            {
                toplam = ((gun - 60) * 2);
                ekstraToplam = (toplam + ((gun - 67) * 4)) * kdv;
                return ekstraToplam;
            }
            return toplam;
        }
    }
}
