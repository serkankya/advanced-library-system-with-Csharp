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
    public partial class frmYazarlar : Form
    {
        public frmYazarlar()
        {
            InitializeComponent();
        }

        private void btn_yazarbilgi_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi.Visible)
            {
                lbl_yazarbilgi.Visible = false;
            }
            else
            {
                lbl_yazarbilgi.Visible = true;
            }

            lbl_yazarbilgi.Text = "Sabahattin Ali, 1907 yılında doğan Türk yazar, öğretmen ve gazetecidir. Edebiyat hayatına şiirlerle başlamış olmasına rağmen, daha çok romanlarıyla tanınmaktadır. En ünlü eserleri arasında \"Kürk Mantolu Madonna\" ve \"İçimizdeki Şeytan\" bulunmaktadır.";

        }

        private void btn_yazarbilgi1_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi1.Visible)
            {
                lbl_yazarbilgi1.Visible = false;
            }
            else
            {
                lbl_yazarbilgi1.Visible = true;
            }

            lbl_yazarbilgi1.Text = "Yaşar Kemal, 1923 yılında doğan ve 2015 yılında vefat eden Türk yazar ve gazetecidir. Kürt kökenli olan Kemal, Türk edebiyatının en önemli yazarlarından biridir. Eserlerinde genellikle toplumsal adaletsizlik, köylü yaşamı, doğa sevgisi ve Kürt sorunu gibi konuları işlemiştir.";

        }

        private void btn_yazarbilgi2_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi2.Visible)
            {
                lbl_yazarbilgi2.Visible = false;
            }
            else
            {
                lbl_yazarbilgi2.Visible = true;
            }

            lbl_yazarbilgi2.Text = "Lev Tolstoy, 1828 yılında doğan Rus yazar, düşünür ve toplumsal aktivisttir. Edebiyat tarihindeki en önemli isimlerden biri olarak kabul edilir. Romanlarıyla ün kazanmış olan Tolstoy'un en tanınmış eserleri arasında \"Savaş ve Barış\" ile \"Anna Karenina\" bulunur. Tolstoy, insan doğasını, ahlaki değerleri, sınıf farklılıklarını ve kişisel arayışları derinlikli bir şekilde ele alan eserleriyle edebiyat dünyasında iz bırakmıştır.";

        }

        private void btn_yazarbilgi3_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi3.Visible)
            {
                lbl_yazarbilgi3.Visible = false;
            }
            else
            {
                lbl_yazarbilgi3.Visible = true;
            }

            lbl_yazarbilgi3.Text = "Albert Camus, 1913 yılında doğan Fransız yazar, filozof ve gazetecidir. Edebiyat dünyasında ve düşünce alanında önemli bir figür olarak kabul edilir. Camus'nün en ünlü eserleri arasında \"Yabancı\", \"Düşüş\" ve \"Veba\" yer alır. Felsefi ve absürt öğeleri eserlerinde birleştiren Camus, varoluşsal sorunlar, insanın anlam arayışı ve absurdite kavramı üzerine derinlemesine düşünceler sunmuştur.";

        }

        private void btn_yazarbilgi4_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi4.Visible)
            {
                lbl_yazarbilgi4.Visible = false;
            }
            else
            {
                lbl_yazarbilgi4.Visible = true;
            }

            lbl_yazarbilgi4.Text = "Anthony Burgess, 1917-1993 yılları arasında yaşamış İngiliz yazar ve bestecidir. En ünlü eseri olan \"A Clockwork Orange\" ile distopik bir gelecekteki şiddet ve özgürlük temalarını işlemiştir. Burgess, eserlerinde dil oyunlarına ve müzikaliteye büyük önem vermiş ve geniş bir eser yelpazesine sahip olmuştur.";

        }

        private void btn_yazarbilgi5_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi5.Visible)
            {
                lbl_yazarbilgi5.Visible = false;
            }
            else
            {
                lbl_yazarbilgi5.Visible = true;
            }

            lbl_yazarbilgi5.Text = "Fyodor Dostoyevski, 1821-1881 yılları arasında yaşamış Rus yazar ve filozoftur. Edebiyat tarihindeki en önemli figürlerden biri olarak kabul edilir. Dostoyevski'nin eserleri, insan psikolojisi, ahlaki çelişkiler, suç ve ceza gibi derin temaları ele alır ve Rus edebiyatının büyük bir mirasını oluşturur. En ünlü eserleri arasında \"Suç ve Ceza\", \"Karamazov Kardeşler\" ve \"Yeraltından Notlar\" bulunmaktadır.";

        }

        private void btn_yazarbilgi6_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi6.Visible)
            {
                lbl_yazarbilgi6.Visible = false;
            }
            else
            {
                lbl_yazarbilgi6.Visible = true;
            }

            lbl_yazarbilgi6.Text = "Oğuz Atay, 1934-1977 yılları arasında yaşamış olan Türk yazar ve mühendistir. Türk edebiyatında modernist bir yaklaşımı benimseyen Atay, \"Tutunamayanlar\" adlı romanıyla büyük bir etki yaratmıştır. Eserleri, bireysel kimlik krizi, toplumsal çelişkiler ve postmodern anlatım teknikleri üzerine derinlemesine düşünceler sunar ve Türk edebiyatının önemli bir dönüm noktasını temsil eder.";

        }

        private void btn_yazarbilgi7_Click(object sender, EventArgs e)
        {
            if (lbl_yazarbilgi7.Visible)
            {
                lbl_yazarbilgi7.Visible = false;
            }
            else
            {
                lbl_yazarbilgi7.Visible = true;
            }

            lbl_yazarbilgi7.Text = "Franz Kafka, 20. yüzyılın en etkileyici Alman dili yazarlarından biridir. Eserleri, bireyin varoluşsal sıkıntıları, yabancılaşma ve bürokrasi gibi temaları işler. En ünlü eseri \"Dönüşüm\", bir sabah böceğe dönüşen bir adamın hikayesini anlatır. Kafka'nın eserleri, çağdaş edebiyatın öncülerinden biri olarak kabul edilir ve kendine özgü bir atmosfer ve dil kullanımıyla tanınır.";

        }
    }
}
