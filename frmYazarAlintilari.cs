using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class frmYazarAlintilari : Form
    {
        public frmYazarAlintilari()
        {
            InitializeComponent();
        }

        private void btn_yazarsoz_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz.Visible)
            {
                lbl_yazarsoz.Visible = false;
            }
            else
            {
                lbl_yazarsoz.Visible = true;
            }

            lbl_yazarsoz.Text = "\"İnsanlar birbirleriyle karşılaştıklarında, dillerinden çok kalpleriyle konuşmalıdır.\"";

        }

        private void btn_yazarsoz1_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz1.Visible)
            {
                lbl_yazarsoz1.Visible = false;
            }
            else
            {
                lbl_yazarsoz1.Visible = true;
            }

            lbl_yazarsoz1.Text = "\"Geçmişi olmayanın, geleceği de olmaz.\"";

        }

        private void btn_yazarsoz2_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz2.Visible)
            {
                lbl_yazarsoz2.Visible = false;
            }
            else
            {
                lbl_yazarsoz2.Visible = true;
            }

            lbl_yazarsoz2.Text = "\"Bir fikir, zamanı geldiğinde insanı öldürebilir, ama asla öldüremez.\"";

        }

        private void btn_yazarsoz3_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz3.Visible)
            {
                lbl_yazarsoz3.Visible = false;
            }
            else
            {
                lbl_yazarsoz3.Visible = true;
            }

            lbl_yazarsoz3.Text = "\"Gerçeklik, direnen bir şey olduğunda, gerçek olmaktan çıkar.\"";

        }

        private void btn_yazarsoz5_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz5.Visible)
            {
                lbl_yazarsoz5.Visible = false;
            }
            else
            {
                lbl_yazarsoz5.Visible = true;
            }

            lbl_yazarsoz5.Text = "\"Gerçek karakter, zorluklar karşısında nasıl tepki verdiğinizde ortaya çıkar.\"";

        }

        private void btn_yazarsoz6_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz6.Visible)
            {
                lbl_yazarsoz6.Visible = false;
            }
            else
            {
                lbl_yazarsoz6.Visible = true;
            }

            lbl_yazarsoz6.Text = "\"Neyin gerçek olduğunu anlamak için, kurgunun sınırlarında dolaşmak gerekebilir.\"";

        }

        private void btn_yazarsoz7_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz7.Visible)
            {
                lbl_yazarsoz7.Visible = false;
            }
            else
            {
                lbl_yazarsoz7.Visible = true;
            }

            lbl_yazarsoz7.Text = "\"Gerçek dostluk, karanlık zamanlarda bile bizi aydınlatabilen bir mum gibidir.\"";

        }

        private void btn_yazarsoz8_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz8.Visible)
            {
                lbl_yazarsoz8.Visible = false;
            }
            else
            {
                lbl_yazarsoz8.Visible = true;
            }

            lbl_yazarsoz8.Text = "\"Empati dünyadaki en önemli silahtır.\"";

        }

        private void btn_yazarsoz9_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz9.Visible)
            {
                lbl_yazarsoz9.Visible = false;
            }
            else
            {
                lbl_yazarsoz9.Visible = true;
            }

            lbl_yazarsoz9.Text = "\"İnsanın iki vatanı vardır: biri doğduğu topraklar, diğeri okuduğu kitaplardır.\"";

        }

        private void btn_yazarsoz10_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz10.Visible)
            {
                lbl_yazarsoz10.Visible = false;
            }
            else
            {
                lbl_yazarsoz10.Visible = true;
            }

            lbl_yazarsoz10.Text = "\"Büyük sanat, her şeyi bir araya getirir: aşkı, tutkuyu, mantığı ve gerçeği.\"";

        }

        private void btn_yazarsoz11_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz11.Visible)
            {
                lbl_yazarsoz11.Visible = false;
            }
            else
            {
                lbl_yazarsoz11.Visible = true;
            }

            lbl_yazarsoz11.Text = "\"Büyük sorular sormak, büyük cevaplara yol açar.\"";

        }

        private void btn_yazarsoz12_Click(object sender, EventArgs e)
        {
            if (lbl_yazarsoz12.Visible)
            {
                lbl_yazarsoz12.Visible = false;
            }
            else
            {
                lbl_yazarsoz12.Visible = true;
            }

            lbl_yazarsoz12.Text = "\"Korkularınızla yüzleşin, çünkü onlar size gerçek özgürlüğü engelleyen zincirlerdir.\"";

        }
    }
}
