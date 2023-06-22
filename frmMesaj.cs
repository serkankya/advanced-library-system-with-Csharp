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
    public partial class frmMesaj : Form
    {
        public frmMesaj()
        {
            InitializeComponent();
        }

        dataBaseCLASS dbClass = new dataBaseCLASS();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                
            

            OleDbConnection connection = dbClass.connection();

            try
            {
                OleDbCommand mesajKaydet = new OleDbCommand("Insert into mesajlar (mesaj,mail) values (? , ?)", connection);

                mesajKaydet.Parameters.AddWithValue("gonderilenMesaj", richTextBox1.Text);
                mesajKaydet.Parameters.AddWithValue("mailAdresi", textBox1.Text);

                mesajKaydet.ExecuteNonQuery();
                MessageBox.Show("Mesajınız başarıyla gönderildi!");
                richTextBox1.Clear();
                textBox1.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu. Hata : " + hata);
            }

            
        }
    }
}
