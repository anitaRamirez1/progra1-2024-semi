﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prioridad de los operadores aritmeticos
            //ejercicio de obtener el promedio de una serie de numeros 
            int[] serie = new int[] { 5, 4, 6, 8, 9 };
            int suma = 0;
            foreach (int num in serie) {
                suma += num;
            }
            double prom = suma / serie.Length;
            Console.WriteLine("la suma es: {0}, el promedio {1}", suma, prom);

            //pausa
            Console.ReadLine();
        }
    }
}
