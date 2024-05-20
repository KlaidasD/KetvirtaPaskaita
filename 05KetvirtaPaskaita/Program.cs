/*Bibliotekos Valdymo Sistema
Aprašymas
Sukurkite bibliotekos valdymo sistemą, kuri leis sekti knygas ir jų paskolą.

PridetiKnyga(Knyga knyga): Prideda naują knygą į biblioteką.
SalintiKnyga(int id): Pašalina knygą pagal ID.
PaskolintiKnyga(int id): Pažymi knygą kaip paskolintą, jei ji nėra paskolinta.
GrazintiKnyga(int id): Pažymi knygą kaip grąžintą, jei ji yra paskolinta.
RodytiVisasKnygas(): Išspausdina visų knygų sąrašą.
RodytiPaskolintasKnygas(): Išspausdina tik paskolintų knygų sąrašą.

Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus
(pvz., pridėti knygą, pašalinti knygą, paskolinti knygą, grąžinti knygą, rodyti visas knygas, rodyti paskolintas knygas).*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<Knyga> knyguSarasas = new List<Knyga>();

            Biblioteka biblioteka = new Biblioteka(knyguSarasas);

            while (true)
            {

                Console.WriteLine("Sveiki, pasirinkite jusu norima funkcija.");
                Console.WriteLine("1.Prideti knyga.");
                Console.WriteLine("2.Pasalinti knyga.");
                Console.WriteLine("3.Paskolinti knyga.");
                Console.WriteLine("4.Grazinti knyga.");
                Console.WriteLine("5.Rodyti visas knygas.");
                Console.WriteLine("6.Rodyti paskolintas knygas.");
                Console.WriteLine("7.Uzdaryti programa.");



                int pasirinkimas = int.Parse(Console.ReadLine());

                if (pasirinkimas == 1)
                {
                    Console.WriteLine("Pridedama knyga.");
                    biblioteka.PridetiKnyga(SukurtiKnyga());
                }

                else if (pasirinkimas == 2)
                {
                    Console.WriteLine("Atspausdinamas knygu sarasas.");
                    for (int i = 0; i < knyguSarasas.Count; i++)
                    {
                        Console.WriteLine(knyguSarasas[i]);
                    }


                    Console.WriteLine("Kuria knyga (ID) norit pasalinti?");

                    int Id;

                    if (!int.TryParse(Console.ReadLine(), out Id))
                    {
                        Console.WriteLine("Ivestas netinkamas knygos ID.");
                        return;
                    }

                    biblioteka.SalintiKnyga(Id);

                    
                }

                else if (pasirinkimas == 3)
                {

                    Console.WriteLine("Atspausdinamas knygu sarasas.");
                    for (int i = 0; i < knyguSarasas.Count; i++)
                    {
                        Console.WriteLine(knyguSarasas[i]);
                    }

                    Console.WriteLine("Kuria knyga (ID) norite pasiskolinti?");

                    int Id;

                    if (!int.TryParse(Console.ReadLine(), out Id))
                    {
                        Console.WriteLine("Ivestas netinkamas knygos ID.");
                        return;
                    }

                    biblioteka.PaskolintiKnyga(Id);



                }
                else if (pasirinkimas == 4)
                {
                    Console.WriteLine("Atspausdinamas knygu sarasas.");
                    for (int i = 0; i < knyguSarasas.Count; i++)
                    {
                        Console.WriteLine(knyguSarasas[i]);
                    }
                    Console.WriteLine("Kuria knyga (ID) norite grazinti?");

                    int Id;

                    if (!int.TryParse(Console.ReadLine(), out Id))
                    {
                        Console.WriteLine("Ivestas netinkamas knygos ID.");
                        return;
                    }

                    biblioteka.GrazintiKnyga(Id);
                }
                else if (pasirinkimas == 5)

                {
                    biblioteka.RodytiVisasKnygas();
                }
                else if (pasirinkimas == 6)
                {

                    biblioteka.RodytiPaskolintasKnygas();
                }
                else if (pasirinkimas == 7)
                {
                    Console.WriteLine("Uzdaroma programa..");
                    break;
                }
                else
                {
                    Console.WriteLine("Pasirinkimas negalimas.");
                }
                

            }

            


        }


        public static Knyga SukurtiKnyga()
        {
            Console.WriteLine("Iveskite knygos Id.");
            int Id;
            if (!int.TryParse(Console.ReadLine(), out Id))
            {
                Console.WriteLine("Netinkamai ivestas Id.");
                return null;
            }

            Console.WriteLine("Iveskite knygos pavadinima.");
            string pavadinimas = Console.ReadLine();


            Console.WriteLine("Iveskite knygos autoriu.");
            string autorius = Console.ReadLine();


            Console.WriteLine("Ar knyga yra paskolinta? 1 - Paskolinta, 0 - Nepaskolinta");

            int ivestis = int.Parse(Console.ReadLine());
            bool paskolinta = false;

            if (ivestis == 0)
            {
                paskolinta = false;
            }

            else if (ivestis == 1)
            {
                paskolinta = true;
            }

            else
            {
                Console.WriteLine("Netinkama ivestis.");
            }

            Knyga knyga = new Knyga(Id, pavadinimas, autorius, paskolinta);

            return knyga;

        }
    }
}