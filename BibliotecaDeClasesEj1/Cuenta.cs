using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesEj1
{
    public class Cuenta
    {
        private string titular;  //razon social
        private float cantidad;  // monto de la cuenta


        public Cuenta(string titular, float cantidad)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }
        public string Titular { get { return titular; } set { titular = value; } }
        public float Cantidad { get { return cantidad; } set { cantidad = value; } }
   
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DE LA CUENTA");
            sb.AppendLine($"Razon Social: {titular}");
            sb.AppendLine($"Monto de la cuenta: {cantidad}");

            return sb.ToString();
        }

        public bool Ingresar(float cant)
        {
            if(cant> 0)
            {
                cantidad += cant;
                return true;
            }
            return false;
        }

        public bool Sacar(float cant)
        {
            cantidad -= cant;
            return true;
        }
    
    }
}