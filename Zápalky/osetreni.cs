using System;

public class osetreni
{

    public int vstup(int min, int max)
    {
        bool spravne = false;
        int x = 0;
        while (spravne == false)
        {
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > max || x < min)
                    Console.WriteLine("Je dané minimální a maximální číslo, které můžeš zadat.");
                else
                    spravne = true;
            }
            catch
            {
                Console.WriteLine("Neplatná volba");
            }
        }
        return x;
    }

}
