/*4. Užduotis: Studentų administravimas
Aprašymas
Sukurti programą, kuri atliks šias užduotis:
Sukurkite klasę Studentas su šiais laukais: vardas (string), pavarde (string), amzius (int), balai int masyvas, vidurkis double.
Sukurkite meniu (1. Sukurti studenta, 2. Istrinti studenta, 3. Isvesti studentus i ekrana)
Klasėje Studentas sukurkite funkciją kuri skaičiuoja studento vidurkį
Prieš išvedant studentą į ekraną, visada iškviesti šią funkciją, kad ji suskaičiuotų studento vidurkį. (Override'e ToString)*/

using System;
using System.ComponentModel.Design;

namespace KetvirtaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Studentas> studentuSarasas = new List<Studentas>();

            while(true)
            {

                Console.WriteLine("Sveiki, pasirinkite jusu norima funkcija.");
                Console.WriteLine("1.Sukurti studenta.");
                Console.WriteLine("2.Istrinti studenta.");
                Console.WriteLine("3.Isvesti studentus i ekrana.");
                Console.WriteLine("4.Uzdaryti programa.");

                int pasirinkimas = int.Parse(Console.ReadLine());

                if (pasirinkimas == 1)
            {
                    Console.WriteLine("Iveskite studento varda.");
                    string vardas = Console.ReadLine();

                    Console.WriteLine("Iveskite studento pavarde.");
                    string pavarde = Console.ReadLine();

                    Console.WriteLine("Iveskite studento amziu.");
                    int amzius;

                    if(!int.TryParse(Console.ReadLine(), out amzius))
                    {
                        Console.WriteLine("Netinkamai ivestas amzius.");
                        return;
                    }

                    Console.WriteLine("Kiek balu norite ivesti?");
                    int baluS;
                    if(!int.TryParse(Console.ReadLine(), out baluS))
                    {
                        Console.WriteLine("Netinkamai ivestas balu skaicius.");
                        return;
                    }

                    int[] balai = new int[baluS];

                    for(int i = 0; i < balai.Length; i++)
                    {
                        Console.WriteLine($"Iveskite {i + 1} bala.");
                        int ivestasB;
                        if (int.TryParse(Console.ReadLine(), out ivestasB))
                        {
                            balai[i] = ivestasB;
                        }

                        else
                        {
                            Console.WriteLine("Ivestas netinkamas balas..");
                            return;
                        }
                        
                    }

                    Studentas studentas = new Studentas(vardas, pavarde, amzius, balai);

                    studentuSarasas.Add(studentas);

                    Console.WriteLine("Sekmingai pridetas studentas.");
                    


            }

            else if (pasirinkimas == 2)
            {
                    Console.WriteLine("Atspausdinamas studentu sarasas...");
                    if (studentuSarasas.Count < 1)
                    {
                        Console.WriteLine("Nera studentu.");
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < studentuSarasas.Count; i++)
                        {
                            Console.WriteLine($"{i}. {studentuSarasas[i]}");
                        }
                    }

                    Console.WriteLine("Kuri studenta noretumete istrinti?");
                    int istrinti;
                    if (int.TryParse(Console.ReadLine(), out istrinti) && istrinti >= 0 && istrinti < studentuSarasas.Count)
                    {
                        studentuSarasas.RemoveAt(istrinti);
                        Console.WriteLine("Studentas istrintas.");
                        return;
                    }

                    else
                    {
                        Console.WriteLine("Netinkamas pasirinkimas.");
                        return;
                    }

                    

            }

            else if(pasirinkimas == 3)
            {

                    if (studentuSarasas.Count < 1)
                    {
                        Console.WriteLine("Studentu sarase nera.");
                        return;
                    }

                    Console.WriteLine("Spausdinamas studentu sarasas..");
                    for(int i = 0; i < studentuSarasas.Count;i++)
                    {
                        Console.WriteLine(studentuSarasas[i].ToString());
                    }
                    

            }
            else if(pasirinkimas == 4)
                {
                    Console.WriteLine("Uzdaroma programa..");
                    break;
                }
                else
                {
                    Console.WriteLine("Toks pasirinkimas negalimas.");
                    return;
                }
            

            }





    }
        

    }
}