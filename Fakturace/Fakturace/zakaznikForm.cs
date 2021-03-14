using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace
{
    public partial class zakaznikForm : Form
    {
        private List<Zakaznik> zakaznik;
        private SqlRepo sqlRepo;
        private string[] sloupce = new string[] { "IdZakaznik", "Jmeno", "ICO", "Email", "Telefon" };
        private int sloupecTrideni = 0;
        private bool sestupne;
        public zakaznikForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fakturace1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void zakaznikForm_Load(object sender, EventArgs e)
        {
            ZobrazData();
        }


        private void ZobrazData()
        {
            zakaznik = sqlRepo.NactiZakaznik(sloupce[sloupecTrideni], sestupne, hledat.Text);
            listView1.Items.Clear();
            foreach (var zakaznik in zakaznik)
            {
                listView1.Items.Add(zakaznik.GetListViewItem());
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == sloupecTrideni)
            {
                sestupne = !sestupne;
            }
            sloupecTrideni = e.Column;
            ZobrazData();
        }
    }
}