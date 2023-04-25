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
        private string curso;
        public Curso(string curso)
        {
            this.curso = curso;
            cursos.Add(this);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Curso curso in cursos)
            {
                sb.Append(curso.Mostrar());
            }
            return sb.ToString();
        }
    }

}
