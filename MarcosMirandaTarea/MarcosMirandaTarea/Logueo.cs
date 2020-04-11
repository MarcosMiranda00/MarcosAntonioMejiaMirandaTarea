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

namespace MarcosMirandaTarea
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var lista = from estudiantes in db.estudiante
                            where estudiantes.usuario == txtUsuario.Text
                            && estudiantes.contraseña == txtContaseña.Text
                            select estudiantes;

                if (lista.Count() > 0)
                {
                    frmMenu usu = new frmMenu();
                    usu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }

            }
        }

        }
}
