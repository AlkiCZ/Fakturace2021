using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace
{
    class Zbozi
    {


        public int Id { get; set; }
        public string Nazev { get; set; }
        public float Cena { get; set; }
        public Boolean Skladem { get; set; }

        public Zbozi(int id, string nazev, float cena, bool skladem)
        {
            Id = id;
            Nazev = nazev;
            Cena = cena;
            Skladem = skladem;
        }
    }
}
