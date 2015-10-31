using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zápalky
{
    class Program
    {
        static void Main(string[] args)
        {

            nahodna_cisla nahodna_cisla = new nahodna_cisla();
            hlaska hlaska = new hlaska();
            Random random = new Random();
            osetreni osetreni = new osetreni();
            bool konec = false;
            int na_stole;
            bool konec_hry = false;
            int maximum;
            string tah = "pc";
            string vyhra = "";

            while (konec_hry == false)
            {
                na_stole = nahodna_cisla.generujliche(2, 27);
                maximum = random.Next(2, 6);

                while (konec == false)
                {
                    Console.Clear();

                    if (tah == "pc")
                    {
                        if (na_stole == 1)
                        {
                            konec = true;
                            vyhra = "human";
                        }
                        else
                        {
                            if (na_stole == 0)
                            {
                                konec = true;
                                vyhra = "pc";
                            }
                            else
                            {
                                int pocet = 1000;
                                while (pocet >= na_stole)
                                {
                                    pocet = random.Next(1, maximum);
                                }
                                hlaska.stul(na_stole);
                                na_stole = na_stole - (pocet);
                                hlaska.pocitacbere(pocet);
                                tah = "human";
                            }
                        }
                    }

                    if (tah == "human")
                    {
                        if (na_stole == 1)
                        {
                            konec = true;
                            vyhra = "pc";
                        }
                        else
                        {
                            hlaska.stul(na_stole);
                            hlaska.hrac(maximum);
                            int pocet = osetreni.vstup(1, maximum);
                            na_stole = na_stole - pocet;
                            tah = "pc";
                        }
                    }

                }
                if (vyhra == "human")
                {
                    Console.WriteLine("Vyhráváš !");
                    tah = "pc";
                }
                else
                {
                    Console.WriteLine("Prohráváš !");
                    tah = "human";
                }
                konec = false;
                Console.ReadKey();
            }

        }
    }
}
