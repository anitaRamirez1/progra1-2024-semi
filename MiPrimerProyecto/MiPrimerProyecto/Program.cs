using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma de dos numeros introducidos por el usuario
            Console.WriteLine("ingrese el numero 1 que desea sumar ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero 2 para sumar ");
            int num2 = int.Parse(Console.ReadLine());

            int respuesta = num1 + num2;

            Console.WriteLine("la suma es {0} + {1} = {2}", num1, num2, respuesta);

            Console.ReadLine();


        }
    }
}
