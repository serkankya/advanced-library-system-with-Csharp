using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KutuphaneProjesi
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        dataBaseCLASS dbClass = new dataBaseCLASS();


        private void frmKayit_Load(object sender, EventArgs e)
        {
            dogrulamaKarakterleri();
            
        }

        private void dogrulamaKarakterleri()
        {
            string[] karakterler = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "?", "!", "-", "+" };
            Random r = new Random();
            string dogrulama = "";

            for (int i = 0; i < 5; i++)
            {
                string randomKarakter = karakterler[r.Next(karakterler.Length)];
                dogrulama += randomKarakter;
            }

            label11.Text = dogrulama;
        }

        private void txtK_Adi_TextChanged(object sender, EventArgs e)
        {
            
            
           /*if (txtK_Adi.Text == "Kullanıcı adınızı oluşturunuz")
                txtK_Adi.Text = "";
            if (txtSifre.Text == "")
                txtSifre.Text = "Sifrenizi oluşturunuz";
            if (txtMail.Text == "")
                txtMail.Text = "E-mail adresinizi giriniz";
            if (txtTelNo.Text == "")
                txtTelNo.Text = "Telefon numaranızı giriniz";*/
            
        }

        private void txtK_Adi_Click(object sender, EventArgs e)
        {
            if (txtK_Adi.Text == "Kullanıcı adınızı oluşturunuz")
                txtK_Adi.Text = "";
            if (txtSifre.Text == "")
                txtSifre.Text = "Şifrenizi oluşturunuz";
            if (txtMail.Text == "")
                txtMail.Text = "E-mail adresinizi giriniz";
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifrenizi oluşturunuz")
                txtSifre.Text = "";
            if (txtK_Adi.Text == "")
                txtK_Adi.Text = "Kullanıcı adınızı oluşturunuz";
            if (txtMail.Text == "")
                txtMail.Text = "E-mail adresinizi giriniz";
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "E-mail adresinizi giriniz")
                txtMail.Text = "";
            if (txtK_Adi.Text == "")
                txtK_Adi.Text = "Kullanıcı adınızı oluşturunuz";
            if (txtSifre.Text == "")
                txtSifre.Text = "Şifrenizi oluşturunuz";
        }

        private void maskedTxtTelNo_Click(object sender, EventArgs e)
        {
            if (txtK_Adi.Text == "")
                txtK_Adi.Text = "Kullanıcı adınızı oluşturunuz";
            if (txtSifre.Text == "")
                txtSifre.Text = "Şifrenizi oluşturunuz";
            if (txtMail.Text == "")
                txtMail.Text = "E-mail adresinizi giriniz";
        }

        private void maskedTxtDogumTarih_Click(object sender, EventArgs e)
        {
            if (txtK_Adi.Text == "")
                txtK_Adi.Text = "Kullanıcı adınızı oluşturunuz";
            if (txtSifre.Text == "")
                txtSifre.Text = "Şifrenizi oluşturunuz";
            if (txtMail.Text == "")
                txtMail.Text = "E-mail adresinizi giriniz";
        }


        private int k_adiVarMi(string isimAra)
        {
            OleDbConnection connect = dbClass.connection();
            int sonuc;
            string sorgu = "Select COUNT(k_adi) from kullanicilar WHERE k_adi='" + isimAra + "'";
            OleDbCommand command = new OleDbCommand(sorgu, connect);
            
            sonuc = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();
            return sonuc;
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = dbClass.connection();
            if (label11.Text != textBox1.Text)
            {
                MessageBox.Show("Lütfen doğrulama karakterlerini tekrar kontrol ediniz.");
                dogrulamaKarakterleri();
            }
            else
            {
                if (k_adiVarMi(txtK_Adi.Text) != 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılmaktadır. Lütfen başka bir kullanıcı adı seçiniz.");
                }
                else
                {
                    
                    OleDbCommand kayit = new OleDbCommand("Insert Into kullanicilar (k_adi,sifre,mail,telNo,dogumTarihi) values ('" + txtK_Adi.Text + "','" + txtSifre.Text + "','" + txtMail.Text + "','" + maskedTxtTelNo.Text + "','" + maskedTxtDogumTarih.Text + "')", connect);
                    kayit.ExecuteNonQuery();
                    connect.Close();

                    frmGiris login = new frmGiris();
                    this.Hide();
                    login.Show();
                }
            }
            
            
        }

        private void maskedTxtTelNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
