using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversorlb
{
    class Program
    {
        private static object tiempoConversiones;

        public static string[] unidadtiempo { get; private set; }

        static void Main(string[] args)
        {

         
           
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione el tipo de conversión:");
                    Console.WriteLine("1 pie cuadrado");
                    Console.WriteLine("2. vara cuadada");
                    Console.WriteLine("3. yarda cuadrada");
                    Console.WriteLine("4. metro cuadrado");
                    Console.WriteLine("5. tareas");
                    Console.WriteLine("6. manzanas");
                    Console.WriteLine("7. ectareas");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Convertirpie();
                            break;
                        case "2":
                            ConvertirTiempo();
                            break;
                        case "3":
                            ConvertirMasa();
                            break;
                        case "4":
                            ConvertirVolumen();
                            break;
                        case "5":
                            convertirLongitud();
                            break;
                        case "6":
                            ConversionesAlmacenamiento();
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
            }

            static void Convertirpie()
            {
                string[] monedas = { "pie cuadrado", "vara cuadrada",  "yarda cuadrada", "metro cuadrado", "tarea", "manzana ", "hectarea" };
                double[,] monedaTarifas = {
            { 1, 0.1329, 0.111 , 0.092, 0.09, 0.70, 0.000009 }, // pie
            { 272.25, 1,30.25, 25.29, 0.69, 2.47, 0.00009 }, // Evara
            { 9, 0.033, 1, 0.8, 752.03, 0.69, 0.00008 }, // yarda
            { 10.76, 0.039, 1.195, 1, 628.8, 7044, 0.0001 }, // metros
            { 0.09,0.69,  752.03,  628.8,1, 16, 0.062}, // tareas
            { 0.70, 2.47, 0.69, 7044, 16, 1, 0.40}, // manzana
            {0.000009, 0.00009,  0.00008,  0.0001, 0.062, 0.40, 1}, //hectareas
           
        };


                int from = SelectOption("convertir", monedas);
                int to = SelectOption("a que desea convertirlo", monedas);

                double amount = InputAmount($"la cantidad de {monedas[from]} que desea convertir a {monedas[to]}");
                double result = amount * monedaTarifas[from, to];

                Console.WriteLine($"{amount} {monedas[from]} es igual a {result:F2} {monedas[to]}.");
                ContinuePrompt();
            }

            static void ConvertirTiempo()
            {
            string[] monedas = { "pie cuadrado", "vara cuadrada", "yarda cuadrada", "metro cuadrado", "tarea", "manzana ", "hectarea" };
            double[,] monedaTarifas = {
            { 1, 0.1329, 0.111 , 0.092, 0.09, 0.70, 0.000009 }, // pie
            { 272.25, 1,30.25, 25.29, 0.69, 2.47, 0.00009 }, // Evara
            { 9, 0.033, 1, 0.8, 752.03, 0.69, 0.00008 }, // yarda
            { 10.76, 0.039, 1.195, 1, 628.8, 7044, 0.0001 }, // metros
            { 0.09,0.69,  752.03,  628.8,1, 16, 0.062}, // tareas
            { 0.70, 2.47, 0.69, 7044, 16, 1, 0.40}, // manzana
            {0.000009, 0.00009,  0.00008,  0.0001, 0.062, 0.40, 1}, //hectareas
           
        };

            int from = SelectOption("unidad de tiempo de origen", unidadtiempo);
                int to = SelectOption("unidad de tiempo de destino", unidadtiempo);

                double amount = InputAmount($"la cantidad de {unidadtiempo[from]} que desea convertir a {unidadtiempo[to]}");
                double result = amount * tiempoConversiones[from, to];

                Console.WriteLine($"{amount} {unidadtiempo[from]} es igual a {result:F2} {unidadtiempo[to]}.");
                ContinuePrompt();
            }

            static void ConvertirMasa()
            {
            string[] monedas = { "pie cuadrado", "vara cuadrada", "yarda cuadrada", "metro cuadrado", "tarea", "manzana ", "hectarea" };
            double[,] monedaTarifas = {
            { 1, 0.1329, 0.111 , 0.092, 0.09, 0.70, 0.000009 }, // pie
            { 272.25, 1,30.25, 25.29, 0.69, 2.47, 0.00009 }, // Evara
            { 9, 0.033, 1, 0.8, 752.03, 0.69, 0.00008 }, // yarda
            { 10.76, 0.039, 1.195, 1, 628.8, 7044, 0.0001 }, // metros
            { 0.09,0.69,  752.03,  628.8,1, 16, 0.062}, // tareas
            { 0.70, 2.47, 0.69, 7044, 16, 1, 0.40}, // manzana
            {0.000009, 0.00009,  0.00008,  0.0001, 0.062, 0.40, 1}, //hectareas

             int from = SelectOption("unidad de tiempo de origen", unidadtiempo);
            int to = SelectOption("unidad de tiempo de destino", unidadtiempo);

            double amount = InputAmount($"la cantidad de {unidadtiempo[from]} que desea convertir a {unidadtiempo[to]}");
            double result = amount * tiempoConversiones[from, to];

            Console.WriteLine($"{amount} {unidadtiempo[from]} es igual a {result:F2} {unidadtiempo[to]}.");
            ContinuePrompt();
        }

            static void ConvertirVolumen()
            {
            Console.WriteLine("Calculadora de Impuesto a las Actividades Económicas");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Ingrese el monto de la actividad económica:");
            double monto = double.Parse(Console.ReadLine());

            double impuesto = CalcularImpuesto(monto);

            Console.WriteLine($"El impuesto a pagar es: ${impuesto:F2}");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static double CalcularImpuesto(double monto)
        {
            double[] rangos = { 0.01, 500.01, 1000.01, 2000.01, 3000.01, 6000, 8000, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01, 400000.01, 500000.01, 10000000.1 };
            double[] precios = { 1.5, 1.5, 3, 3, 6, 9, 15, 39, 63, 93, 125, 195, 255, 300, 340, 490 };
            double[] adicionales = { 0, 3, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45, 0.4, 0.30, 0.18 };

            int i = 0;
            while (monto > rangos[i])
            {
                i++;
            }

            double exceso = monto - rangos[i - 1];
            double impuesto = (exceso / 1000) * adicionales[i - 1] + precios[i - 1];

            return impuesto;
        }
    }
}
