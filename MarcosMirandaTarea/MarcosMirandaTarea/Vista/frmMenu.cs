using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcosMirandaTarea.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEst DE = new frmDatosEst();
            DE.Show();
        }

        private void mantenimientoDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoMaterias MM = new frmIngresoMaterias();
            MM.Show();
        }

        private void ingresarNotasDelEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresarNotasEst NE = new frmIngresarNotasEst();
            NE.Show();
        }
    }
}
