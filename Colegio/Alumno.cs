using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int edad;
        private string direccion;
        private string curso;
        private string[] materias;
        List<Alumno> alumnos = new List<Alumno>();

        public Alumno(string nombre, string apellido, DateTime fechaDeNacimiento, string direccion, string curso, string[] materias)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.direccion = direccion;
            this.curso = curso;
            this.materias = materias;
            AgregarAlumnoLista(this);
            //alumnos.Add(this);
        }

        #region PROPIEDADES
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string Apellido { get { return apellido; } set { apellido = value; } }

        public DateTime FechaDeNacimiento { get { return fechaDeNacimiento; } set { fechaDeNacimiento = value; } }

        public int Edad { get { return edad; } set { edad = value; } }

        public string Direccion { get { return direccion; } set { direccion = value; } }

        public string[] Materias { get { return materias; } set { materias = value; } }

        public string Curso { get { return curso; } set { curso = value; } }

        #endregion 

        private void AgregarAlumnoLista(Alumno alumno)
        {
            alumnos.Add(alumno);
        }
        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad;

            edad = 2023 - fechaDeNacimiento.Year;

            return edad;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string valoresMaterias = string.Join("\n", materias);

            sb.AppendLine($"NOMBRE: {nombre}");
            sb.AppendLine($"APELLIDO: {apellido}");
            sb.AppendLine($"EDAD: {CalcularEdad(fechaDeNacimiento)}");
            sb.AppendLine($"FECHA DE NACIMIENTO: {fechaDeNacimiento}");
            sb.AppendLine($"DIRECCION: {direccion}");
            sb.AppendLine($"CURSO: {curso}");
            sb.AppendLine($"MATERIA/S:\n{valoresMaterias}");

            return sb.ToString();
            
        }
    }
}
