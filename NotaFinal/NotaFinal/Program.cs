﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine()); //8
            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine()); // 9
            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); //7
                                                                // 8 * 30 %= 2.4
                                                                // 9 * 30 % = 2.7
                                                                // 7 * 40 %= 2.8
                                                                // C1 = 7,9

            Double C1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", C1);

            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine());

            Double C2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", C2);

            // TAREA: Obtener la nota final por computadora y Nota Final de la matera de Programación I.


            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine());

            Double C3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C3 es: {0}", C3);

            Double ntf = (C1 + C2 + C3) / 3;
            Console.WriteLine("la nota final es: {0}", ntf);
            // Pausa.
            Console.ReadLine();
        }
    }
}
