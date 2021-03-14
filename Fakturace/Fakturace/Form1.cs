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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZakaznici_Click(object sender, EventArgs e)
        {
            zakaznikForm zakaznikForm = new zakaznikForm();
            zakaznikForm.ShowDialog();
        }

        private void btnZbozi_Click(object sender, EventArgs e)
        {
            zboziForm zboziForm = new zboziForm();
            zboziForm.ShowDialog();
        }

        private void btnFaktura_Click(object sender, EventArgs e)
        {
            fakturaForm fakturaForm = new fakturaForm();
            fakturaForm.ShowDialog();
        }
    }
}
