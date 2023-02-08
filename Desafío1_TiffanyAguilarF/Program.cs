using Proyecto_TiffanyAguilarF;
using System.Data.SqlClient;

public class Program
{
    static void Main(string[] args)
    {

        ControlProductosVendidos.HacerProductVendido();
        ControlProducto.HacerControlProducto();
        ControlUsuario.HacerControlUsuario();
        ControlVenta.HacerControlVenta();
    }
}

