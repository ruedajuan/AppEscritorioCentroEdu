using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoMDS_Centroedu
{
    internal class Modelo
    {
        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT id,usuario,password,nombre,apellido FROM profesores WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            Usuarios usr = null;
            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id_usuario = int.Parse(reader["id"].ToString());
                usr.Usuario = reader["Usuario"].ToString();
                usr.Password = reader["Password"].ToString();
                usr.Nombre = reader["Nombre"].ToString();

            }
            return usr;


        }
        public Alumnos porAlumnos(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT ID_ALUMNO,NOMBRE, APELLIDO, GRADO,ID_TUTOR, USUARIO,EMAIL FROM ALUMNOS WHERE USUARIO LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            Alumnos alm = null;
            while (reader.Read())
            {
                alm = new Alumnos();
                alm.Id_alumnos = int.Parse(reader["ID_ALUMNO"].ToString());
                alm.Nombre = reader["NOMBRE"].ToString();
                alm.Apellido = reader["APELLIDO"].ToString();
                alm.Grado = int.Parse(reader["GRADO"].ToString());
                alm.Usuario = reader["USUARIO"].ToString();
                alm.Email = reader["EMAIL"].ToString();
                alm.Id_tutor = int.Parse(reader["ID_TUTOR"].ToString());
            }
            return alm;

        }
        public Alumnos porid_Alumnos(string id_alumno)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT ID_ALUMNO,NOMBRE, APELLIDO, GRADO,ID_TUTOR, USUARIO,EMAIL FROM ALUMNOS WHERE id_alumno LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", id_alumno);
            reader = comando.ExecuteReader();
            Alumnos alm = null;
            while (reader.Read())
            {
                alm = new Alumnos();
                alm.Id_alumnos = int.Parse(reader["ID_ALUMNO"].ToString());
                alm.Nombre = reader["NOMBRE"].ToString();
                alm.Apellido = reader["APELLIDO"].ToString();
                alm.Grado = int.Parse(reader["GRADO"].ToString());
                alm.Usuario = reader["USUARIO"].ToString();
                alm.Email = reader["EMAIL"].ToString();
                alm.Id_tutor = int.Parse(reader["ID_TUTOR"].ToString());
            }
            return alm;

        }
        public Profesor porProfesor(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT id_profesores, nombre, apellido, usuario, email FROM profesores WHERE USUARIO LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            Profesor alm = null;
            while (reader.Read())
            {
                alm = new Profesor();
                alm.Id_profesores = int.Parse(reader["id_profesores"].ToString());
                alm.Nombre = reader["NOMBRE"].ToString();
                alm.Apellido = reader["APELLIDO"].ToString();
                alm.Usuario = reader["USUARIO"].ToString();
                alm.Email = reader["EMAIL"].ToString();
            }
            return alm;

        }
        public Tutor porTutor(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT id_tutor, nombre, apellido, usuario, email FROM tutor WHERE USUARIO LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            Tutor alm = null;
            while (reader.Read())
            {
                alm = new Tutor();
                alm.Id_tutor = int.Parse(reader["ID_tutor"].ToString());
                alm.Nombre = reader["NOMBRE"].ToString();
                alm.Apellido = reader["APELLIDO"].ToString();
                alm.Usuario = reader["USUARIO"].ToString();
                alm.Email = reader["EMAIL"].ToString();
            }
            return alm;

        }

        public Personal porPersonal(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT id_personal, nombre, apellido, usuario, email FROM personal WHERE USUARIO LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            Personal alm = null;
            while (reader.Read())
            {
                alm = new Personal();
                alm.Id_personal = int.Parse(reader["ID_personal"].ToString());
                alm.Nombre = reader["NOMBRE"].ToString();
                alm.Apellido = reader["APELLIDO"].ToString();
                alm.Usuario = reader["USUARIO"].ToString();
                alm.Email = reader["EMAIL"].ToString();
            }
            return alm;

        }
        public Autoridad porAutoridad(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT id_autoridad, nombre, apellido, usuario, email FROM autoridad WHERE USUARIO LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            Autoridad alm = null;
            while (reader.Read())
            {
                alm = new Autoridad();
                alm.Id_autoridad = int.Parse(reader["ID_autoridad"].ToString());
                alm.Nombre = reader["NOMBRE"].ToString();
                alm.Apellido = reader["APELLIDO"].ToString();
                alm.Usuario = reader["USUARIO"].ToString();
                alm.Email = reader["EMAIL"].ToString();
            }
            return alm;

        }

        public List<Object> mostrartabla(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT ID_USUARIOS,USUARIOS,PASSWORD,NOMBRE,ID_TIPO FROM USUARIOS";
            }
            else
            {
                sql = "SELECT ID_USUARIOS,USUARIOS,PASSWORD,NOMBRE,ID_TIPO FROM USUARIOS WHERE USUARIOS LIKE @usuario";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Usuarios usr = new Usuarios();
                usr.Id_usuario = int.Parse(reader["ID_USUARIOS"].ToString());
                usr.Usuario = reader["USUARIOS"].ToString();
                usr.Password = reader["PASSWORD"].ToString();
                usr.Nombre = reader["NOMBRE"].ToString();
                usr.Id_tipo = int.Parse(reader["ID_TIPO"].ToString());
                lista.Add(usr);

            }
            return lista;
        }
        public List<Object> mostrarHorarios(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT GRADO,MATERIA,DIA,HORA,AULA FROM HORARIOS";
            }
            else
            {
                sql = "SELECT GRADO,MATERIA,DIA,HORA,AULA FROM HORARIOS WHERE GRADO=@usuario";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Horarios hor = new Horarios();
                hor.Grado = int.Parse(reader["GRADO"].ToString());
                hor.Dia = reader["dia"].ToString();
                hor.Hora = reader["hora"].ToString();
                hor.Nombre = reader["MATERIA"].ToString();
                hor.Aula = reader["AULA"].ToString();
                lista.Add(hor);

            }
            return lista;
        }

        //registrar calificaciones
        public int registrocal(Calificaciones calificaciones)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO calificaciones (id_alumno, id_materia, trimestre, calificacion) VALUES (@id_alumno, @id_materia, @trimestre, @calificacion)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_alumno", calificaciones.Id_alumno);
            comando.Parameters.AddWithValue("@id_materia", calificaciones.Id_materia);
            comando.Parameters.AddWithValue("@trimestre", calificaciones.Trimestre);
            comando.Parameters.AddWithValue("@calificacion", calificaciones.Calificacion);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        public int borrarcal(Calificaciones calificaciones)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "DELETE FROM calificaciones WHERE id_alumno=@id_alumno AND id_materia=@id_materia AND trimestre=@trimestre";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_alumno", calificaciones.Id_alumno);
            comando.Parameters.AddWithValue("@id_materia", calificaciones.Id_materia);
            comando.Parameters.AddWithValue("@trimestre", calificaciones.Trimestre);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        //buscar calificaciones para el boletin
        public List<Calificaciones> buscarNotas(string dato)
        {
            MySqlDataReader reader;
            List<Calificaciones> lista = new List<Calificaciones>();
            string sql;
            sql = "SELECT c.id_alumno, m.id_materia, m.nombre AS nombre_materia, c.trimestre, c.calificacion FROM calificaciones AS c INNER JOIN materias AS m ON c.id_materia = m.id_materia WHERE c.id_alumno = @usuario;";
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Calificaciones cal = new Calificaciones();
                cal.Id_alumno = int.Parse(reader["id_alumno"].ToString());
                cal.Id_materia = int.Parse(reader["id_materia"].ToString());
                cal.Calificacion = int.Parse(reader["calificacion"].ToString());
                cal.Trimestre = int.Parse(reader["trimestre"].ToString());
                cal.Nombre_materia = reader["nombre_materia"].ToString();
                lista.Add(cal);

            }
            return lista;
        }

        //mostrar materias

        public List<Object> mostrarMaterias(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT id_materia,nombre,id_profesor,id_grado FROM materias";
            }
            else
            {
                sql = "SELECT id_materia,nombre,id_profesor,id_grado FROM materias WHERE nombre like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", "%" + dato + "%");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Materias mat = new Materias();
                mat.Id_materia = int.Parse(reader["id_materia"].ToString());
                mat.Id_profesor = int.Parse(reader["id_profesor"].ToString());
                mat.Id_grado = int.Parse(reader["id_grado"].ToString());
                mat.Nombre = reader["nombre"].ToString();

                lista.Add(mat);

            }
            return lista;
        }

        public List<Object> mostrarAlumnos(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT id_alumno,nombre,apellido,grado,EMAIL,ID_TUTOR FROM alumnos";
            }
            else
            {
                sql = "SELECT id_alumno,nombre,apellido,grado,EMAIL, ID_TUTOR FROM alumnos WHERE nombre like @nombre or apellido like @nombre or grado like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", "%" + dato + "%");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Alumnos alu = new Alumnos();
                alu.Id_alumnos = int.Parse(reader["id_alumno"].ToString());
                alu.Nombre = reader["nombre"].ToString();
                alu.Apellido = reader["apellido"].ToString();
                alu.Grado = int.Parse(reader["GRADO"].ToString());
                alu.Email = reader["EMAIL"].ToString();
                alu.Id_tutor = int.Parse(reader["ID_TUTOR"].ToString());
                lista.Add(alu);

            }
            return lista;
        }
        public string buscarAlumno(string dato)
        {
            MySqlDataReader reader;
            string sql;
            sql = "SELECT id_alumno,nombre,apellido,grado,EMAIL, ID_TUTOR FROM alumnos WHERE id_alumno=@nombre";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            reader = comando.ExecuteReader();
            string id = null;
            while (reader.Read())
            {
                id = reader["id_alumno"].ToString();
            }
            return id;
        }
        public string buscarMateria(string dato)
        {
            MySqlDataReader reader;
            string sql;
            sql = "SELECT id_materia,nombre,id_profesor, id_grado FROM materias WHERE id_materia=@nombre";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            reader = comando.ExecuteReader();
            string id = null;
            while (reader.Read())
            {
                id = reader["id_materia"].ToString();
            }
            return id;
        }

        public List<Object> alumnosPorProfe(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            sql = "SELECT DISTINCT a.id_alumno, a.nombre, a.apellido, a.GRADO, a.EMAIL FROM alumnos a JOIN materias m ON a.grado = m.id_grado JOIN profesores p ON m.id_profesor = p.id_profesores WHERE p.id_profesores = @nombre;";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Alumnos alu = new Alumnos();
                alu.Id_alumnos = int.Parse(reader["id_alumno"].ToString());
                alu.Nombre = reader["nombre"].ToString();
                alu.Apellido = reader["apellido"].ToString();
                alu.Grado = int.Parse(reader["GRADO"].ToString());
                alu.Email = reader["EMAIL"].ToString();
                lista.Add(alu);
            }
            return lista;
        }
        public List<Object> alumnosPorTutor(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            sql = "SELECT id_alumno,nombre,apellido,grado,EMAIL,ID_TUTOR FROM alumnos WHERE ID_TUTOR = @nombre";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Alumnos alu = new Alumnos();
                alu.Id_alumnos = int.Parse(reader["id_alumno"].ToString());
                alu.Nombre = reader["nombre"].ToString();
                alu.Apellido = reader["apellido"].ToString();
                alu.Grado = int.Parse(reader["GRADO"].ToString());
                alu.Email = reader["EMAIL"].ToString();
                alu.Id_tutor = int.Parse(reader["ID_TUTOR"].ToString());
                lista.Add(alu);

            }
            return lista;
        }

        //registar pagos
        public int registroPagos(string fechaPago, string id_tutor, string modalidad_pago, string monto, string mes_pago, string año_pagar)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO pagos (id_tutor, fecha_pago, modalidad_pago, monto, mes_pago, año_pago) VALUES (@id_tutor, @fecha_pago, @modalidad_pago, @monto, @mes_pago, @año_pago)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_tutor", id_tutor);
            comando.Parameters.AddWithValue("@fecha_pago", fechaPago);
            comando.Parameters.AddWithValue("@modalidad_pago", modalidad_pago);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@mes_pago", mes_pago);
            comando.Parameters.AddWithValue("@año_pago", año_pagar);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public List<Object> mostrarPagos(string dato, string dato2)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            sql = "SELECT * FROM pagos WHERE fecha_pago>=@nombre AND fecha_pago <= @nombre2";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            comando.Parameters.AddWithValue("@nombre2", dato2);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Pagos alu = new Pagos();
                alu.Id_tutor = int.Parse(reader["id_tutor"].ToString());
                alu.Id_pagos = int.Parse(reader["id_pagos"].ToString());
                alu.Mes_pago = reader["mes_pago"].ToString();
                alu.Fecha_pago = reader["fecha_pago"].ToString();
                alu.Modalidad_pago = reader["modalidad_pago"].ToString();
                alu.Monto = int.Parse(reader["monto"].ToString());
                lista.Add(alu);

            }
            return lista;
        }
        // verifico si ya se cargo la calificacion
        public bool existeNota(int id_alumno,int trimestre, int id_materia)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT id_calificaciones from calificaciones where id_alumno=@id_alumno and trimestre=@trimestre and id_materia=@id_materia ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_alumno", id_alumno);
            comando.Parameters.AddWithValue("@trimestre", trimestre);
            comando.Parameters.AddWithValue("@id_materia", id_materia);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool coincideProfeMateria(int id_profesor, int id_materia)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT * from materias where id_profesor=@id_profesor AND id_materia=@id_materia";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_profesor", id_profesor);
            comando.Parameters.AddWithValue("@id_materia", id_materia);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool coincideAlumMateria(int id_alumno, int id_materia)
        {

          
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT grado FROM alumnos WHERE id_alumno=@id_alumno";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id_alumno", id_alumno);
            MySqlDataReader reader = comando.ExecuteReader();
            int id_grad = 0;
            while (reader.Read())
            {
                id_grad = int.Parse(reader["grado"].ToString());
            }
            reader.Close();

            string sql2 = "SELECT* from materias where id_materia=@id_materia AND id_grado=@grado";
            MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
            comando2.Parameters.AddWithValue("@id_materia", id_materia);
            comando2.Parameters.AddWithValue("@grado", id_grad);
            reader = comando2.ExecuteReader();
            if (reader.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Object> alumnosMorosos()
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            sql = "SELECT a.id_alumno, a.nombre, a.apellido, a.grado,a.email, a.id_tutor\r\nFROM alumnos a\r\nLEFT JOIN (\r\n    SELECT DISTINCT id_tutor, mes_pago\r\n    FROM pagos\r\n    WHERE fecha_pago >= @fechainicio AND fecha_pago <= @fechafin\r\n) p ON a.id_tutor = p.id_tutor\r\nWHERE p.mes_pago IS NULL OR p.mes_pago NOT IN ('Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre','Noviembre','Diciembre')";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechainicio", "2023-03-01");
            comando.Parameters.AddWithValue("@fechafin", "2023-10-31");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Alumnos alu = new Alumnos();
                alu.Id_alumnos = int.Parse(reader["id_alumno"].ToString());
                alu.Nombre = reader["nombre"].ToString();
                alu.Apellido = reader["apellido"].ToString();
                alu.Grado = int.Parse(reader["GRADO"].ToString());
                alu.Email = reader["EMAIL"].ToString();
                alu.Id_tutor = int.Parse(reader["id_tutor"].ToString());
                lista.Add(alu);
            }
            return lista;
        }
    }
}
