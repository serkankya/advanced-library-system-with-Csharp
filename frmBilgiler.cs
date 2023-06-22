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
    public partial class frmBilgiler : Form
    {
        public frmBilgiler()
        {
            InitializeComponent();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            string[] yazarBilgileri = {
        "Agatha Christie, tüm zamanların en çok satan yazarıdır ve 2 milyardan fazla kitap satmıştır.",
        "J.R.R. Tolkien, Yüzüklerin Efendisi'ni yazmak için kendi yaratmış olduğu dillerden başladı.",
        "Virginia Woolf, bir romanı olan Mrs Dalloway'i yazmak için sadece altı ay harcamıştır.",
        "Ernest Hemingway, yazarken genellikle ayakta durmayı tercih eder ve çalışma odasında ayakta yazmaya uygun bir platform inşa etmiştir.",
        "Jane Austen, başyapıtı Pride and Prejudice'ı tamamladığında henüz 21 yaşındaydı.",
        "George Orwell, 1984'ü yazarken tükenmez kalem kullanmıştır ve sayfalarını elinde çevirerek yazmayı tercih etmiştir.",
        "Maya Angelou, aynı zamanda bir şarkıcı, dansçı ve aktivistti. Ayrıca Martin Luther King Jr.'ın bir dostuydu.",
        "Leo Tolstoy, bir dönem sürekli rulet oynamış ve kazandığı paraları hayır kurumlarına bağışlamıştır.",
        "Emily Dickinson, şiirlerinin çoğunu yazmış olmasına rağmen, sadece yaşarken yedi şiirini yayınlamıştır.",
        "Gabriel Garcia Marquez, Yüzyıllık Yalnızlık romanını yazmak için altı yıl harcamıştır.",
        "Haruki Murakami, romanlarını yazarken düzenli olarak maraton koşar ve günde 10 km kadar koşmayı hedefler.",
        "Toni Morrison, Nobel Edebiyat Ödülü kazanan ilk Afrikalı Amerikalı kadın yazardır.",
        "Mark Twain, ilk olarak bir pilot olarak çalışmış ve gerçek adı Samuel Langhorne Clemens'dir.",
        "Italo Calvino, yazmaya başlamadan önce matematik eğitimi almıştır ve matematiği eserlerine sık sık entegre etmiştir.",
        "Chimamanda Ngozi Adichie, popüler bir TED konuşması olan \"Her Şeyi Tek Bir Hikayeyle Anlatma Tehlikesi\" ile tanınır.",
        "Miguel de Cervantes, Don Kişot adlı romanıyla edebiyat tarihindeki ilk modern romanı yazmıştır.",
        "Fyodor Dostoyevski, kumar bağımlılığı olan bir yazardı ve romanlarından kazandığı paraları hemen kaybederdi.",
        "Virginia Woolf, romanlarından ve denemelerinden çok az para kazanmasına rağmen, bağımsız bir yazar olarak kendi yayınevini kurmuştur.",
        "Hermann Hesse, Siddhartha'yı yazmak için birkaç yıl boyunca Hindistan ve Uzak Doğu kültürlerini incelemiştir.",
        "Jorge Luis Borges, edebiyat tarihindeki en önemli kısa hikaye yazarlarından biridir ve yazdığı birçok hikaye derlemesi vardır.",
        "Rabindranath Tagore, hem bir şair hem de bir müzisyendi ve 1913 yılında Nobel Edebiyat Ödülü'nü kazanan ilk Asyalıydı.",
        "H.G. Wells, bilim kurgu türünün önde gelen yazarlarından biridir ve Dünya Savaşları'nı ve gelecekteki teknolojik gelişmeleri tahmin ettiği eserleriyle tanınır.",
        "Louisa May Alcott, Küçük Kadınlar adlı romanını yazdıktan sonra, karakterlerin hikayelerini daha fazla anlatmak için bir devam kitabı olan Küçük Kadınlar Üzerine İkinci Evlilik'i yazmıştır.",
        "Homer, İlyada ve Odysseia gibi destanların yazarı olarak kabul edilir ve Antik Yunan edebiyatının en önemli figürlerinden biridir.",
        "Yukio Mishima, Japon edebiyatının önemli bir figürüdür ve aynı zamanda bir aktör ve yönetmendi. Kendini hara-kiri yaparak intihar etmiştir.",
        "Margaret Atwood, Distopya romanı olan Damızlık Kızın Öyküsü ile tanınır ve bu roman televizyon dizisi olarak da uyarlanmıştır.",
        "Albert Camus, Sisifos Söyleni adlı eseriyle tanınır ve varoluşçu felsefeyi edebiyata entegre eden önemli yazarlardan biridir.",
        "Edgar Allan Poe, gotik korku hikayeleriyle ün kazanmıştır ve modern dedektif hikayelerinin de öncülerinden biridir.",
        "Jules Verne, bilim kurgu ve macera romanlarının önde gelen yazarlarından biridir ve Dünya'nın Merkezine Seyahat ve 80 Günde Devr-i Alem gibi ünlü eserlere imza atmıştır.",
        "Voltaire, Aydınlanma döneminin önde gelen düşünürlerinden biridir ve ünlü romanı Candide ile tanınır.",
        "Oscar Wilde, ünlü oyunu Dorian Gray'in Portresi ve The Importance of Being Earnest gibi hiciv dolu eserleriyle tanınır."
    };

            Random random = new Random();
            int bilgiler = random.Next(0, 30);
            label1.Text = yazarBilgileri[bilgiler];
        }

        private void frmBilgiler_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
