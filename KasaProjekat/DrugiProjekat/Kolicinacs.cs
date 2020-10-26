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
    public partial class Kolicinacs : Form
    {
        
            private bool uspesno;
            private int kolicina;
            public Kolicinacs()
            {
                InitializeComponent();
            }
            public int KolicinaGS { get { return kolicina; } set { kolicina = value; } }
            public bool Uspesno { get { return uspesno; } set { uspesno = value; } }
           

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                uspesno = int.TryParse(textBox1.Text, out int a);
                if (uspesno)
                {
                    kolicina = int.Parse(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Pogresan unos!!!");
                }

            }
            else
            {
                MessageBox.Show("Popuni polje za kolicinu!!!");
            }
        }
    }
    }
