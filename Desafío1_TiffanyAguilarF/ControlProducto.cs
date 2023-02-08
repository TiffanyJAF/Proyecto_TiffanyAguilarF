using Desafío1_TiffanyAguilarF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TiffanyAguilarF
{

    internal class ControlProducto
    {
        public static void HacerControlProducto()
        {
            string connectionString = "Data Source=DESKTOP-LDDUGHC\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM Producto", connection);
                List<Producto> producto = new List<Producto>();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto.Add(new Producto(reader.GetInt64(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetInt32(4), reader.GetInt64(5)));
                    }
                }

                foreach (var item in producto)
                {
                    Console.WriteLine(item);
                }

            }

        }

    }

}
