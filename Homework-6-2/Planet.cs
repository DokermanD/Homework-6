using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_2
{
    public class Planet
    {
        public string NamePlanet { get; set; }
        public int PlanetNumber { get; set; }
        public int LengthPlanetEquator { get; set; }
        public Planet LinkPreviousPlanet { get; set; }

    }
}
