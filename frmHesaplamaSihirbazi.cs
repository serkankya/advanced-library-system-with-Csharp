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
    public partial class frmHesaplamaSihirbazi : Form
    {
        public frmHesaplamaSihirbazi()
        {
            InitializeComponent();
        }

        private void frmHesaplamaSihirbazi_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            
        }

        private void guna2ComboBox1_Click(object sender, EventArgs e)
        {
            label1.Visible= false;
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Kitabın kaç gün sizde kalacağını giriniz.";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
        }

        private void frmHesaplamaSihirbazi_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Kitabın kaç gün sizde kalacağını giriniz.";
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            label3.Visible = true;

            int gun = int.Parse(txtSifre.Text);
            string tur = guna2ComboBox1.SelectedItem.ToString();

            Fiyatlandirma fiyatlandirma;

            switch (tur)
            {
                case "Normal Üye":
                    fiyatlandirma = new NormalUyeFiyatlandirma();
                    break;
                case "Lisans":
                case "Önlisans":
                    fiyatlandirma = new LisansFiyatlandirma();
                    break;
                case "Lisans Üstü":
                    fiyatlandirma = new LisansUstuFiyatlandirma();
                    break;
                case "Akademik Personel":
                case "İdari Personel":
                    fiyatlandirma = new AkademikPersonelFiyatlandirma();
                    break;
                default:
                    MessageBox.Show("Geçersiz tür seçimi!");
                    return;
            }

            double fiyat = fiyatlandirma.FiyatHesapla(gun);
            label3.Text = fiyat.ToString();
        }
    }
}
