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
    public partial class frmKitaplar : Form
    {
        public frmKitaplar()
        {
            InitializeComponent();
        }

        dataBaseCLASS database = new dataBaseCLASS();

        private void Verileri_yazdirma()
        {

            
            OleDbCommand komut = new OleDbCommand("Select *from kitaplar where kitapAd Like '%" + textBox1.Text + "%'", database.connection());
            OleDbDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                label5.Text = dr["kitapAd"].ToString();
                label6.Text = dr["kitapYazar"].ToString();
                label9.Text = dr["kitapYayinEvi"].ToString();
                richTextBox1.Text = dr["kitapKonu"].ToString();
            }
           

            if (label6.Text == "Sabahattin Ali")
            {
                pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\sabahattinali.jpg";
            }
            if (label6.Text == "Zülfü Livaneli")
            {
                pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\livaneli.jpg";
            }
            if (label6.Text == "Yaşar Kemal")
            {
                pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\yasarkemal.jpg";
            }
            if (label6.Text == "Fyodor Dostoyevski")
            {
                pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\dostoyevski.jpg";
            }
            if (label6.Text == "Lev Tolstoy")
            {
                pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\tolstoy.jpg";
            }

            /*
            OleDbCommand komut;
            OleDbDataReader oku;
            try
            {
                connect.Open();
                komut = new OleDbCommand();
                komut.CommandText = "Select * from kitaplar Order By  kitapAd Desc";
                komut.Connection = connect;
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    
                    label5.Text = oku[1].ToString();
                    label6.Text = oku[2].ToString();

                    

                    label9.Text = oku[3].ToString();
                    richTextBox1.Text = oku[5].ToString();
                    break;
                }
                connect.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 3)
            {
                MessageBox.Show("Girdiğiniz kitabın adı en az 3 harf içermek zorundadır!");
                textBox1.Clear();
            }
            else
            {

            

            Verileri_yazdirma();
            label5.Visible = true;
            label6.Visible = true;
            label9.Visible = true;
            richTextBox1.Visible = true;
                /*connect.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM kitaplar WHERE kitapAd LIKE '%" + textBox1.Text + "%'", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                label5.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                label6.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
                connect.Close();
                */


            }

        }

        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            richTextBox1.Visible = false;

            

            //label5.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            //label6.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
