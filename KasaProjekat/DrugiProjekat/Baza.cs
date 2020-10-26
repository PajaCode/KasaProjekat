using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DrugiProjekat
{
    class Baza
    {
        OleDbConnection conn;

        public Baza()
        {
            this.conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Munja\Downloads\KasaProjekat\DrugiProjekat\Baza.accdb";
        }
        public void OtvoriKonekciju()
        {
            if (conn != null)
            {
                conn.Open();
            }
        }
        public void ZatvoriKonekciju()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        public OleDbConnection Conn
        { get { return conn; } set { conn = value; } }
    }
}
