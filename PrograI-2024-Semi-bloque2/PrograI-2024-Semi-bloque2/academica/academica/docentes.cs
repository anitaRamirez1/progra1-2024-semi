using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class docentes : Form
    {
                Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";

        public docentes()
        {
            InitializeComponent();
        }
        private void docentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["Docentes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idDocentes"] };
            grdDatosDocentes.DataSource = miTabla;
            mostrarDatosDocentes();
        }
        private void mostrarDatosDocentes()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoDocentes.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreDocentes.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionDocentes.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoDocentes.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtDuiDocentes.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosDocentes.Text = (posicion + 1) + " de " + miTabla.Rows.Count;

            }
        }

        private void btnSiguienteDocentes_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosDocentes();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocentes_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosDocentes();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
