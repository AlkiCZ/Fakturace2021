using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace
{
   public class Zakaznik
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Typ { get; set; }
        public string Adresa { get; set; }
        public int Ico { get; set; }
        public string Mail { get; set; }
        public int Telefon { get; set; }

        public Zakaznik(int id, string jmeno, string typ, string adresa, int ico, string mail, int telefon)
        {
            Id = id;
            Jmeno = jmeno;
            Typ = typ;
            Adresa = adresa;
            Ico = ico;
            Mail = mail;
            Telefon = telefon;
        }
        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Jmeno, Typ, Adresa, Ico.ToString(), Mail, Telefon.ToString() });
        }
    }
}
