using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Control
    {
        public String ctrlAcceso(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            String respuesta = "";
            Usuarios datosUsuario = null;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Complete todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuario);
                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Password != password)
                    {
                        respuesta = "El usuario y la contraseña no coinciden";
                    }
                    else
                    {
                        //una vez que ingresa genero la sesion
                        Sesion.usuario = datosUsuario.Usuario;
                        Sesion.password = datosUsuario.Password;
                        Sesion.nombre = datosUsuario.Nombre;
                    }
                }
            }
            return respuesta;
        }
        public String ctrlCalif(Calificaciones calificaciones,int id_profesores)
        {
            Modelo modelo = new Modelo();
            string id_al = modelo.buscarAlumno(calificaciones.Id_alumno.ToString());
            string id_mat = modelo.buscarMateria(calificaciones.Id_materia.ToString());

            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(calificaciones.Trimestre.ToString()) || String.IsNullOrEmpty(calificaciones.Calificacion.ToString()) || String.IsNullOrEmpty(calificaciones.Id_alumno.ToString()) || String.IsNullOrEmpty(calificaciones.Id_materia.ToString()))
            {
                respuesta = "Complete todos los campos";
            }
            else if (String.IsNullOrEmpty(id_al))
            {
                respuesta = "El id_alumno ingresado no existe";
            }
            else if (String.IsNullOrEmpty(id_mat))
            {
                respuesta = "El id_materia ingresado no existe";
            }
            else if (calificaciones.Trimestre<1 || calificaciones.Trimestre > 3)
            {
                respuesta = "Error por mal ingreso de Trimestre. Ingrese del 1 al 3 por favor";
            }
            else if (calificaciones.Calificacion<1 || calificaciones.Calificacion > 10)
            {
                respuesta = "Error: Calificacion incorrecta. Coloque un numero entre 1 y 10";
            }
            else if (modelo.existeNota(calificaciones.Id_alumno,calificaciones.Trimestre,calificaciones.Id_materia))
            {
                respuesta = "Error:la calificacion ya ha sido cargada anteriormente";
            }
            else if (modelo.coincideProfeMateria(id_profesores,calificaciones.Id_materia))
            {
                respuesta = "Error:usted no es el docente de la materia introducida";
            }
            else if (modelo.coincideAlumMateria(calificaciones.Id_alumno, calificaciones.Id_materia))
            {
                respuesta = "Error:el alumno introducido no cursa la materia introducida";
            }
            else
            {
                modelo.registrocal(calificaciones);
                
            }
            return respuesta;
        }
        public String ctrlCalifBorrar(Calificaciones calificaciones, int id_profesores)
        {
            Modelo modelo = new Modelo();
            string id_al = modelo.buscarAlumno(calificaciones.Id_alumno.ToString());
            string id_mat = modelo.buscarMateria(calificaciones.Id_materia.ToString());

            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(calificaciones.Trimestre.ToString()) || String.IsNullOrEmpty(calificaciones.Calificacion.ToString()) || String.IsNullOrEmpty(calificaciones.Id_alumno.ToString()) || String.IsNullOrEmpty(calificaciones.Id_materia.ToString()))
            {
                respuesta = "Complete todos los campos";
            }
            else if (String.IsNullOrEmpty(id_al))
            {
                respuesta = "El id_alumno ingresado no existe";
            }
            else if (String.IsNullOrEmpty(id_mat))
            {
                respuesta = "El id_materia ingresado no existe";
            }
            else if (calificaciones.Trimestre < 1 || calificaciones.Trimestre > 3)
            {
                respuesta = "Error por mal ingreso de Trimestre. Ingrese del 1 al 3 por favor";
            }
            else if (calificaciones.Calificacion < 1 || calificaciones.Calificacion > 10)
            {
                respuesta = "Error: Calificacion incorrecta. Coloque un numero entre 1 y 10";
            }

            else if (modelo.coincideProfeMateria(id_profesores, calificaciones.Id_materia))
            {
                respuesta = "Error:usted no es el docente de la materia introducida";
            }
            //else if (modelo.coincideAlumMateria(calificaciones.Id_alumno, calificaciones.Id_materia))
            //{
            //   respuesta = "Error:el alumno introducido no cursa la materia introducida";
            //}
            else
            {
                modelo.borrarcal(calificaciones);
                
            }
            return respuesta;
        }
        public String crlPago()
        {
            string respuesta = "";
            return respuesta;
        }
    }
}
