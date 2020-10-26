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
    public partial class NoviArtikal : Form
    {
        Baza baza;

        private string naziv_grupe;
        public NoviArtikal()
        {
            baza = new Baza();
            InitializeComponent();
        }

        public string Naziv_grupe { get { return naziv_grupe; } set { naziv_grupe = value; } }

        private void napraviArtikal()
        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = baza.Conn;

            cmd.CommandText = @"INSERT INTO Artikal(naziv,cena,popust)     
                 VALUES (@naziv,@cena,@popust)";
            cmd.Parameters.AddWithValue("naziv", textBox1.Text);
            cmd.Parameters.AddWithValue("cena", float.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("popust", float.Parse(textBox3.Text));
            int uspesno = cmd.ExecuteNonQuery();
            if (uspesno > 0)
            { MessageBox.Show("Artikal dodat"); }
            else
            { MessageBox.Show("Greska"); }
            baza.ZatvoriKonekciju();

        }


        private int PronadjiArtikal()
        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT id_artikla FROM Artikal WHERE naziv=@naziv AND cena=@cena AND popust=@popust";
            cmd.Parameters.AddWithValue("@naziv", textBox1.Text);
            cmd.Parameters.AddWithValue("@cena", textBox2.Text);
            cmd.Parameters.AddWithValue("@popust", textBox3.Text);


            OleDbDataReader reader = cmd.ExecuteReader();
            int id_art = -1;

            while (reader.Read())

            {
                id_art = int.Parse(reader["id_artikla"].ToString());
            }



            baza.ZatvoriKonekciju();

            return id_art;
        }


        private int PronadjiGrupu()
        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT id_grupa FROM Grupa WHERE naziv=@naziv ";
            cmd.Parameters.AddWithValue("@naziv", naziv_grupe.ToString());

            OleDbDataReader reader = cmd.ExecuteReader();
            int id_grp = -1;
            while (reader.Read())
            {

                id_grp = int.Parse(reader["id_grupa"].ToString());

            }

            baza.ZatvoriKonekciju();

            return id_grp;
        }
        private void Povezi()
        {
            int artID = PronadjiArtikal();

            int grpID = PronadjiGrupu();


            if (artID != -1 && grpID != -1)
            {


                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = @"INSERT INTO Clanovi(id_artikla,id_grupa)     
                 VALUES (@id_artikla,@id_grupa)";
                cmd.Parameters.AddWithValue("@id_artikla", artID);
                cmd.Parameters.AddWithValue("@id_grupa", grpID);
                int Uspesno = cmd.ExecuteNonQuery();
                baza.ZatvoriKonekciju();
            }
            else { MessageBox.Show("Greska pri povezivanju!!!"); }
        }
        private void Procitaj()

        {
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();


            cmd.Connection = baza.Conn;
            cmd.CommandText = "SELECT id_artikla FROM Artikal WHERE naziv=@naziv";
            cmd.Parameters.AddWithValue("@naziv", textBox1.Text);

            OleDbDataReader reader = cmd.ExecuteReader();
            string str = "";
            while (reader.Read())
            {

                str += reader["id_artikla"].ToString();
                //str += " ";
                //str += reader["naziv"].ToString();
                //str += " ";
                //str += reader["cena"].ToString();
                //str += " ";
                //str += reader["popust"].ToString();
                str += Environment.NewLine;
            }
            baza.ZatvoriKonekciju();
            MessageBox.Show(str + naziv_grupe);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                bool uspesno = float.TryParse(textBox2.Text, out float a);
                bool uspesno1 = float.TryParse(textBox3.Text, out float b);
                if (uspesno == true && uspesno1 == true)
                {
                    napraviArtikal();
                    //Procitaj();
                    Povezi();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pogresan unos!!!");
                }

            }
            else
            {
                MessageBox.Show("Popunite sva polja!!!");
            }
        }
    }
}

