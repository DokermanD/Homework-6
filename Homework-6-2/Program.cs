using System;
using System.Numerics;

namespace Homework_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogPlanets catalogPlanets = new CatalogPlanets();

            var namePlanets = new string[] { "Земля", "Лимония", "Марс" };

            for (int i = 0; i < namePlanets.Length; i++)
            {
                var rezalt = catalogPlanets.GetPlanet(namePlanets[i]);

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
