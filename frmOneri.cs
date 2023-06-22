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
    public partial class frmOneri : Form
    {
        public frmOneri()
        {
            InitializeComponent();
        }

        /* OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\kutuphaneProjesi.mdb\"");
         int kS;

         public void kitapSayisi()
         {
             connect.Open();
             OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM kitaplar",connect);
             kS = int.Parse(command.ExecuteScalar().ToString());
             connect.Close();
         }

         public void oner()
         {
             connect.Open();
             Random r = new Random();
             OleDbCommand komut = new OleDbCommand("SELECT * FROM kitaplar where kitapID='" + r.Next(1, kS + 1) + "'", connect);
             var kitapsec = komut.ExecuteReader();
             while (kitapsec.Read())
             {
                 label2.Text = kitapsec["kitapAd"].ToString();
                 label3.Text = kitapsec["kitapKonu"].ToString();
             }
             connect.Close();
         }*/

        dataBaseCLASS database = new dataBaseCLASS();

        private int[] GetKitapIDListesi()
        {
            int kitapSayisi = 0;

            try
            {
                

                OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM kitaplar", database.connection());
                kitapSayisi = Convert.ToInt32(command.ExecuteScalar());

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı veya sorgu işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                database.connection().Close();
            }

            int[] kitapIDListesi = new int[kitapSayisi];
            int index = 0;

            try
            {
                
                OleDbCommand command = new OleDbCommand("SELECT kitapID FROM kitaplar", database.connection());
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int kitapID = Convert.ToInt32(reader["kitapID"]);
                    kitapIDListesi[index] = kitapID;
                    index++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı veya sorgu işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                database.connection().Close();
            }

            return kitapIDListesi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label5.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;


            int[] kitapIDListesi = GetKitapIDListesi();

            if (kitapIDListesi.Length > 0)
            {
                Random r = new Random();
                int randomIndex = r.Next(0, kitapIDListesi.Length);
                int kitapID = kitapIDListesi[randomIndex];

                string kitapAd = "";
                string kitapKonu = "";
                string kitapYazar = "";

                GetKitapBilgileri(kitapID, out kitapAd, out kitapKonu, out kitapYazar);

                

                label2.Text = kitapAd;
                richTextBox1.Text = kitapKonu;
                label5.Text = kitapYazar;

                if (label5.Text == "Sabahattin Ali")
                {
                    pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\sabahattinali.jpg";
                }
                if (label5.Text == "Zülfü Livaneli")
                {
                    pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\livaneli.jpg";
                }
                if (label5.Text == "Yaşar Kemal")
                {
                    pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\yasarkemal.jpg";
                }
                if (label5.Text == "Fyodor Dostoyevski")
                {
                    pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\dostoyevski.jpg";
                }
                if (label5.Text == "Lev Tolstoy")
                {
                    pictureBox1.ImageLocation = "D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\tolstoy.jpg";
                }
                

            }
            else
            {
                MessageBox.Show("Veritabanında hiç kitap bulunamadı.");
            }
        }


        private void GetKitapBilgileri(int kitapID, out string kitapAd, out string kitapKonu, out string kitapYazar)
        {
            kitapAd = "";
            kitapKonu = "";
            kitapYazar = "";
            string sorgula = $"SELECT kitapAd, kitapKonu, kitapYazar FROM kitaplar WHERE kitapID = {kitapID}";
            

            try
            {
                

                OleDbCommand command = new OleDbCommand(sorgula, database.connection());
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    kitapAd = reader["kitapAd"].ToString();
                    kitapKonu = reader["kitapKonu"].ToString();
                    kitapYazar = reader["kitapYazar"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı veya sorgu işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                database.connection().Close();
            }

            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmOneri_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label5.Visible = false;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
        }
    }
    }

