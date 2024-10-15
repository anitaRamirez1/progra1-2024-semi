using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productos
{


    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        private void btnNuevoDocentes_Click(object sender, EventArgs e)
        {

            ComprarP objForm = new ComprarP();
           
            

            objForm.Show();
        }

        private void grdDatosDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
