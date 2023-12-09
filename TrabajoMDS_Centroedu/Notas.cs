using iText.Layout.Splitting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoMDS_Centroedu
{
    public partial class Notas : Form
    {
        public int id_profesor;
        public Notas(int id_profesor)
        {
            InitializeComponent();
            this.id_profesor = id_profesor;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton de materias
            buscador_materias bm1 = new buscador_materias();
            bm1.WindowState = FormWindowState.Maximized;
            bm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton alumnos
            buscar_alumnos bm1 = new buscar_alumnos();
            bm1.WindowState = FormWindowState.Maximized;
            bm1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //boton de materias
            buscador_materias bm1 = new buscador_materias();
            bm1.WindowState = FormWindowState.Maximized;
            bm1.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //boton alumnos
            buscar_alumnos bm1 = new buscar_alumnos();
            bm1.WindowState = FormWindowState.Maximized;
            bm1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Calificaciones calificaciones = new Calificaciones();
           /* try
            {*/
                calificaciones.Calificacion = int.Parse(textBox4.Text);                
                calificaciones.Id_alumno = int.Parse(textBox2.Text);
                calificaciones.Id_materia = int.Parse(textBox1.Text);
                calificaciones.Trimestre = int.Parse(textBox3.Text);
             
                Control control = new Control();
                string respuesta = control.ctrlCalif(calificaciones,id_profesor);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Calificacion cargada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /* }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }*/
            }

        private void button4_Click(object sender, EventArgs e)
        {
            Calificaciones calificaciones = new Calificaciones();
            /* try
             {*/
            calificaciones.Calificacion = int.Parse(textBox4.Text);
            calificaciones.Id_alumno = int.Parse(textBox2.Text);
            calificaciones.Id_materia = int.Parse(textBox1.Text);
            calificaciones.Trimestre = int.Parse(textBox3.Text);

            Control control = new Control();
            string respuesta = control.ctrlCalifBorrar(calificaciones, id_profesor);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Calificacion Eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
