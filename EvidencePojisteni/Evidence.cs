using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EvidencePojisteni
{
    class Databaze
    {
        private List<Pojistenci> pojistenec;
        public Databaze()
        {
            pojistenec = new List<Pojistenci> ();
        }

        //Přidá nového pojištěnce do databáze

        public void PridejPojistence(string Jmeno, string Prijmeni, int Vek, int Telefon)
        {
            pojistenec.Add(new Pojistenci(Jmeno, Prijmeni, Vek, Telefon));
        }
        public void PridejPojistence(Pojistenci p)
        {
            pojistenec.Add(p);
        }

        //Najde pojištěnce dle jména a příjmení
        public Pojistenci VyhledejPojistence(string jmeno, string prijmeni)
        {
            foreach (Pojistenci p in pojistenec)
            {
                if (p.Jmeno == jmeno && p.Prijmeni == prijmeni)
`               return p;
            }
                return null;
        }

        //Vypíše všechny pojištěnce
        public void VypisPojistence()
        {
            if (pojistenec.Count > 0)
            {
                foreach (Pojistenci p in pojistenec)
                    Console.WriteLine(p);
            }
                else
                Console.WriteLine("Databáze je prázdná.");
        }
    }
}
