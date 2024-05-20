using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaPaskaita
{

    /*Bibliotekos Valdymo Sistema
Aprašymas
Sukurkite bibliotekos valdymo sistemą, kuri leis sekti knygas ir jų paskolą.
Sukurkite klasę Knyga su šiais laukais:
Id (int)
Pavadinimas (string)
Autorius (string)
YraPaskolinta (bool)

Sukurkite klasę Biblioteka, kuri turės metodus:
PridetiKnyga(Knyga knyga): Prideda naują knygą į biblioteką.
SalintiKnyga(int id): Pašalina knygą pagal ID.
PaskolintiKnyga(int id): Pažymi knygą kaip paskolintą, jei ji nėra paskolinta.
GrazintiKnyga(int id): Pažymi knygą kaip grąžintą, jei ji yra paskolinta.
RodytiVisasKnygas(): Išspausdina visų knygų sąrašą.
RodytiPaskolintasKnygas(): Išspausdina tik paskolintų knygų sąrašą.
Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus
(pvz., pridėti knygą, pašalinti knygą, paskolinti knygą, grąžinti knygą, rodyti visas knygas, rodyti paskolintas knygas).*/


    public class Knyga
    {
        public int Id;
        public string Pavadinimas;
        public string Autorius;
        public bool YraPaskolinta;

        public Knyga(int aId, string aPavadinimas, string aAutorius, bool aYraPaskolinta)
        {
            Id = aId;
            Pavadinimas = aPavadinimas;
            Autorius = aAutorius;
            YraPaskolinta = aYraPaskolinta;

            
        }

        public Knyga()
        {

        }


        public override string ToString()

        {
            return $"Id {Id}, Pavadinimas: {Pavadinimas}, Autorius: {Autorius}, Ar paskolinta? : {YraPaskolinta}";
        }



    }
}
