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
    public partial class frmAlintilar : Form
    {
        public frmAlintilar()
        {
            InitializeComponent();
        }

        dataBaseCLASS dbClass = new dataBaseCLASS();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlintilar_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            textBox1.Enabled = false;

            guna2Button3.Visible = true;

            OleDbConnection connection = dbClass.connection();


            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT kitapAd, kitapYazar FROM kitaplar";


            OleDbDataReader reader = command.ExecuteReader();


            comboBox1.Items.Clear();
            comboBox2.Items.Clear();


            while (reader.Read())
            {
                string kitapAd = reader["kitapAd"].ToString();
                string kitapYazar = reader["kitapYazar"].ToString();
                comboBox1.Items.Add(kitapAd);
                comboBox2.Items.Add(kitapYazar);
            }


            reader.Close();
            connection.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" && comboBox2.Text == "" && richTextBox1.Text.Length < 6 || comboBox1.Text == "" || comboBox1.Text =="" || richTextBox1.Text.Length < 6)
            {
                MessageBox.Show("Lütfen boşlukları doldurduğunuzdan emin olun. Alıntınız paylaşılamadı.");
                comboBox1.Text = "";
                comboBox2.Text = "";
                richTextBox1.Text = "";
            }
            else
            {

            

            OleDbConnection connection = dbClass.connection();

            string kitabinAdi = comboBox1.Text;
            string yazarinAdi = comboBox2.Text;
            string k_alinti = richTextBox1.Text;
            string alinti_paylasan = textBox1.Text;

            try
            {
                
                OleDbCommand alintiKaydet = new OleDbCommand("INSERT INTO alintilar (kitap, yazar, alinti, paylasan) VALUES (?, ?, ?, ?)", connection);
                alintiKaydet.Parameters.AddWithValue("kitabinAdi", kitabinAdi);
                alintiKaydet.Parameters.AddWithValue("yazarinAdi", yazarinAdi);
                alintiKaydet.Parameters.AddWithValue("k_alinti", k_alinti);
                alintiKaydet.Parameters.AddWithValue("alinti_paylasan", alinti_paylasan);

                alintiKaydet.ExecuteNonQuery();

                MessageBox.Show("Alıntınız paylaşıldı.");

                comboBox1.Text = "";
                comboBox2.Text = "";
                richTextBox1.Text = "";

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata: " + hata.Message);
            }
            finally
            {
                connection.Close();
            }
            }
        }
        private OleDbDataReader dr; 


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length < 3)
            {
                MessageBox.Show("Girdiğiniz alıntı en az 3 harf içermek zorundadır.");
                textBox2.Clear();
            }
            else
            {

            
    
            


            OleDbConnection connection = dbClass.connection();

            OleDbCommand goster = new OleDbCommand("SELECT * FROM alintilar WHERE kitap LIKE '%" + textBox2.Text + "%' OR yazar LIKE '%" + textBox2.Text + "%' OR alinti LIKE '%" + textBox2.Text + "%'", connection);
            dr = goster.ExecuteReader();

            if (dr.Read()) 
            {
                alintiGoster(); 
                    
            guna2Button3.Visible = true;


            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            }
                else
                {
                    MessageBox.Show("Maalesef eşleşen bir alıntı bulunamadı.");
                    textBox2.Clear();
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dr != null && dr.Read()) //boş yani yoksa geç
            {
                alintiGoster();

            }
            
        }
        private void alintiGoster()
        {
            label1.Text = dr["kitap"].ToString();
            label2.Text = dr["yazar"].ToString();
            label3.Text = dr["alinti"].ToString();
            label4.Text = dr["paylasan"].ToString();
        }
    }
}
