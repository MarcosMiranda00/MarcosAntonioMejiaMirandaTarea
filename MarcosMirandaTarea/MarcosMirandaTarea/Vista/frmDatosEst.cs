using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarcosMirandaTarea.Model;
using MarcosMirandaTarea.Vista;

namespace MarcosMirandaTarea.Vista
{
    public partial class frmDatosEst : Form
    {

        public frmDatosEst()
        {
            InitializeComponent();
        }

        public void limpiar() 
        {
            txtNombreEstudiante.Text = "";
            txtApellido.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }
        public void CargarDatos()
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var est1 = db.estudiante;
                foreach(var iterar in est1)
                {
                    dtvEstudiantes.Rows.Add(iterar.id_estudiante, iterar.nombre_estudiante, iterar.apellido, iterar.usuario, iterar.contraseña);
                }
            }
        }

        estudiante est = new estudiante();


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                est.nombre_estudiante = txtNombreEstudiante.Text;
                est.apellido = txtApellido.Text;
                est.contraseña = txtContraseña.Text;
                est.usuario = txtUsuario.Text;

                db.estudiante.Add(est);
                db.SaveChanges();
            }
            dtvEstudiantes.Rows.Clear();
            limpiar();
            CargarDatos();


        }

        private void frmDatosEst_Load(object sender, EventArgs e)
        {

            CargarDatos();
        }
        
    }
}
