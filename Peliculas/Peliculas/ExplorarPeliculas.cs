using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class ExplorarPeliculas : Form

    {
        Conexion ObjConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        string accion = "nuevo";

        public ExplorarPeliculas()
        {
            InitializeComponent();
        }

        private void txtNombrePeliculas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExplorarPeliculas_Load(object sender, EventArgs e)
        {

        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = ObjConexion.ObtenerDatos ();
            miTabla = ds.Tables["Peliculas"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idPeliculas"] };
            mostrarDatosPeliculas();
        }
        private void mostrarDatosPeliculas()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoPeliculas.Text  = miTabla.Rows[posicion].ItemArray[1].ToString ();
                txtNombrePeliculas.Text  = miTabla.Rows[posicion].ItemArray[2].ToString ();
                txtAñoPelicula.Text  = miTabla.Rows[posicion].ItemArray[3].ToString ();
                txtPrecioPelicula.Text  = miTabla.Rows[posicion].ItemArray[4].ToString ();
                txtDescripcionP.Text  = miTabla.Rows[posicion].ItemArray[5].ToString ();

                lblRegistrosPeliculas.Text = (posicion + 1) + "de" + miTabla.Rows.Count;

            }
        }
    }
}
