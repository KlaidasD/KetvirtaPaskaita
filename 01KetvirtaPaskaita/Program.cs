using System;

namespace KetvirtaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {

           /*


            Užduotis 1: Sąrašų Manipuliacija
Aprašymas
Sukurkite programą, kuri atliks šias užduotis su sąrašu:
Sukurs sąrašą, kuriame yra šie sveikieji skaičiai: 5, 3, 8, 4, 2.
Išspausdins sąrašo elementus.
Pridės skaičių 10 į sąrašo pabaigą.
Ištrins skaičių 4 iš sąrašo.
Rūšiuos sąrašą didėjančia tvarka.
Išspausdins sąrašą po kiekvieno pakeitimo.


            */

            List<int> sveikiejiSkaiciai = new List<int> { 5, 3, 8, 4, 2};

            Console.WriteLine("Atspausdinamas skaiciu sarasas...");

            foreach (int skaicius in sveikiejiSkaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine("\nPridedamas skaicius 10 i skaiciu saraso gala..");
           
            sveikiejiSkaiciai.Add(10);

            Console.WriteLine("Atspausdinamas skaiciu sarasas po pridejimo.");

            foreach (int skaicius in sveikiejiSkaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine("\nIstrinimas 4 is skaiciu saraso..");

            sveikiejiSkaiciai.Remove(4);

            Console.WriteLine("Atspausdinamas skaiciu sarasas po 4 istrinimo.");

            foreach (int skaicius in sveikiejiSkaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine("\nIsrusiuojamas skaiciu sarasas.");
            sveikiejiSkaiciai.Sort();
            Console.WriteLine("Atspausdinamas skaiciu sarasas po isrusiavimo.");

            foreach (int skaicius in sveikiejiSkaiciai)
            {
                Console.Write(skaicius + " ");
            }
















        }

    }
}