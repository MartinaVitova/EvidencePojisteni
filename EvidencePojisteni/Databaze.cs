using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencePojisteni;
namespace EvidencePojisteni
{

    class Evidence
    {
        private Databaze databaze;
        public Evidence()
        {
            databaze = new Databaze();
        }
        //zjistí údaje pojištěnce
        public void ZjistiUdaje()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte věk pojištěného:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatné číslo, zadejte prosím věk znovu:");
            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            int telefon;
            while (!int.TryParse(Console.ReadLine(), out telefon))
                Console.WriteLine("Neplatné číslo, zadejte prosím telefon znovu:");
            databaze.PridejPojistence(new Pojistenci(jmeno, prijmeni, vek, telefon));
        }
        //vyhledání pojištěnce dle jmena a prijmeni
        public void VyhledejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine();
            Pojistenci pojistenec = databaze.VyhledejPojistence(jmeno, prijmeni);
            if (pojistenec != null)
                Console.WriteLine(pojistenec);
            else
                Console.WriteLine("Hledaný pojištěnec nebyl nalezen.");
        }
        //vypíše všechny pojištěnce
        public void VypisPojistence()

        {
            databaze.VypisPojistence();
        }
        //úvodní obrazovka programu
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\t \t EVIDENCE POJIŠŤENCŮ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
