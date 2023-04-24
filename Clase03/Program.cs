using System;
using BibliotecaDeClasesEj1;

namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Juanito", 100);
            //Cuenta cuenta2 = new Cuenta("Carla", 999);
            //Cuenta cuenta3 = new Cuenta("Hernesto", 765);
            //Cuenta cuenta4 = new Cuenta("Laureano", 89687);
            int respuesta = 0;
            float ingreso = 0;
            //bool ingresoBien;
            char sigueOperando;

            do
            {
                Console.WriteLine(cuenta1.Mostrar());
                Console.WriteLine("OPERACIONES QUE PUEDE REALIZAR:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1. INGRESAR DINERO.");
                Console.WriteLine("2. RETIRAR DINERO.");
                Console.WriteLine("Que operacion desea realizar?: ");
                bool pudoCambiar = int.TryParse(Console.ReadLine(), out respuesta);
                while(!(pudoCambiar))
                {
                    Console.WriteLine("ERROR, que operacion desea realizar?: ");
                    pudoCambiar = int.TryParse(Console.ReadLine(), out respuesta);
                }
                if(respuesta == 1)
                {
                    Console.WriteLine("Colocar la cantidad que desea ingresar a la cuenta: ");
                    bool pudoIngresar = float.TryParse(Console.ReadLine(), out ingreso);
                    while(!(pudoIngresar))
                    {
                        Console.WriteLine("ERROR, colocar la cantidad que desea ingresar a la cuenta: ");
                        pudoIngresar = float.TryParse(Console.ReadLine(), out ingreso);
                    }
                    if(cuenta1.Ingresar(ingreso) == true)
                    {
                        Console.WriteLine("INGRESO EL DINERO EXITOSAMENTE!");
                        Console.WriteLine(cuenta1.Mostrar());
                    }
                    else
                    {
                        Console.WriteLine("FALLO EN EL INGRESO DEL DINERO!");
                    }
                }
                else if (respuesta == 2)
                {
                    Console.WriteLine("Colocar la cantidad que desea sacar a la cuenta: ");
                    bool pudoSacar = float.TryParse(Console.ReadLine(), out float egreso);
                    while (!(pudoSacar))
                    {
                        Console.WriteLine("ERROR, colocar la cantidad que desea sacar a la cuenta: ");
                        pudoSacar = float.TryParse(Console.ReadLine(), out egreso);
                    }
                    if ((cuenta1.Sacar(egreso)) == true)
                    {
                        Console.WriteLine("EGRESO DEL DINERO EXITOSAMENTE!");
                        Console.WriteLine(cuenta1.Mostrar());
                    }
                }
                Console.WriteLine("DESEA SEGUIR REALIZANDO OPERACIONES? s/n: ");
                sigueOperando= char.Parse(Console.ReadLine());
                
            } while (sigueOperando == 's');
            //Console.WriteLine(cuenta1.Mostrar());1

            //Console.WriteLine(cuenta2.Mostrar());
            //Console.WriteLine(cuenta3.Mostrar());
            //Console.WriteLine(cuenta4.Mostrar());
           
        }
    }
}