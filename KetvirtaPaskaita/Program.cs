using System;

namespace KetvirtaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Pavyzdziai 
             * 
             * for(int i = 0;i < 10;i++)
                  {
                  Console.WriteLine(i);
                  }





                int x = 0;

                while (x < 100)
                  {
                  Console.WriteLine(x);
                  x++;
                  }





                  //TAS PATS KAIP IR WHILE
                  for(int i = 0; i < 100; i++)
                  {
                  Console.WriteLine(i);
                  }





            int progress = 0;
Console.WriteLine("Loading...");

while (progress <= 100)
{   
                 Console.Write($"\rProgress: {progress}%");
        Thread.Sleep(100); 
    progress += 1; 
}
Console.WriteLine();
Console.WriteLine("Loading complete!");





            int[] skaiciai = { 16, 23, 13, 44, 95, 16, 27, };
Console.WriteLine(skaiciai[3] + skaiciai[1]);
skaiciai[1] = -77;
Console.WriteLine(skaiciai[3] + skaiciai[1]);






            int[] skaiciai = new int[10];
skaiciai[0] = 55;
skaiciai[1] = 12;
skaiciai[2] = 76;
skaiciai[3] = 53;
skaiciai[4] = 5;

int suma = 0;

for(int i = 0; i < skaiciai.Length; i++)
{
    suma += skaiciai[i];
}
Console.WriteLine(suma);




             double X = 8.55;

            double Z = 0;

            for(int i = 0; i < 10; i++)
            {
                double Y = 0.99;
                X += 0.5;
                Console.WriteLine(X);
                Console.WriteLine(Y);
                Z = Y;
            }
            Console.WriteLine(Z);

            X = X - 0.7;

            while(X < 25.55)
            {
                X += 0.8;
                Console.WriteLine(X);
            }
            Console.WriteLine(X);




            public class Program
    {
        public static void Main(string[] args)
        {
            FunkcijuKlase funkcijuKlase = new FunkcijuKlase();
            int keturi = funkcijuKlase.Grazink2x2();
            int devyni = funkcijuKlase.Grazink3x3();
        }
       
        
    }
    public class FunkcijuKlase
    {
        public void SpausdinkVarda(string vardas)
        {
            Console.WriteLine(vardas);
        }
        public void SpausdinkPavarde(string vardas)
        {
            Console.WriteLine(vardas);
        }
        public int Grazink2x2()
        {
            return DauginkDuSkaicius(2,2);
        }
        public int Grazink3x3()
        {
            return DauginkDuSkaicius(3, 3);
        }
        private int DauginkDuSkaicius(int a, int b)
        {
            return a * b;
        }
    }




static void Main(string[] args)
{
    int number = 5;
    ChangeValue(ref number);
    number = ChangeValueX2(number);
    Console.WriteLine(number);
}

public static void ChangeValue(ref int number)
{
    number += 5;
}
public static int ChangeValueX2(int number)
{
    number *= 2;
    return number;
}







            using System;

