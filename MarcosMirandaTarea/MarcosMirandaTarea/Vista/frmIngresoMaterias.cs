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
    public partial class frmIngresoMaterias : Form
    {
        public frmIngresoMaterias()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtNombreMateria.Text = "";
            
        }
        public void CargarDatos()
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var mat1 = db.materia;
                foreach (var iterar in mat1)
                {
                    dtvMateria.Rows.Add(iterar.id_materia, iterar.nombre_materia);
                }
            }
        }

        materia mat = new materia();
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                mat.nombre_materia = txtNombreMateria.Text;
                              
                db.materia.Add(mat);
                db.SaveChanges();
            }
            dtvMateria.Rows.Clear();
            limpiar();
            CargarDatos();
        }

        private void dtvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = dtvMateria.CurrentRow.Cells[0].Value.ToString();
            string nombreMateria = dtvMateria.CurrentRow.Cells[1].Value.ToString();

            txtId.Text = Id;
            txtNombreMateria.Text = nombreMateria;
        }

        private void frmMantenimientoMaterias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dtvMateria.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                mat = db.materia.Where(verificarId => verificarId.id_materia == Idc).First();
                mat.nombre_materia = txtNombreMateria.Text;
                

                db.Entry(mat).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            dtvMateria.Rows.Clear();
            limpiar();
            CargarDatos();
        }
    }
}
