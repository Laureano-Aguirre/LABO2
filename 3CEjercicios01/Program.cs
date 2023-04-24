using BibliotecaDeClasesEj2;

namespace _3CEjercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string nombre;
            //int dni;
            //DateTime fechaDeNac;
            //bool pudoDni;

            //Console.WriteLine("Ingrese su nombre: ");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese su DNI: ");
            //pudoDni = int.TryParse(Console.ReadLine(), out dni);
            //while(!(pudoDni))
            //{
            //    Console.WriteLine("ERROR, ingrese su DNI: ");
            //    pudoDni = int.TryParse(Console.ReadLine(), out dni);
            //}
            //Console.WriteLine("Ingrese su fecha de nacimiento con el siguiente formato: dd/MM/AAAA");
            //fechaDeNac = DateTime.Parse(Console.ReadLine());
            //DateTime fecha = new DateTime(2000, 11, 29);
            //DateTime fecha2 = new DateTime(2010, 11, 29);
            //DateTime fecha3 = new DateTime(2001, 11, 29);
            Persona persona1 = new Persona("Laureano Aguirre", 222222, new DateTime(2000, 11, 29));
            Persona persona2 = new Persona("Macarena Perez", 333333, new DateTime(2010, 11, 29));
            Persona persona3 = new Persona("Juan Sanchez", 444444, new DateTime(2001, 11, 29));

           
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());







        }
    }
}