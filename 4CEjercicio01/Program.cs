using System;
using System.Text;
using _4CBibliotecaDeClasesEj1;

namespace _4CEjercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(2);

            Console.WriteLine(sumador + sumador2);
        }
    }
}