namespace AntraPaskaita
{
    public class Program
    {
        /// <summary>
        /// Cia mano main LOL
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            if (ArAsmuoPilnametis(1998, out int joGimimoMetai))
            {
                Console.WriteLine($"Asmuo yra pilnametis, jam yra {joGimimoMetai} metai");
            }
            else
            {
                Console.WriteLine($"Asmuo nera pilnametis, jam yra {joGimimoMetai} metai");
            }
        }
        /// <summary>
        /// Sita funkcija patikrina pagal gimimo metus ar asmuo yra pilnametis
        /// </summary>
        /// <param name="gimimoMetai">paduodami gimimo metai</param>
        /// <param name="metai">grazinamas asmens amzius</param>
        /// <returns>true jeigu asmuo yra pilnametis arba false jei jam yra maziau nei 18</returns>
        public static bool ArAsmuoPilnametis(int gimimoMetai, out int metai)
        {
            metai = 2024 - gimimoMetai;
            if(metai >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ChangeValue(out int number)
        {
            number = 5;
            number *= number;
        }
        public static int ChangeValueX2(int number)
        {
            number *= 2;
            return number;
        }
    }





public class FunkcijuKlase
    {
        string manoVardas = "Sarunas";
        string manoPavarde = "Genys";
        public void SpausdinkVarda(string vardas)
        {
            Console.WriteLine(vardas);
        }
        public void SpausdinkPavarde(string vardas)
        {
            Console.WriteLine(vardas);
        }
        public string SudetiVardaPavarde(string vardas, string pavarde)
        {
            string sudetas = string.Format("{0} {1}", manoVardas, manoPavarde);
            int skaicius = 0;
            return skaicius.ToString();
        }
        public int Grazink2x2()
        {
            return DauginkDuSkaicius(2,2);
        }
        public int Grazink3x3()
        {
            return DauginkDuSkaicius(3, 3);
        }
        private int DauginkDuSkaicius(int a, int b)
        {
            return a * b;
        }




            using System;

namespace AntraPaskaita
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objekto sukurimas ir uzpildymas
            Zmogus studentas = new Zmogus();
            studentas.Vardas = "Jonas";
            studentas.Pavarde = "Jonaitis";
            studentas.GimimoMetai = DateTime.Parse("1998-12-04");

            Augintinis gyvunas1 = new Augintinis();
            gyvunas1.Vardas = "Murkis";
            gyvunas1.Rusis = "Katinas";

            Augintinis gyvunas2 = new Augintinis();
            gyvunas2.Vardas = "Lakis";
            gyvunas2.Rusis = "Suo";
            gyvunas2.GimimoMetai = DateTime.Parse("2017-12-04");

            Zmogus studentas2 = new Zmogus("Petras", "Petraitis", DateTime.Parse("1998-12-11"));
            Zmogus studentas3 = new Zmogus("Petras", "Petraitis", DateTime.Parse("1998-12-11"), gyvunas2);

            Console.WriteLine($" Studento {studentas3.Vardas} augininis yra {studentas3.GetAugintinis()}");

            Console.WriteLine($"Pirmas gyvas {gyvunas1} \n antras gyvunas {gyvunas2}");
            Console.WriteLine($"Pirmas gyvas {gyvunas1.ToString(true)} \n antras gyvunas {gyvunas2.ToString(false)}");
            Console.WriteLine();

            studentas.SetAugintinis(gyvunas1);

            studentas.SkaiciuotiAmziu();
            Console.WriteLine($"Studento {studentas.Vardas} amzius yra {studentas.GetAmzius()}");
            
        }
        
    }




            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPaskaita
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public DateTime GimimoMetai { get; set; }
        private Augintinis ZmogausAugintinis { get; set; }
        private int Amzius;

        public Zmogus()
        {

        }
        public Zmogus(string vardas, string pavarde, DateTime gimimoData) 
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoData;
        }
        public Zmogus(string vardas, string pavarde, DateTime gimimoData, Augintinis augintinis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoData;
            ZmogausAugintinis = augintinis;
        }
        public Augintinis GetAugintinis()
        {
            return ZmogausAugintinis;
        }
        public void SetAugintinis(Augintinis augintinis)
        {
            ZmogausAugintinis = augintinis;
        }
        public int GetAmzius()
        {
            return Amzius;
        }
        public void SkaiciuotiAmziu()
        {
            Amzius = (int)(DateTime.Now - GimimoMetai).TotalDays / 365;
        }

    }
    public class Augintinis
    {
        public string Vardas { get; set; }
        public string Rusis { get; set; }
        public DateTime GimimoMetai { get; set; }

        public override string ToString()
        {
            return Vardas + " " + Rusis + " " + GimimoMetai.ToString("yyyy-MM-dd");
        }
        public string ToString(bool atbulai)
        {
            if (atbulai)
                return Rusis + " " + Vardas + " " + GimimoMetai.ToString("yyyy-MM-dd");
            else
                return ToString();
        }

    }
}


}





    }
}

            











        
        }
        
    }
}