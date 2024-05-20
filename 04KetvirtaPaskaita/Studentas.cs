using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaPaskaita
{
    public class Studentas
    {
        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public int[] Balai;
        public double Vidurkis;

        public Studentas(string aVardas,string aPavarde, int aAmzius, int[] aBalai)
        {
            Vardas = aVardas;
            Pavarde = aPavarde;
            Amzius = aAmzius;
            Balai = aBalai;
        }

        public double ApskaiciuokVidurki()
        {
            int suma = 0;
            for(int i = 0; i < Balai.Length; i++)
            {
                suma += Balai[i];
            }

            Vidurkis = suma / Balai.Length;

            return Vidurkis;

        }

        public override string ToString()

        {
            return $"Vardas: {Vardas}, Pavardė: {Pavarde}, Amžius: {Amzius}, Balai: {string.Join(", ", Balai)} Vidurkis: {ApskaiciuokVidurki()}";
        }


    }
}
