using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace
{
    class SqlConn
    {
        public string ConnectionString { get; set; }

        public SqlConn(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<Zakaznik> NactiZakazniky()
        {
            List<Zakaznik> zakaznici = new List<Zakaznik>();
        }
    }
