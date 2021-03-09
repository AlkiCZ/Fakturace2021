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
        private List<Zakaznik> zakaznici;
        private SqlConn sqlConn;
        public zakaznikForm()
        {
            InitializeComponent();
            sqlConn = new SqlConn("Data Source = DESKTOP - C0DU3PI/ALKISQL; Initial Catalog = Fakturace21; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
