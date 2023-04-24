using Billetes;

namespace _4CEjercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro nombre1 = new Euro("Laureano");
            Euro nombre2 = new Euro("Laureano");

            Console.WriteLine(nombre1 == nombre2);
        }
    }
}