using System.Text;

namespace BibliotecaDeClasesEj2
{
    public class Persona
    {
        private string nombre;
        private int dni;
        private DateTime fechaDeNacimiento;


        public Persona(string nombre, int dni, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public DateTime FechaDeNacimiento { get { return fechaDeNacimiento; } set { fechaDeNacimiento = value; } }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad;

            edad = 2023 - fechaDeNacimiento.Year;

            return edad;

        }

        public string EsMayorDeEdad(int edad)
        {
            if (edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
                return "Es menor de edad";
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ");
            sb.AppendLine("DATOS DE LA PERSONA.");
            sb.AppendLine($"NOMBRE: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"FECHA DE NACIMIENTO: {fechaDeNacimiento}");
            sb.AppendLine($"EDAD: {CalcularEdad(fechaDeNacimiento)}");
            sb.AppendLine(EsMayorDeEdad(CalcularEdad(fechaDeNacimiento)));

            return sb.ToString();
        }
        
    }
}