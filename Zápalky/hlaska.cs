using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zápalky
{
    class hlaska
    {

        public void stul(int zapalky)
        {

            string y = " zápalek.";
            if (zapalky == 1)
            {
                y = " zápalka";
            }

            if (zapalky > 1 && zapalky < 5)
            {
                y = " zápalky";
            }

            string x = "Na stole leží " + zapalky + y;
            Console.WriteLine(x);
        }

        public void pocitacbere(int zapalky)
        {
            string y = " zápalek.";
            if (zapalky == 1)
            {
                y = " zápalku.";
            }

            if (zapalky > 1 && zapalky < 5)
            {
                y = " zápalky.";
            }
            Console.WriteLine("Počítač bere " + zapalky + y);
        }

        public void hrac(int maximum)
        {
            string x = "Můžeš vzít 1 až " + maximum + ", kolik bereš ?";
            Console.WriteLine(x);
        }
    }
}
