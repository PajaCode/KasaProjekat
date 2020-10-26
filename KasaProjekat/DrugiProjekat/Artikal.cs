using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    class Artikal
    {
        private int id;
        private string naziv;
        private float cena;
        private float popust;
        private int kolicina;

        public int ID { get { return id; } set { id = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
        public float Cena { get { return cena; } set { cena = value; } }
        public float Popust { get { return popust; } set { popust = value; } }
        public int Kolicina { get { return kolicina; } set { kolicina = value; } }

        public Artikal()
        {

        }

        public Artikal(int id, string naziv, float cena, float popust)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;

        }
        public override string ToString()
        {
            return this.naziv + "  Cena:" + this.cena + "din" + "  Popust:" + this.popust + "%" + " Cena sa popustom:" + (this.cena - ((this.cena / 100) * this.popust)).ToString() + "din ";
        }



    }
}
