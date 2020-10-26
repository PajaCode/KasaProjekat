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

namespace DrugiProjekat
{
    public partial class DodavanjeArtikalaGrupa : Form
    {
        Baza baza;
        List<Grupa> lista;
        public DodavanjeArtikalaGrupa()
        {
            InitializeComponent();
            baza = new Baza();
            lista = new List<Grupa>();
        }

       
        private void proveraListe()
        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT * FROM Grupa";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Grupa grp = new Grupa();
                grp.ID = int.Parse(reader["id_grupa"].ToString());
                grp.Naziv = reader["naziv"].ToString();


                lista.Add(grp);
            }

            LSBgrupa.DataSource = lista;
            LSBgrupa.DisplayMember = "naziv";
            LSBgrupa.ValueMember = "id";
            baza.ZatvoriKonekciju();

        }
        private void otkljucavanjeDugmeta()
        {
            if (LSBgrupa.DataSource != null)
            {
                DodajArtikalBtn.Enabled = true;
                PregledBtn.Enabled = true;
            }
        }

        private void Procitaj()

        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();


            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT Artikal.naziv,Artikal.cena,Artikal.popust FROM Artikal, Clanovi, Grupa WHERE Grupa.naziv = @naziv " +
                "AND Grupa.id_grupa = Clanovi.id_grupa AND Clanovi.id_artikla = Artikal.id_artikla  ";
            cmd.Parameters.AddWithValue("@naziv", lista[LSBgrupa.SelectedIndex].Naziv);

            OleDbDataReader reader = cmd.ExecuteReader();
            string str = "";
            while (reader.Read())
            {

                //str += reader["id_artikla"].ToString();
                //str += " ";
                str += reader["naziv"].ToString();
                str += " :";
                str += reader["cena"].ToString();
                str += " ,";
                str += reader["popust"].ToString()+"%";
                str += Environment.NewLine;
            }
            baza.ZatvoriKonekciju();
            MessageBox.Show(str);


        }

       
        private void DodajArtikalBtn_Click_1(object sender, EventArgs e)
        {
            NoviArtikal novaFrm = new NoviArtikal();
            novaFrm.Naziv_grupe = lista[LSBgrupa.SelectedIndex].Naziv;

            novaFrm.ShowDialog();
        }

        private void PregledBtn_Click_1(object sender, EventArgs e)
        {
            Procitaj();
        }

        private void DodavanjeArtikalaGrupa_Load_1(object sender, EventArgs e)
        {
            proveraListe();
            otkljucavanjeDugmeta();
        }
    }
}
