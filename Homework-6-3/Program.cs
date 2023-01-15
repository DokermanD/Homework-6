using System;
using System.Net.Sockets;
using System.Numerics;

namespace Homework_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogPlanets catalogPlanets = new CatalogPlanets();

            var namePlanets = new string[] { "Земля", "Лимония", "Марс" };

            for (int i = 0; i < 3; i++)
            {
                var rezalt = catalogPlanets.GetPlanet(namePlanets[i], (x) =>
                {
                    if (i == 2)
                    {                       
                        return ("Вы спрашиваете слишком часто.");
                    }
                    return null;
                });

                if (rezalt.Item3 == string.Empty)
                {
                    Console.WriteLine("Название - " + namePlanets[i]);
                    Console.WriteLine("Номер планеты от Солнца - " + rezalt.Number);
                    Console.WriteLine("Длина экватора - " + rezalt.LengthPlanetEquator);
                    Console.WriteLine("--------------------------------");
                }
                else if (rezalt.Item3 == "Не удалось найти планету")
                {
                    Console.WriteLine(rezalt.Item3 + " - " + namePlanets[i]);
                    Console.WriteLine("--------------------------------");
                }
                else
                {
                    Console.WriteLine(rezalt.Item3);
                    Console.WriteLine("--------------------------------");
                }
            }

            //Задание со звёздочкой -----------------------------------------------------------
            Console.WriteLine("\nЗадание со звёздочкой ----------------------------------\n");
            for (int i = 0; i < 3; i++)
            {
                var rezalt = catalogPlanets.GetPlanet(namePlanets[i], (x) =>
                {
                    if ( x == "Лимония")
                    {
                        return ("Это запретная планета.");
                    }
                    return null;
                });

                if (rezalt.Item3 == string.Empty)
                {
                    Console.WriteLine("Название - " + namePlanets[i]);
                    Console.WriteLine("Номер планеты от Солнца - " + rezalt.Number);
                    Console.WriteLine("Длина экватора - " + rezalt.LengthPlanetEquator);
                    Console.WriteLine("--------------------------------");
                }
                else if (rezalt.Item3 == "Не удалось найти планету")
                {
                    Console.WriteLine(rezalt.Item3 + " - " + namePlanets[i]);
                    Console.WriteLine("--------------------------------");
                }
                else
                {
                    Console.WriteLine(rezalt.Item3);
                    Console.WriteLine("--------------------------------");
                }
            }
        }
    }
}
