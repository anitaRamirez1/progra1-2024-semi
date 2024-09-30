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
            objConexion = new Conexion();
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
            if (posicion < miTabla.Rows.Count - 1) {
                posicion++;
                mostrarDatosDocentes();
            } else {
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

        private void grdDatosDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocentes();
        }

        private void btnPrimeroDocentes_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosDocentes();
        }
    
        private void estadoControles(Boolean estado)
        {
            grbDatosDocentes.Enabled = estado;
            grbNavegacionDocentes.Enabled = !estado;
            btnEliminarDocentes.Enabled = !estado;
        }

        private void btnNuevoDocentes_Click(object sender, EventArgs e)
        {
            if (btnNuevoDocentes.Text == "Nuevo")
            {
                btnNuevoDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] docentes = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoDocentes.Text, txtNombreDocentes.Text, txtDireccionDocentes.Text, txtTelefonoDocentes.Text, txtDuiDocentes.Text
                };
                String respuesta = objConexion.administrarDocentes(docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoDocentes.Text = "Nuevo";
                    btnModificarDocentes.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }
        void limpiarCajas()
        {
            txtCodigoDocentes.Text = "";
            txtNombreDocentes.Text = "";
            txtDireccionDocentes.Text = "";
            txtTelefonoDocentes.Text = "";
            txtDuiDocentes.Text = "";
        }

        private void btnModificarDocentes_Click(object sender, EventArgs e)
        {
            if (btnModificarDocentes.Text == "Modificar")
            {
                btnNuevoDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            }
            else
            {//Cancelar
                mostrarDatosDocentes();
                btnNuevoDocentes.Text = "Nuevo";
                btnModificarDocentes.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarDocentes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocentes.Text.Trim() + "?", "Eliminar Docentes", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Docentes = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarDocentes(Docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosDocentes();
                }

            }

        
        }
        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosDocentes.DataSource = dv;
        }
        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocentes.Text);
            //if (e.KeyValue == 13) {//tecla enter
            seleccionarDocentes();
            //}
        }
        private void seleccionarDocentes()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosDocentes.CurrentRow.Cells["idDocentes"].Value.ToString()));
            mostrarDatosDocentes();
        }

        private void txtBuscarDocentes_TextChanged(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosDocentes.CurrentRow.Cells["idDocentes"].Value.ToString()));
            mostrarDatosDocentes();

            filtrarDatos(txtBuscarDocentes.Text);
            //if (e.KeyValue == 13) {//tecla enter
            seleccionarDocentes();
            //}
        }

        private void btnUltimoDocentes_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosDocentes();
        }
    }
}
