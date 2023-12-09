using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoMDS_Centroedu
{
    public partial class Inicio : Form
    {
        public int id_tipo;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(int id_tipo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.id_tipo = id_tipo;
            Inicio_Load(id_tipo);
            asignacion();
            lblBienvenida.Text = Sesion.usuario;
            rolinicio();
        }
        Alumnos alumno1 = new Alumnos();
        Tutor tutor1 = new Tutor();
        Profesor profesor1 = new Profesor();
        Personal personal1 = new Personal();
        Autoridad autoridad1 = new Autoridad();

        public void asignacion()
        {
            //con la sesion busco el usuario en la base de datos y obtengo sus atributos
            if (id_tipo == 1)
            {
                Modelo ma1 = new Modelo();
                alumno1 = ma1.porAlumnos(Sesion.usuario);
            }
            else if (id_tipo == 2)
            {
                Modelo ma1 = new Modelo();
                profesor1 = ma1.porProfesor(Sesion.usuario);
            }
            else if (id_tipo == 3)
            {
                Modelo ma1 = new Modelo();
                tutor1 = ma1.porTutor(Sesion.usuario);
            }
            else if (id_tipo == 4)
            {
                Modelo ma1 = new Modelo();
                personal1 = ma1.porPersonal(Sesion.usuario);
            }
            else if (id_tipo == 5)
            {
                Modelo ma1 = new Modelo();
                autoridad1 = ma1.porAutoridad(Sesion.usuario);
            }


        }
        public void rolinicio()
        {
            if (Sesion.id_tipo == 1)
            {
                lblRol.Text = "ESTUDIANTE";
            }
            else if (Sesion.id_tipo == 3)
            {
                lblRol.Text = "TUTOR";
            }
            else if (Sesion.id_tipo == 2)
            {
                lblRol.Text = "PROFESOR";
            }
            else if (Sesion.id_tipo == 4)
            {
                lblRol.Text = "PERSONAL";
            }
            else if (Sesion.id_tipo == 5)
            {
                lblRol.Text = "AUTORIDAD";
            }

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.SkyBlue;
            }

            menu.BackColor = Color.AliceBlue;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;


            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void menupago_Click(object sender, EventArgs e)
        {
            string nombre = null, apellido = null, id_tutor = null, usuario = null, email = null;
            if (Sesion.id_tipo == 3)
            {
                nombre = tutor1.Nombre;
                apellido = tutor1.Apellido;
                id_tutor = tutor1.Id_tutor.ToString();
                usuario = tutor1.Usuario;
                email = tutor1.Email;
            }
            AbrirFormulario((IconMenuItem)sender, new formPagodeCuota(nombre, apellido, id_tutor, usuario, email));
        }

        private void submenuListaAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAlumnos, new formListaAlumnos());
        }

        private void submenuNotas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAlumnos, new Notas(profesor1.Id_profesores));
        }

        private void submenuHorarioClases_Click(object sender, EventArgs e)
        {
           
        }

        private void submenuAsignacionClases_Click(object sender, EventArgs e)
        {
            
        }

        private void menuBoletin_Click(object sender, EventArgs e)
        {
            
        }

        public void Inicio_Load(int id_tipo)
        {
            if (id_tipo == 1)  // 
            {
                menupago.Visible = false;
                menuAlumnos.Visible = false;
                menuIngreso.Visible = false;

                //iconButton2.Visible = false; //Boton de Usuario
            }
            else if (id_tipo == 2)
            {
                menupago.Visible = false;
                menuIngreso.Visible = false;
                menuboletin.Visible= false;
                alumnosConCuotasImpagasToolStripMenuItem.Visible=false;
            }
            else if (id_tipo == 3)
            {
                menuAlumnos.Visible = false;
                menuIngreso.Visible = false;

            }
            else if (id_tipo == 4)
            {
                menuIngreso.Visible = false;
                submenuNotas.Visible = false;
                alumnosConCuotasImpagasToolStripMenuItem.Visible = false;
                menuboletin.Visible = false;
            }
            else if (id_tipo == 5)
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pagarCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuMorosos_Click(object sender, EventArgs e)
        {
            
        }

        private void alumnosConCuotasImpagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAlumnos, new formaAlumnosMorosos());
        }

        private void alumnosPorDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAlumnos, new AlumnosPorDocente());
        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {
            string id_grado = null; //solo si es un alumno se filtra por grado
            if (Sesion.id_tipo == 1)
            {
                id_grado = alumno1.Grado.ToString();
            }

            AbrirFormulario(menuClases, new formHorariosClases(id_grado));
        }

        private void menuboletin_Click_1(object sender, EventArgs e)
        {
            //boletin paso datos del alumno
            string id_grado = null, nombre = null, apellido = null, id_alumno = null;
            if (Sesion.id_tipo == 1)
            {
                id_grado = alumno1.Grado.ToString();
                id_alumno = alumno1.Id_alumnos.ToString();
                nombre = alumno1.Nombre.ToString();
                apellido = alumno1.Apellido.ToString();
                AbrirFormulario((IconMenuItem)sender, new formBoletin(id_grado, nombre, apellido, id_alumno));
            }
            else
            {
                AbrirFormulario((IconMenuItem)sender, new formBoletin(id_grado, nombre, apellido, id_alumno));
            }
            
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuIngreso, new verIngresos());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menupago_Click_1(object sender, EventArgs e)
        {
            string nombre = null, apellido = null, id_tutor = null, usuario = null, email = null;
            if (Sesion.id_tipo == 3)
            {
                nombre = tutor1.Nombre;
                apellido = tutor1.Apellido;
                id_tutor = tutor1.Id_tutor.ToString();
                usuario = tutor1.Usuario;
                email = tutor1.Email;
            }

            AbrirFormulario((IconMenuItem)sender, new formPagodeCuota(nombre, apellido, id_tutor, usuario, email));
            
        }

        private void submenuNotas_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuAlumnos, new Notas(profesor1.Id_profesores));
        }

        private void submenuListaAlumnos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuAlumnos, new formListaAlumnos());
        }
    }
}
