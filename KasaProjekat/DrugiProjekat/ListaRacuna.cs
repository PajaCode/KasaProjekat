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

namespace DrugiProjekat
{
    public partial class ListaRacuna : Form
    {
        Baza baza;
        List<Racun> lista;
        public ListaRacuna()
        {
            InitializeComponent();
            baza = new Baza();
            lista = new List<Racun>();
        }
        private void proveraListe()
        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT * FROM Racun";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Racun racun = new Racun();
                racun.ID = int.Parse(reader["id_racun"].ToString());
                racun.UkupnaCena = float.Parse(reader["cena"].ToString());
                racun.DatumIzdavanja = DateTime.Parse(reader["datum"].ToString());
                racun.VremeIzdavanja = DateTime.Parse(reader["vreme"].ToString());

                lista.Add(racun);
            }

            LSBRacuna.DataSource = lista;
            LSBRacuna.DisplayMember = ToString();

            baza.ZatvoriKonekciju();
        }

        private void ListaRacuna_Load(object sender, EventArgs e)
        {
            proveraListe();
        }
    }

}
