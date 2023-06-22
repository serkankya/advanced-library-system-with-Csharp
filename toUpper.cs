using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class toUpper
    {
        //BU CLASSTA KAPSÜLLEME YÖNTEMİNİ KULLANARAK BÜYÜTTÜM YAZILARI
        private string buyukYaz;

        //public string BUYUKYAZ { get => BuyukYaz; set => value.ToUpper(); }
        public string BuyukYaz 
        {
            get { return buyukYaz; }
            set { buyukYaz = value.ToUpper();}
        }
    }
}
