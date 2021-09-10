using System;
using System.Collections.Generic;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kund> KundLista = new List<Kund>();

            KundLista.Add(new Kund() { Namn = "Anki Larsson", Ålder = 23, Körkort = true });
            KundLista.Add(new Kund() { Namn = "Frej Andersson", Ålder = 56, Körkort = false });
            KundLista.Add(new Kund() { Namn = "Ludvig Nyqvist", Ålder = 19, Körkort = true });

            bool a = true;
            while (a)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\tKUNDMENY");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Skapa ny kund\n");
                Console.WriteLine("2. Visa antal kunder\n");
                Console.WriteLine("3. Kundlista\n");
                Console.WriteLine("4. Avsuta program\n");

                string val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\tSKAPA NY KUND");
                    Console.WriteLine("====================================");
                    Console.WriteLine("Namn:");
                    string namn = Console.ReadLine();                    
                    Console.WriteLine("Ålder:");
                    int ålder = Int32.Parse(Console.ReadLine());                    
                    Console.WriteLine("Körkort? (True/False):");
                    bool körkort = bool.Parse(Console.ReadLine());

                    KundLista.Add(new Kund(){Namn = namn, Ålder = ålder, Körkort = körkort });
                    Console.ReadLine();
                }

                if (val == "2")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine($"\t ANTAL KUNDER = {KundLista.Count}");
                    Console.ReadLine();
                }
                if (val == "3")
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\tKUNDLISTA");
                    Console.WriteLine("====================================");
                    foreach (Kund k in KundLista)
                    {
                        Console.WriteLine($"Namn\t{k.Namn}\nÅlder\t{k.Ålder}\nKörkort\t{k.Körkort}\n");

                    }
                    Console.ReadLine();
                }

                if (val == "4")
                {
                    a = false;
                }
                if (val != "1" && val != "2" && val != "1" && val != "3" && val != "4")
                {
                    Console.WriteLine("======================================");
                    Console.WriteLine("=\tFELAKTIG INMATNING           =");
                    Console.WriteLine("======================================");
                    Console.ReadLine();
                }

            }
        }

        public class Kund
        {
            public string Namn { get; set; }
            public int Ålder { get; set; }
            public bool Körkort { get; set; }
        }
    }
}
