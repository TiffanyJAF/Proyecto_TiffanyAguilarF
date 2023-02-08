using Desafío1_TiffanyAguilarF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TiffanyAguilarF
{
    public class ControlVenta
    {
        public static void HacerControlVenta()
        {
            string connectionString = "Data Source=DESKTOP-LDDUGHC\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM Venta", connection);
                List<Venta> venta = new List<Venta>();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        venta.Add(new Venta(reader.GetInt64(0), reader.GetString(1), reader.GetInt64(2)));

                    }
                }

                foreach (var item in venta)
                {
                    Console.WriteLine(item);
                }

            }



        }
    }
}
