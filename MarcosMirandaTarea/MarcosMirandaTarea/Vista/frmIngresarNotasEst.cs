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
    public partial class frmIngresarNotasEst : Form
    {
        public frmIngresarNotasEst()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            
            txtIdEstudiante.Text = "";
            txtIdMateria.Text = "";
            txtNota.Text = "";

        }
        public void CargarDatos()
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var innerjoin = from not7 in db.notas
                                from estn in db.estudiante
                                from mat7 in db.materia
                                where not7.id_estudiante == estn.id_estudiante
                                where not7.id_materia == mat7.id_materia
                                select new
                                {
                                    id = not7.id_notas,
                                    nombreEstudiante = estn.nombre_estudiante,
                                    materia = mat7.nombre_materia,
                                    Nota = not7.notas1
                                };
                foreach (var iterar in innerjoin)
                {
                    dtvNotas.Rows.Add(iterar.id, iterar.nombreEstudiante, iterar.materia, iterar.Nota);
                }
            }
        }
        notas nots = new notas();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                nots.id_estudiante = int.Parse(txtIdEstudiante.Text);
                nots.id_materia = int.Parse(txtIdMateria.Text);
                nots.notas1 = double.Parse(txtNota.Text);


                db.notas.Add(nots);
                db.SaveChanges();
            }
            dtvNotas.Rows.Clear();
            limpiar();
            CargarDatos();
        }

        private void frmIngresarNotasEst_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdEstudiante = dtvNotas.CurrentRow.Cells[1].Value.ToString();
            string IdMateria = dtvNotas.CurrentRow.Cells[2].Value.ToString();
            string Notas = dtvNotas.CurrentRow.Cells[3].Value.ToString();

            txtIdEstudiante.Text = IdEstudiante;
            txtIdMateria.Text = IdMateria;
            txtNota.Text = Notas;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Notas = dtvNotas.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Notas);
                nots = db.notas.Where(verificarId => verificarId.id_notas == Idc).First();
                nots.notas1 = double.Parse(txtNota.Text);


                db.Entry(nots).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            dtvNotas.Rows.Clear();
            limpiar();
            CargarDatos();
        }
    }
}
