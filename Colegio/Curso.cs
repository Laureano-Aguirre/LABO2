using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    public class Curso
    {
        List<Curso> cursos = new List<Curso>();
        private string nombreCurso;
        public Curso(string nombreCurso)
        {
            this.nombreCurso = nombreCurso;
            cursos.Add(this);
        }

        public List<Curso> Cursos { get { return cursos; } set { this.cursos = value; } }
        public string Mostrar(List<Curso> cursos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Curso curso in cursos)
            {
                sb.AppendLine($"{nombreCurso}");
            }
            return sb.ToString();
        }
    }

}
