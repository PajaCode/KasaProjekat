using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiProjekat
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ListaRacuna novaFrm = new ListaRacuna();
            novaFrm.TopLevel = false;
            panel2.Controls.Add(novaFrm);
            novaFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            novaFrm.Dock = DockStyle.Fill;
            novaFrm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            GrupeArtikalaFrm novaFrm = new GrupeArtikalaFrm();
            novaFrm.TopLevel = false;
            panel2.Controls.Add(novaFrm);
            novaFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            novaFrm.Dock = DockStyle.Fill;
            novaFrm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DodavanjeArtikalaGrupa novaFrm = new DodavanjeArtikalaGrupa();
            novaFrm.TopLevel = false;
            panel2.Controls.Add(novaFrm);
            novaFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            novaFrm.Dock = DockStyle.Fill;
            novaFrm.Show();
            
        }

        private void Fomr1_Load(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //RacunFrmcs fmr2 = new RacunFrmcs();
            /* fmr2.TopLevel = false;
             panel1.Controls.Add(fmr2);
             fmr2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
             fmr2.Dock = DockStyle.Fill;                   
             fmr2.Show();*/
          
        }

       
    }
}
