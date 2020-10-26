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
    public partial class GrupeArtikalaFrm : Form
    {

        Baza baza;
        List<Grupa> grupe;
        List<Artikal> artikli;
        RacunFrmcs novaRacun = new RacunFrmcs();
        int kol;

        public GrupeArtikalaFrm()
        {

            InitializeComponent();
            baza = new Baza();
            grupe = new List<Grupa>();
            artikli = new List<Artikal>();


        }


        
        private string vratiSelektovaniNazivArt()
        {
            return artikli[LSBArtikal.SelectedIndex].Naziv;
        }
        private float vratiSelektovanuCenuArt()
        {
            return artikli[LSBArtikal.SelectedIndex].Cena;
        }
        private float vratiSelektovaniPopustArt()
        {
            return artikli[LSBArtikal.SelectedIndex].Popust;
        }
        private void ucitajLSBGrupa()
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


                grupe.Add(grp);
            }
            baza.ZatvoriKonekciju();
            LSBGrupa.DataSource = grupe;
            LSBGrupa.DisplayMember = "naziv";
            LSBGrupa.ValueMember = "id";


        }
        private void ucitajLSBArtikal()
        {
            artikli = new List<Artikal>();
            LSBArtikal.DataSource = null;

            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT Artikal.id_artikla,Artikal.naziv,Artikal.cena,Artikal.popust FROM Artikal, Clanovi, Grupa WHERE Grupa.naziv = @naziv AND Grupa.id_grupa = Clanovi.id_grupa AND Clanovi.id_artikla = Artikal.id_artikla; ";
            cmd.Parameters.AddWithValue("@naziv", grupe[LSBGrupa.SelectedIndex].Naziv);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Artikal art = new Artikal();
                art.ID = int.Parse(reader["id_artikla"].ToString());
                art.Naziv = reader["naziv"].ToString();
                art.Cena = float.Parse(reader["cena"].ToString());
                art.Popust = float.Parse(reader["popust"].ToString());


                artikli.Add(art);
            }
            baza.ZatvoriKonekciju();



            LSBArtikal.DataSource = artikli;
            LSBArtikal.DisplayMember = ToString();
        }

        private void proveraDodajBtn()
        {
            if (LSBArtikal.DataSource != null && LSBArtikal.SelectedValue != null)
            {
                Dodaj.Enabled = true;
            }
            else
            {
                Dodaj.Enabled = false;
            }
        }
        private void napraviRacun()
        {

            novaRacun.Show();
        } 

        private void Dodaj_Click_1(object sender, EventArgs e)
        {
            Kolicinacs novaFrm = new Kolicinacs();
            if (novaFrm.ShowDialog() == DialogResult.OK)
            {
                if (novaFrm.Uspesno)
                {
                    kol = novaFrm.KolicinaGS;
                    novaRacun.dodajArtikalNaRacun(vratiSelektovaniNazivArt(), vratiSelektovanuCenuArt(), vratiSelektovaniPopustArt(), kol);
                }
            }
        }

        private void GrupeArtikalaFrm_Load_1(object sender, EventArgs e)
        {
            napraviRacun();
            ucitajLSBGrupa();
            ucitajLSBArtikal();
            proveraDodajBtn();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (novaRacun.proveraRacuna())
            {
                novaRacun.sacuvajRacun();
                MessageBox.Show("Racun je sacuvan!!!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Vas Racun je prazan!!!");
            }
        }

        private void LSBGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajLSBArtikal();
            proveraDodajBtn();
        }

       private void GrupeArtikalaFrm_Shown(object sender, EventArgs e)
        {
            napraviRacun();
        }

       /* private void GrupeArtikalaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            novaRacun.Close();
        }*/
    }
}

