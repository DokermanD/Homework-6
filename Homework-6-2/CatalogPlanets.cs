using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_2
{
    public class CatalogPlanets
    {
        //Список для хранения планет
        public List<Planet> planets = new List<Planet>();
        
        public CatalogPlanets()
        {
            Planet Venera = new Planet();
            Venera.NamePlanet = "Венера";
            Venera.PlanetNumber = 2;
            Venera.LengthPlanetEquator = 38025;
            Venera.LinkPreviousPlanet = null;

            Planet Zemlia = new Planet();
            Zemlia.NamePlanet = "Земля";
            Zemlia.PlanetNumber = 3;
            Zemlia.LengthPlanetEquator = 40075;
            Zemlia.LinkPreviousPlanet = Venera;

            Planet Mars = new Planet();
            Mars.NamePlanet = "Марс";
            Mars.PlanetNumber = 4;
            Mars.LengthPlanetEquator = 21344;
            Mars.LinkPreviousPlanet = Zemlia;

            planets.Add(Venera);
            planets.Add(Zemlia);
            planets.Add(Mars);
        }

        //Счётчик вызова метода
        int schet = 0;
        public (int Number, int LengthPlanetEquator, string) GetPlanet(string planetName)
        {
            schet++;

            if (schet == 3)
            {
                schet = 0;
                return (0, 0, "Вы спрашиваете слишком часто.");
            }

            foreach (var planet in planets)
            {
                if (planet.NamePlanet == planetName)
                {
                    return (planet.PlanetNumber, planet.LengthPlanetEquator, "");
                }
            }

            return (0,0, "Не удалось найти планету.");
        }
    }
}
