using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace
{
    class Zbozi
    {


        public int Id { get; set; }
        public string Nazev { get; set; }
        public int Cena { get; set; }
        public Boolean NaSklade { get; set; }


        public Zbozi(string nazev, int cena, Boolean naSklade)
        {
            Nazev = nazev;
            Cena = cena;
            NaSklade = naSklade;
        }

        public Zbozi(int id, string nazev, int cena, Boolean naSklade)
        {
            Id = id;
            Nazev = nazev;
            Cena = cena;
            NaSklade = naSklade;
        }
        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Nazev, Cena.ToString(), NaSklade.ToString() });
        }
    }
}
