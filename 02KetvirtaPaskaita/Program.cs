/*
 * Užduotis 2: Klasės ir Objektai
Aprašymas
Sukurkite programą, kuri atliks šias užduotis:
Sukurkite klasę Studentas su šiais laukais: vardas (string), amzius (int), balas (double).
Sukurkite metodą, kuris grąžina studento informaciją kaip string.
Sukurkite kelis studentų objektus ir pridėkite juos į sąrašą.
Išspausdinkite visų studentų informaciją.*/

using _02KetvirtaPaskaita;
using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Studentas> studentuSarasas = new List<Studentas>();

            Studentas studentas1 = new Studentas("Jonas", 18, 98.6);
            Studentas studentas2 = new Studentas("Petras", 20, 75.4);
            Studentas studentas3 = new Studentas("Tadas", 25, 65.6);

            studentuSarasas.Add(studentas1);
            studentuSarasas.Add(studentas2);
            studentuSarasas.Add(studentas3);

            Console.WriteLine("Atspausdinamas studentu sarasas..");
            AtspausdinkSarasa(studentuSarasas);
          

        }

        public static void AtspausdinkSarasa(List<Studentas> studentuSarasas)
        {
            foreach(var info in studentuSarasas)
            {
                Console.Write(info.Vardas.ToString() + " " + info.Amzius.ToString() + " " + info.Balas.ToString() + $"\n"); 
            }

        }
    }
}


