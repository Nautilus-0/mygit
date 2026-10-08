using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class fmrInformacion : Form
    {
        Datos datos;
        public fmrInformacion()
        {
            InitializeComponent();
        }

        private void fmrInformacion_Load(object sender, EventArgs e)
        {
            datos = new Datos();
            DataSet ds = datos.Informacion("Select * from Datos");
            if (ds != null)
            {
                dgvInformacion.DataSource = ds.Tables[0];
            }
            else
                MessageBox.Show("Error al cargar informacion", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.Show();
        }
    }
}
