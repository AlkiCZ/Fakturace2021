using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace
{
    class SqlRepo
    {
        public string ConnectionString { get; set; }

        public SqlRepo(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<Zakaznik> NactiZakaznik(string sloupecTrideni, bool sestupne, string hledani)
        {
            List<Zakaznik> zakaznik = new List<Zakaznik>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zakaznici where Prijmeni like @Hledani order by {sloupecTrideni}{(sestupne ? " desc" : "")}";
                    sqlCommand.Parameters.AddWithValue("Hledani", "%" + hledani + "%");
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zakaznik.Add(new Zakaznik(Convert.ToInt32(dataReader["IdZakaznika"]),
                                                   dataReader["Jmeno"].ToString(),
                                                   dataReader["Typ"].ToString(),
                                                   dataReader["Adresa"].ToString(),
                                                   Convert.ToInt32(dataReader["Ico"]),
                                                   dataReader["Email"].ToString(),
                                                   Convert.ToInt32(dataReader["Telefon"])));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznik;
        }
    }
}