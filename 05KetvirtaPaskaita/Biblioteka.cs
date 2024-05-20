using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaPaskaita
{

    /*Bibliotekos Valdymo Sistema
Aprašymas
Sukurkite bibliotekos valdymo sistemą, kuri leis sekti knygas ir jų paskolą.
Sukurkite klasę Biblioteka, kuri turės metodus:
PridetiKnyga(Knyga knyga): Prideda naują knygą į biblioteką.
SalintiKnyga(int id): Pašalina knygą pagal ID.
PaskolintiKnyga(int id): Pažymi knygą kaip paskolintą, jei ji nėra paskolinta.
GrazintiKnyga(int id): Pažymi knygą kaip grąžintą, jei ji yra paskolinta.
RodytiVisasKnygas(): Išspausdina visų knygų sąrašą.
RodytiPaskolintasKnygas(): Išspausdina tik paskolintų knygų sąrašą.
Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus
(pvz., pridėti knygą, pašalinti knygą, paskolinti knygą, grąžinti knygą, rodyti visas knygas, rodyti paskolintas knygas).*/


    public class Biblioteka
    {
        List<Knyga> KnyguSarasas = new List<Knyga>();

        public Biblioteka(List<Knyga>knyguSarasas)
        {
            KnyguSarasas = knyguSarasas;
        }

        public void PridetiKnyga(Knyga knyga)
        {

            KnyguSarasas.Add(knyga);

            Console.WriteLine("Sekmingai prideta knyga.");
        }

        public void SalintiKnyga(int id)
        {
            Knyga knygaKuriaTrinsiu = new Knyga();

            foreach (Knyga knyga in KnyguSarasas)
            {
                if(knyga.Id == id)
                {
                    knygaKuriaTrinsiu = knyga;
                   
                }
                
            }
            KnyguSarasas.Remove(knygaKuriaTrinsiu);

            Console.WriteLine($"Knyga sekmingai pasalinta.");
        }

        public void PaskolintiKnyga(int id)
        {

            foreach (Knyga knyga in KnyguSarasas)
            {
                if (knyga.Id == id)
                {
                    knyga.YraPaskolinta = true;

                }

            }

            Console.WriteLine($"Knyga sekmingai paskolinta.");

        }

        public void GrazintiKnyga(int id)
        {

            foreach (Knyga knyga in KnyguSarasas)
            {
                if (knyga.Id == id)
                {
                    knyga.YraPaskolinta = false;
                }

            }

            Console.WriteLine("Knyga sekmingai grazinta.");

        }

        public void RodytiVisasKnygas()
        {
            Console.WriteLine("Atspausdinamas knygu sarasas.");
            for (int i = 0; i < KnyguSarasas.Count; i++)
            {
                Console.WriteLine(KnyguSarasas[i]);
            }

        }

        public void RodytiPaskolintasKnygas()
        {

            Console.WriteLine("Atspausdinamas paskolintu knygu sarasas.");
            for (int i = 0; i < KnyguSarasas.Count; i++)
            {
                if (KnyguSarasas[i].YraPaskolinta == true)
                {
                    Console.WriteLine(KnyguSarasas[i]);
                }
                else
                {
                    Console.WriteLine("Paskolintu knygu sarase nera.");
                }
            }

        }

        

    }

}
