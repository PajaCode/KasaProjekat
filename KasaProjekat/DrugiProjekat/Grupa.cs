using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiProjekat
{
    class Grupa
    {
        private int id;
        private string naziv;
        public int ID { get { return id; } set { id = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }


        public Grupa()
        {

        }

        public Grupa(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;


        }
    }
}
