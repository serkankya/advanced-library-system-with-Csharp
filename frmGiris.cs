using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Guna.UI2.WinForms;

namespace KutuphaneProjesi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        dataBaseCLASS database = new dataBaseCLASS();       

        private void Temizle()
        {
            guna2TextBox1.Text = "Kullanıcı adınızı giriniz";
            guna2TextBox2.Text = "Şifrenizi giriniz";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            


            if (guna2TextBox1.Text == "admin" && guna2TextBox2.Text=="admin")
            {
                frmAdmin adminPage = new frmAdmin();
                this.Hide();
                adminPage.Show();
            }
            else
            {
                if (guna2TextBox1.Text == "" || guna2TextBox1.Text == "Kullanıcı adınızı giriniz")
                {

                    MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi giriniz!");
                    Temizle();
                }
                else if (guna2TextBox2.Text == "" || guna2TextBox2.Text == "Şifrenizi giriniz")
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi giriniz!");
                    Temizle();
                }

                try
                {
                    
                    OleDbCommand sorgu = new OleDbCommand("select k_adi,sifre from kullanicilar where k_adi = @ad and sifre = @sifre", database.connection());
                    sorgu.Parameters.AddWithValue("@ad", guna2TextBox1.Text);
                    sorgu.Parameters.AddWithValue("@soyad", guna2TextBox2.Text);

                    OleDbDataReader dr;
                    dr = sorgu.ExecuteReader();

                    if (dr.Read())
                    {
                        frmAnaSayfa main = new frmAnaSayfa();


                        main.KullaniciAdi = guna2TextBox1.Text; //gönderdik

                        this.Visible = false;

                        main.Show();
                        
                    }
                    else
                    {
                        
                        MessageBox.Show("Yanlış kullanıcı adı veya şifre!");
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                }
                finally
                {
                    Temizle();
                }

            }
            

        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text=="Kullanıcı adınızı giriniz")
            {
                guna2TextBox1.Text = "";
            }

            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "Şifrenizi giriniz";
            }
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Şifrenizi giriniz")
            {
                guna2TextBox2.Text = "";
            }

            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = "Kullanıcı adınızı giriniz";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*frmAnaSayfa anaSayfa = new frmAnaSayfa();
            ((Guna2TextBox)anaSayfa.Controls["label2"]).Text = "guna2TextBox1.Text";
            anaSayfa.Show();
            */
            
        }

        

        private void guna2ControlBox1_MouseLeave(object sender, EventArgs e)
        {
            guna2ControlBox1.FillColor = Color.Indigo;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_MouseMove(object sender, MouseEventArgs e)
        {
            guna2ControlBox1.FillColor = Color.DarkRed;
        }

        private void guna2ControlBox2_MouseMove(object sender, MouseEventArgs e)
        {
            guna2ControlBox2.FillColor = Color.DarkRed;
        }

        private void guna2ControlBox2_MouseLeave(object sender, EventArgs e)
        {
            guna2ControlBox2.FillColor = Color.Indigo;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmKayit kayit = new frmKayit();
            //((Label)kayit.Controls["label1"]).Text = "merhaba";
            this.Hide();
            kayit.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/kayaserkan/");
        }
    }
}
