using Desafío1_TiffanyAguilarF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TiffanyAguilarF
{
    public class ControlProductosVendidos
    {
        public static void HacerProductVendido()
        {
            string connectionString = "Data Source=DESKTOP-LDDUGHC\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM ProductoVendido", connection);
                List<ProductoVendido> productovendido = new List<ProductoVendido>();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        productovendido.Add(new ProductoVendido(reader.GetInt64(0), reader.GetInt32(1), reader.GetInt64(2), reader.GetInt64(3)));
                    }

                }

                foreach (var item in productovendido)
                {
                    Console.WriteLine(item);
                }

            }
        }

    }
}
