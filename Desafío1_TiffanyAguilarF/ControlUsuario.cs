using Desafío1_TiffanyAguilarF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TiffanyAguilarF
{
    public class ControlUsuario
    {
        public static void HacerControlUsuario()
        {
            string connectionString = "Data Source=DESKTOP-LDDUGHC\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario", connection);
                List<Usuario> usuario = new List<Usuario>();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        usuario.Add(new Usuario(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                    }
                }

                foreach (var item in usuario)
                {
                    Console.WriteLine(item);
                }

            }



        }
    }
}
