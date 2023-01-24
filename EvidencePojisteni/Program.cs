using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EvidencePojisteni
{
    class Program
    {
        static void Main(string[] args)
        {
            char volba = '0';
while (volba != '4')
{
                Evidence evidencePojisteni = new Evidence();
                bool pokracovat = true;
                while (pokracovat)
                {
                    evidencePojisteni.VypisUvodniObrazovku();
                    Console.WriteLine();
                    Console.WriteLine("Vyberte si akci:");
                    Console.WriteLine(" 1 - Přidat nového pojištěného");
                    Console.WriteLine(" 2 - Vyhledat pojištěného");
                    Console.WriteLine(" 3 - Vypsat všechny pojištěné");
                    Console.WriteLine(" 4 - Konec");
                    volba = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    bool platnaVolba = true;
                    switch (volba)
                    {
                        case '1':
evidencePojisteni.ZjistiUdaje();
                            break;
                        case '2':
evidencePojisteni.VyhledejPojistence();
                            break;
                        case '3':
evidencePojisteni.VypisPojistence();
                            break;
                        case '4':
Console.WriteLine("Libovolnou klávesou ukončíte program...");
                            break;
                        default:
                            platnaVolba = false;
                            break;
                    }
                    if (platnaVolba)

                        Console.WriteLine();
                    else
                        Console.WriteLine("Neplatná volba");
                        Console.WriteLine("Přejete si zadat další akci?[a / n]");
                        platnaVolba = false;

                    while (!platnaVolba)
                    {
                        switch (Console.ReadKey().KeyChar.ToString().ToLower())
                        {
                            case "a":
                                pokracovat = true;
                                platnaVolba = true;
                                break;
                            case "n":
                                pokracovat = false;
                                platnaVolba = false;
                                break;
                            default:
                                Console.WriteLine("Neplatná volba, zadejte prosím a/ n");
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}