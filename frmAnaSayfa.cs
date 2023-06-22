using Guna.UI2.WinForms;
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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
            gorunumOzellestirme();
        }

        public string KullaniciAdi { get; set; } //kullaniciadini almak icin

        


        private void gorunumOzellestirme()
        {
            panelKitaplar.Visible = false;
            panelYazarlar.Visible = false;
            panelKirala.Visible = false;
            panel3.Visible = false; 
            pnlMesaj.Visible = false;
        }

        private void menuleriGizle()
        {
            if(panelKitaplar.Visible == true)
                panelKitaplar.Visible = false;
            if (panelYazarlar.Visible == true)
                panelYazarlar.Visible = false;
            if(panelKirala.Visible == true)
                panelKirala.Visible = false;
            if(panel3.Visible == true)
                panel3.Visible = false;
            if(pnlMesaj.Visible == true)
                pnlMesaj.Visible = false;        
        }
        
        private void menuleriGoster(Panel panel)
        {
            if(panel.Visible == false)
            {
                menuleriGizle();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

            label2.Text = KullaniciAdi;
            label3.Text = label2.Text;


            //BURADA KAPSÜLLEME YAPILDI!!!!
            toUpper buyut = new toUpper();
            buyut.BuyukYaz = label2.Text;
            label2.Text = buyut.BuyukYaz;
            buyut.BuyukYaz = label3.Text;
            label3.Text = buyut.BuyukYaz;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            menuleriGoster(panelKirala);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuleriGoster(panelKitaplar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kodlar
            openChildForm(new frmKitaplar());

            //menuleriGizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            pictureBox2.Visible = false;

            if (activeForm != null)
            {
                activeForm.Close();
            }
            panelMain.Show();
            frmAlintilar frmAlintilarFormu = new frmAlintilar();
            frmAlintilarFormu.TopLevel = false;
            frmAlintilarFormu.FormBorderStyle = FormBorderStyle.None;
            frmAlintilarFormu.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmAlintilarFormu);
            panelMain.Tag = frmAlintilarFormu;
            frmAlintilarFormu.textBox1.Text = label3.Text;
            frmAlintilarFormu.Show();

            /* frmAlintilar frmAlintilarFormu = new frmAlintilar();
             frmAlintilarFormu.TopLevel = false;
             frmAlintilarFormu.FormBorderStyle = FormBorderStyle.None;
             frmAlintilarFormu.Dock = DockStyle.Fill;
             panelMain.Controls.Add(frmAlintilarFormu);
             panelMain.Tag = frmAlintilarFormu;
             frmAlintilarFormu.textBox1.Text = label3.Text;
             frmAlintilarFormu.Show();*/

            /*frmAlintilar frmAlintilarFormu = new frmAlintilar();
            frmAlintilarFormu.textBox1.Text = label3.Text;
            frmAlintilarFormu.Show();*/

            //openChildForm(new frmAlintilar());

            //menuleriGizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFiyatlar());

            //menuleriGizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOneri());

            //menuleriGizle();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         //   menuleriGoster(panelMain);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menuleriGoster(panelYazarlar);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new frmYazarlar());

            //menuleriGizle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBilgiler());

            //menuleriGizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new frmYazarAlintilari());

            //menuleriGizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmFavYazarimiz());

            //menuleriGizle();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHesaplamaSihirbazi());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            menuleriGoster(panel3);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            menuleriGoster(pnlMesaj);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHakkimizda());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSSS());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMesaj());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/kayaserkan/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmKiralamaSorulari());
        }
    }
}
