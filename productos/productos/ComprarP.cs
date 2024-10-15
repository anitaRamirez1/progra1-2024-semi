using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productos
{
    public partial class ComprarP : Form
    {
        public ComprarP()
        {
            InitializeComponent();
        }

        private void txtCodigoDocentes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarP_Click(object sender, EventArgs e)
        {
            {
               foreach (Control control in this.Controls)
                    // Llamar al método de validación antes de continuar

                    Console.WriteLine("sus datos an sido enviados");

                // Lógica para enviar el formulario
                

            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

