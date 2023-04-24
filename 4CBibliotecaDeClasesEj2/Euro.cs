using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private string nombre;

        public Euro(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Euro nomb1, Euro nomb2)
        {
            return nomb1.nombre == nomb2.nombre;
        }

        public static bool operator !=(Euro nomb1, Euro nomb2)
        { 
            return !(nomb1.nombre == nomb2.nombre);
        }
    }
}
