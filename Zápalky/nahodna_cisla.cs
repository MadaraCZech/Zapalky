using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zápalky
{
    class nahodna_cisla
    {
        public int generujliche(int min, int max)
        {
            Random random = new Random();
            int cislo = random.Next(min, max+1);
            int mezi_cislo = cislo;
            while (mezi_cislo > 1)
            {
                mezi_cislo = mezi_cislo - 2;
            }
            if (mezi_cislo == 0)
                cislo = cislo - 1;
            return cislo;
        }
    }
}
