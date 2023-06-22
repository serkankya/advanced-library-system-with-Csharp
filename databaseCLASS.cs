using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KutuphaneProjesi
{
    class dataBaseCLASS //BU CLASS SAYESİNDE HER FORMDA VERİTABANI TANIMLAMASI YAPMAMIZA GEREK KALMADI, AYRICA DOSYA PAYLAŞIMI KOLAYLAŞTI
    {
        public OleDbConnection connection()
        {
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\VisualStudio projects\\KutuphaneProjesi\\KutuphaneProjesi\\bin\\Debug\\kutuphaneProjesi.mdb");
            connect.Open();
            return connect;
        }

    }
}
