using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        dataBaseCLASS database = new dataBaseCLASS(); //db çağrısı classtan

        OleDbCommand silVEYAguncelle = new OleDbCommand();
        private void Temizle()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }

            richTxtKonu.Text = "";
        }

        private void verileriGoruntule()
        {
            
            OleDbCommand komut = new OleDbCommand();
            komut.Connection= database.connection();
            komut.CommandText = ("Select *from kitaplar");
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem goster = new ListViewItem();
                goster.Text = dr["kitapID"].ToString();
                goster.SubItems.Add(dr["kitapAd"].ToString());
                goster.SubItems.Add(dr["kitapYazar"].ToString());
                goster.SubItems.Add(dr["kitapYayinEvi"].ToString());
                goster.SubItems.Add(dr["kitapBasimYili"].ToString());
                goster.SubItems.Add(dr["kitapKonu"].ToString());
                listView1.Items.Add(goster);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                OleDbCommand kayit = new OleDbCommand("INSERT INTO kitaplar (kitapAd, kitapYazar, kitapYayinEvi, kitapBasimYili, kitapKonu) VALUES (?, ?, ?, ?, ?)", database.connection());
                kayit.Parameters.AddWithValue("kitapAdParam", txtAd.Text);
                kayit.Parameters.AddWithValue("kitapYazarParam", txtYazar.Text);
                kayit.Parameters.AddWithValue("kitapYayinEviParam", txtYayinEvi.Text);
                kayit.Parameters.AddWithValue("kitapBasimYiliParam", txtYil.Text.ToString());
                kayit.Parameters.AddWithValue("kitapKonuParam", richTxtKonu.Text.ToString());

                kayit.ExecuteNonQuery();
                
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına kayıt eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //arama yapıyoruz

            
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = database.connection();
            komut.CommandText = ("Select * from kitaplar where kitapAd Like '%" + textBox6.Text + "%'");
            komut.CommandText = ("Select * from kitaplar where kitapID Like '%" + textBox5.Text + "%'");
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem goster = new ListViewItem();
                goster.Text = dr["kitapID"].ToString();
                goster.SubItems.Add(dr["kitapAd"].ToString());
                goster.SubItems.Add(dr["kitapYazar"].ToString());
                goster.SubItems.Add(dr["kitapYayinEvi"].ToString());
                goster.SubItems.Add(dr["kitapBasimYili"].ToString());
                goster.SubItems.Add(dr["kitapKonu"].ToString());
                listView1.Items.Add(goster);
            }
           



            /*OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from kitaplar where kitapID Like '"+textBox5.Text+"%'",connect);
            ds = new DataSet();*/
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            verileriGoruntule();
            button7.Visible = false;
            panel1.Visible = false;
            label11.Visible = false;
            txtID.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button4.Enabled = false;
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            
            silVEYAguncelle.Connection = database.connection();
            silVEYAguncelle.CommandText = "delete from kitaplar where kitapID = " + txtSil.Text+ "";
            silVEYAguncelle.ExecuteNonQuery();
            
            listView1.Items.Clear();
            verileriGoruntule();
            panel1.Visible=false;
            button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verileriGoruntule();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Güncellenecek kitabın adı : ";
            label2.Text = "Güncellenecek kitabın yazarı : ";
            label3.Text = "Güncellenecek kitabın yayın evi : ";
            label4.Text = "Güncellenecek kitabın basım yılı : ";
            label5.Text = "Güncellenek kitabın konusu : ";
            button2.Visible = false;
            button7.Visible = true;
            label11.Visible = true;
            txtID.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            silVEYAguncelle.Connection= database.connection();
            silVEYAguncelle.CommandText = "update kitaplar set kitapAd = '"+txtAd.Text+"', kitapYazar = '"+txtYazar.Text+"', kitapYayinEvi = '"+txtYayinEvi.Text+"', kitapBasimYili = '"+txtYil.Text+"', kitapKonu = '"+richTxtKonu.Text+"' where kitapID = "+txtID.Text+"";
            silVEYAguncelle.ExecuteNonQuery();
            
            
        }
    }
}
