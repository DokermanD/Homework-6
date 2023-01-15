using System;
using System.Numerics;

namespace Homework_6 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Venera = new
            {
                Name = "Венера",
                Equatorlength = 38025,
                Number = 2,
            };

            var Zemlia = new
            {
                Name = "Земля",
                Equatorlength = 40075,
                Number = 3,
                LinkPreviousPlanet = Venera
            };

            var Mars = new
            {
                Name = "Марс",
                Equatorlength = 21344,
                Number = 4,
                LinkPreviousPlanet = Zemlia
            };

            var Venera2 = new
            {
                Name = "Венера",
                Equatorlength = 38025,
                Number = 2,
            };

            Console.WriteLine("Название - " + Venera.Name);
            Console.WriteLine("Порядковый номер от Солнца - " + Venera.Number);
            Console.WriteLine("Длина экватора - " + Venera.Equatorlength);
            Console.WriteLine("Предыдущая планета - нет ссылки");
            Console.WriteLine("Эквивалентна ли Венере - " + Venera.Equals(Venera));
            Console.WriteLine();

            Console.WriteLine("Название - " + Zemlia.Name);
            Console.WriteLine("Порядковый номер от Солнца - " + Zemlia.Number);
            Console.WriteLine("Длина экватора - " + Zemlia.Equatorlength);
            Console.WriteLine("Предыдущая планета - " + Zemlia.LinkPreviousPlanet);
            Console.WriteLine("Эквивалентна ли Венере - " + Zemlia.Equals(Venera));
            Console.WriteLine();

            Console.WriteLine("Название - " + Mars.Name);
            Console.WriteLine("Порядковый номер от Солнца - " + Mars.Number);
            Console.WriteLine("Длина экватора - " + Mars.Equatorlength);
            Console.WriteLine("Предыдущая планета - " + Mars.LinkPreviousPlanet);
            Console.WriteLine("Эквивалентна ли Венере - " + Mars.Equals(Venera));
            Console.WriteLine();

            Console.WriteLine("Название - " + Venera2.Name);
            Console.WriteLine("Порядковый номер от Солнца - " + Venera2.Number);
            Console.WriteLine("Длина экватора - " + Venera2.Equatorlength);
            Console.WriteLine("Предыдущая планета - нет ссылки");
            Console.WriteLine("Эквивалентна ли Венере - " + Venera2.Equals(Venera));
            Console.WriteLine();

            Console.ReadLine(); 
        }
    }
}


