using System;
using System.Text;

namespace _6CBibliotecaDeClasesEj2
{
    public class Ingresante
    {
        private string[] cursos = new string[3];
        private string direccion;
        private decimal edad;
        private string genero;
        private string nombre;
        private string pais;

        

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, decimal edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
            
        }

        public string[] Cursos { get { return cursos; } set { this.cursos= value; } }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string valoresCursos = string.Join("\n", cursos);
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Direccion: {direccion}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Genero: {genero}");
            sb.AppendLine($"Pais: {pais}");
            sb.AppendLine($"Curso/s:\n{valoresCursos}");

            return sb.ToString();
        }
    }
}