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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dtvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                est = db.estudiante.Where(verificarId => verificarId.id_estudiante == Idc).First();
                est.nombre_estudiante = txtNombreEstudiante.Text;
                est.apellido = txtApellido.Text;
                est.contraseña = txtContraseña.Text;
                est.usuario = txtUsuario.Text; 

                db.Entry(est).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            dtvEstudiantes.Rows.Clear();
            limpiar();
            CargarDatos();

        }

        private void dtvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombresEst = dtvEstudiantes.CurrentRow.Cells[1].Value.ToString();
            string Apellido = dtvEstudiantes.CurrentRow.Cells[2].Value.ToString();
            string Usuario = dtvEstudiantes.CurrentRow.Cells[3].Value.ToString();
            string Contraseña = dtvEstudiantes.CurrentRow.Cells[4].Value.ToString();

            txtNombreEstudiante.Text = nombresEst;
            txtApellido.Text = Apellido;
            txtUsuario.Text = Usuario;
            txtContraseña.Text = Contraseña;
        }
    }
}
