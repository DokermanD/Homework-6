using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_3
{
    public class CatalogPlanets
    {
        //Список для хранения планет
        List<Planet> planets = new List<Planet>();
        
        public CatalogPlanets()
        {
            Planet Venera = new Planet();
            Venera.NamePlanet = "Венера";
            Venera.PlanetNumber = 2;
            Venera.LengthPlanetEquator = 38025;

            Planet Zemlia = new Planet();
            Zemlia.NamePlanet = "Земля";
            Zemlia.PlanetNumber = 3;
            Zemlia.LengthPlanetEquator = 40075;

            Planet Mars = new Planet();
            Mars.NamePlanet = "Марс";
            Mars.PlanetNumber = 4;
            Mars.LengthPlanetEquator = 21344;

            planets.Add(Venera);
            planets.Add(Zemlia);
            planets.Add(Mars);
        }

        public delegate string PlanetValidator(string error);

        public (int Number, int LengthPlanetEquator, string ) GetPlanet(string planetName, PlanetValidator validator)
        {
            var rez = validator(planetName);
            if (rez != null) return (0, 0, rez);

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
