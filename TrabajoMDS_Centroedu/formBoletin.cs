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
    public partial class formBoletin : Form
    {
        public string grado, nombre, apellido, id_alumno;



        public formBoletin(string grado, string nombre, string apellido, string id_alumno)
        {
            InitializeComponent();
            if (grado != null)
            {
                this.grado = grado;
                this.nombre = nombre;
                this.apellido = apellido;
                this.id_alumno = id_alumno;
                int numgrado = int.Parse(grado);
                label3.Text = nombre;
                label4.Text = apellido;
                label5.Visible = false;
                textBox1.Visible= false;
                button31.Visible = false;
                completarBoletin(numgrado);

            }


        }
        private void button31_Click(object sender, EventArgs e)
        {

            Alumnos alumnoboleta = new Alumnos();
            Modelo md = new Modelo();
            alumnoboleta = md.porid_Alumnos(textBox1.Text);
            grado = alumnoboleta.Grado.ToString();
            nombre = alumnoboleta.Nombre;
            apellido = alumnoboleta.Apellido;
            id_alumno = alumnoboleta.Id_alumnos.ToString();
            label3.Text = nombre;
            label4.Text = apellido;
            completarBoletin(int.Parse(textBox1.Text));
        }
        private void completarBoletin(int grado)
        {
            List<Calificaciones> lista = new List<Calificaciones>();
            Modelo md = new Modelo();
            lista = md.buscarNotas(id_alumno);

            int x = -1;
            int aux = (grado - 1) * 5;

            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == (1 + aux) && calificacion.Trimestre == 1)
                {
                    x = calificacion.Calificacion;
                    button7.Text = x.ToString();//nota tri 1 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 2 + aux && calificacion.Trimestre == 1)
                {
                    x = calificacion.Calificacion;
                    button8.Text = x.ToString();//nota tri 1 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 3 + aux && calificacion.Trimestre == 1)
                {
                    x = calificacion.Calificacion;
                    button9.Text = x.ToString();//nota tri 1 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 4 + aux && calificacion.Trimestre == 1)
                {
                    x = calificacion.Calificacion;
                    button10.Text = x.ToString();//nota tri 1 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 5 + aux && calificacion.Trimestre == 1)
                {
                    x = calificacion.Calificacion;
                    button27.Text = x.ToString();//nota tri 1 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 1 + aux && calificacion.Trimestre == 2)
                {
                    x = calificacion.Calificacion;
                    button12.Text = x.ToString();//nota tri 2 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 2 + aux && calificacion.Trimestre == 2)
                {
                    x = calificacion.Calificacion;
                    button13.Text = x.ToString();//nota tri 2 mat 2
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 3 + aux && calificacion.Trimestre == 2)
                {
                    x = calificacion.Calificacion;
                    button14.Text = x.ToString();//nota tri 2 mat 3
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 4 + aux && calificacion.Trimestre == 2)
                {
                    x = calificacion.Calificacion;
                    button15.Text = x.ToString();//nota tri 2 mat 4
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 5 + aux && calificacion.Trimestre == 2)
                {
                    x = calificacion.Calificacion;
                    button28.Text = x.ToString();//nota tri 2 mat 5
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 1 + aux && calificacion.Trimestre == 3)
                {
                    x = calificacion.Calificacion;
                    button17.Text = x.ToString();//nota tri 3 mat 1
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 2 + aux && calificacion.Trimestre == 3)
                {
                    x = calificacion.Calificacion;
                    button18.Text = x.ToString();//nota tri 3 mat 2
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 3 + aux && calificacion.Trimestre == 3)
                {
                    x = calificacion.Calificacion;
                    button19.Text = x.ToString();//nota tri 3 mat 3
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 4 + aux && calificacion.Trimestre == 3)
                {
                    x = calificacion.Calificacion;
                    button20.Text = x.ToString();//nota tri 3 mat 4
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 5 + aux && calificacion.Trimestre == 2)
                {
                    x = calificacion.Calificacion;
                    button29.Text = x.ToString();//nota tri 3 mat 5
                    x = -1;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }

            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 1 + aux)
                {
                    button2.Text = calificacion.Nombre_materia;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 2 + aux)
                {
                    button3.Text = calificacion.Nombre_materia;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 3 + aux)
                {
                    button4.Text = calificacion.Nombre_materia;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 4 + aux)
                {
                    button5.Text = calificacion.Nombre_materia;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }
            foreach (Calificaciones calificacion in lista)
            {
                if (calificacion.Id_materia == 5 + aux)
                {
                    button26.Text = calificacion.Nombre_materia;
                    break; // Salimos del bucle si encontramos una coincidencia
                }
            }



            button1.Text = grado + "° grado";//grado
            button6.Text = "1° TRIMESTRE";//trimestre 1      
            button11.Text = "2° TRIMESTRE";//trimestre 2
            button16.Text = "3° TRIMESTRE";//trimestre 3
            button21.Text = "NOTA FINAL";//nota final

            int a = (int.Parse(button7.Text) + int.Parse(button12.Text) + int.Parse(button17.Text)) / 3;
            button22.Text = a.ToString();//nota tri 4 mat 2
            a = (int.Parse(button8.Text) + int.Parse(button13.Text) + int.Parse(button18.Text)) / 3;
            button23.Text = a.ToString(); //nota tri 4 mat 2
            a = (int.Parse(button9.Text) + int.Parse(button14.Text) + int.Parse(button19.Text)) / 3;
            button24.Text = a.ToString();//nota tri 4 mat 3
            a = (int.Parse(button10.Text) + int.Parse(button15.Text) + int.Parse(button20.Text)) / 3;
            button25.Text = a.ToString();//nota tri 4 mat 4
            a = (int.Parse(button27.Text) + int.Parse(button28.Text) + int.Parse(button29.Text)) / 3;                             //
            button30.Text = a.ToString();//nota tri 4 mat 5

        }
    }
}
