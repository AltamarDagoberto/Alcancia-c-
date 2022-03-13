using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------
//    INTEGRANTES
//    IVAN HERNANDEZ RUIZ
//    DAGOBERTO ALTAMAR
//-----------------------

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TOTAL = 0;
            int MENU;
            int CANTIDAD = 0;

            int MONEDA1 = 0;
            int MONEDA2 = 0;
            int MONEDA3 = 0;
            int MONEDA4 = 0;
            int MONEDA5 = 0;

            int TOTAL1 = 0;
            int TOTAL2 = 0;
            int TOTAL3 = 0;
            int TOTAL4 = 0;
            int TOTAL5 = 0;
            int TOTALT = 0;

            AHORRO M = new AHORRO();
            List<AHORRO> LISTA = new List<AHORRO>(TOTAL);
            List<AHORRO> LISTAMONEDA1 = new List<AHORRO>(TOTAL);
            List<AHORRO> LISTAMONEDA2 = new List<AHORRO>(TOTAL);
            List<AHORRO> LISTAMONEDA3 = new List<AHORRO>(TOTAL);
            List<AHORRO> LISTAMONEDA4 = new List<AHORRO>(TOTAL);
            List<AHORRO> LISTAMONEDA5 = new List<AHORRO>(TOTAL);

            do
            {
                Console.WriteLine(
                    "\n------------------------------" +
                    "\n------------------------------" +
                    "\n 1. Guardar monedas " +
                    "\n 2. Cantidad de monedas " +
                    "\n 3. Cantidad de dinero " +
                    "\n 4. Cantidad de moneda por denominacion " +
                    "\n 5. Cantidad de dinero  por denominacion " +
                    "\n 6. Salir" +
                    "\n------------------------------" +
                    "\n------------------------------");


                MENU = System.Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (MENU >= 1 || MENU <= 6)
                {
                    Console.WriteLine("ERROR");
                }

                Console.Clear();


                switch (MENU)
                {
                    case 1:
                        Console.WriteLine("\n Insertar moneda de las siguientes dominaciones: " +
                           "\n 50" +
                           "\n 100" +
                           "\n 200" +
                           "\n 500" +
                           "\n 1000" +
                           "\n------------------------------");
                        M.MONEDA = int.Parse(Console.ReadLine());
                        if (M.MONEDA == 50 || M.MONEDA == 100 || M.MONEDA == 200 || M.MONEDA == 500 || M.MONEDA == 1000)
                        {
                            Console.WriteLine("\n------------------------------" +
                                "\n------------------------------"+
                                "\n GUARDADO" +
                                "\n------------------------------" +
                                "\n------------------------------");
                            LISTA.Add(new AHORRO(M.MONEDA));
                            CANTIDAD = 0;
                            CANTIDAD++;
                        }
                        else
                        {
                            Console.WriteLine("\n------------------------------" +
                                "\n------------------------------" +
                                "\n Ingrese una moneda valida" +
                                "\n------------------------------" +
                                "\n------------------------------");
                        }

                        if (M.MONEDA == 50)
                        {
                            LISTAMONEDA1.Add(new AHORRO(M.MONEDA));
                            MONEDA1 = 0;
                            MONEDA1++;
                            TOTAL1 = LISTAMONEDA1.Count * 50;
                        }
                        else if (M.MONEDA == 100)
                        {
                            LISTAMONEDA2.Add(new AHORRO(M.MONEDA));
                            MONEDA2 = 0;
                            MONEDA2++;
                            TOTAL2 = LISTAMONEDA2.Count * 100;
                        }
                        else if (M.MONEDA == 200)
                        {
                            LISTAMONEDA3.Add(new AHORRO(M.MONEDA));
                            MONEDA3 = 0;
                            MONEDA3++;
                            TOTAL3 = LISTAMONEDA3.Count * 200;
                        }
                        else if (M.MONEDA == 500)
                        {
                            LISTAMONEDA4.Add(new AHORRO(M.MONEDA));
                            MONEDA4 = 0;
                            MONEDA4++;
                            TOTAL4 = LISTAMONEDA4.Count * 500;
                        }
                        else if (M.MONEDA == 1000)
                        {
                            LISTAMONEDA5.Add(new AHORRO(M.MONEDA));
                            MONEDA5 = 0;
                            MONEDA5++;
                            TOTAL5 = LISTAMONEDA5.Count * 1000;
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Se han registrado  " + LISTA.Count + $" monedas.");
                        break;

                    case 3:
                        TOTALT = TOTAL1 + TOTAL2 + TOTAL3 + TOTAL4 + TOTAL5;
                        Console.WriteLine($"Cantidad de dinero " + TOTALT);
                        break;

                    case 4:
                        Console.WriteLine("\n Ingrese el valor de la moneda que desea conocer su cantidad: " +
                           "\n 50" +
                           "\n 100" +
                           "\n 200" +
                           "\n 500" +
                           "\n 1000" +
                           "\n------------------------------");
                        M.MONEDA = int.Parse(Console.ReadLine());

                        if (M.MONEDA == 50)
                        {
                            Console.WriteLine($"Cantidad de monedas por denominacion de 50 es: " + LISTAMONEDA1.Count + $" monedas.");
                        }
                        else if (M.MONEDA == 100)
                        {
                            Console.WriteLine($"Cantidad de monedas por denominacion de 100 es: " + LISTAMONEDA2.Count + $" monedas.");
                        }
                        else if (M.MONEDA == 200)
                        {
                            Console.WriteLine($"Cantidad de monedas por denominacion de 200 es: " + LISTAMONEDA3.Count + $" monedas.");
                        }
                        else if (M.MONEDA == 500)
                        {
                            Console.WriteLine($"Cantidad de monedas por denominacion de 500 es: " + LISTAMONEDA4.Count + $" monedas.");
                        }
                        else if (M.MONEDA == 1000)
                        {
                            Console.WriteLine($"Cantidad de monedas por denominacion de 1000 es: " + LISTAMONEDA5.Count + $" monedas.");
                        }
                        else {
                            Console.WriteLine($"Moneda no valida");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n Ingrese el valor de la moneda al que desea conocer su total: " +
                           "\n 50" +
                           "\n 100" +
                           "\n 200" +
                           "\n 500" +
                           "\n 1000" +
                           "\n------------------------------");
                        M.MONEDA = int.Parse(Console.ReadLine());

                        if (M.MONEDA == 50)
                        {
                            Console.WriteLine($"Cantidad de dinero por denominacion de 50 es: " + TOTAL1);
                        }
                        else if (M.MONEDA == 100)
                        {
                            Console.WriteLine($"Cantidad de dinero por denominacion de 100 es: " + TOTAL2);
                        }
                        else if (M.MONEDA == 200)
                        {
                            Console.WriteLine($"Cantidad de dinero por denominacion de 200 es: " + TOTAL3);
                        }
                        else if (M.MONEDA == 500)
                        {
                            Console.WriteLine($"Cantidad de dinero por denominacion de 500 es: " + TOTAL4);
                        }
                        else if (M.MONEDA == 1000)
                        {
                            Console.WriteLine($"Cantidad de dinero por denominacion de 1000 es: " + TOTAL5);
                        }
                        else
                        {
                            Console.WriteLine($"Moneda no valida");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                }
            }
            while (MENU != 6);
            Console.Clear();
        }
    }
}
