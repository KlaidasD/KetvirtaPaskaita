/*Užduotis 3: Ciklai ir Sąlygos Sakiai
Aprašymas
Sukurkite programą, kuri atliks šias užduotis:
Sugeneruos sveikųjų skaičių sąrašą nuo 1 iki 100.
Naudos ciklą, kad patikrintų kiekvieną skaičių ir išspausdins "Fizz", jei skaičius dalijasi iš 3, "Buzz", jei dalijasi iš 5, ir "FizzBuzz",
jei dalijasi ir iš 3, ir iš 5. Jei nei viena iš šių sąlygų netinka, išspausdins patį skaičių.*/

using System;

namespace KetvirtaPaskaita
{
    public class Program

    {
        public static void Main(string[] args)
        { 

            List<int> sveikiejiSkaiciai = new List<int>();

            Console.WriteLine("Pridedami skaiciai i sarasa..");

            Random rnd = new Random();

            for(int i = 0; i < 100; i++)
            {
                sveikiejiSkaiciai.Add(rnd.Next(0, 100));
            }

            for(int i = 0;i < sveikiejiSkaiciai.Count; i++)
            {
                if (sveikiejiSkaiciai[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (sveikiejiSkaiciai[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (sveikiejiSkaiciai[i] % 5 == 0 && sveikiejiSkaiciai[i] % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else
                {
                    Console.WriteLine(sveikiejiSkaiciai[i]);
                }
            }


        
        }
    }
}