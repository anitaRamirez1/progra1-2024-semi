using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //base d datos
using System.Data.SqlClient;

namespace Peliculas
{

    internal class Conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand misComandos = new SqlCommand();  
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Conexion()
        {
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MINEDUCYT\OneDrive\Documents\Peliculas.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            miConexion.ConnectionString  = cadenaConexion;
            miConexion.Open();
        }

        public DataSet ObtenerDatos()
        {
            ds.Clear();
            misComandos.Connection = miConexion;
            misComandos.CommandText = "SELEC * FROM Peliculas";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "Peliculas");
            return ds;
        }

    }

}
