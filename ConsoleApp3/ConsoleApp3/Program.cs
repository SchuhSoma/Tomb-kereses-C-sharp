using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int[] SzamTomb = new int[13];
        static void Main(string[] args)
        {
            Feladat1TombFeltoltes(); Console.WriteLine("\n---------------------------------\n");
            Feladat2Kiiratas(); Console.WriteLine("\n---------------------------------\n");
            Feladat3OsszegzesiTetel(); Console.WriteLine("\n---------------------------------\n");
            Feladat4MinimumTetel(); Console.WriteLine("\n---------------------------------\n");
            Feladat5MaximumTetel(); Console.WriteLine("\n---------------------------------\n");
            Feladat6KeresesiTelel(); Console.WriteLine("\n---------------------------------\n");
            Console.ReadKey();
        }

        private static void Feladat6KeresesiTelel()
        {
            Console.WriteLine("Feladat 6: Keresési tétel");
            int Szamlalo = 0;
            int KeresettSzam=0;
            
            do
            {
                Console.Write("Kérem adjon meg egy számot amit keresni szeretne a tömbben: ");
                
            }
            while ( !int.TryParse(Console.ReadLine(), out KeresettSzam));
           // Console.Write("Kérem adjon meg egy számot amit keresni szeretne a tömbben: ");
            
            while(Szamlalo<SzamTomb.Length && KeresettSzam!=SzamTomb[Szamlalo])
            {
                Szamlalo++;               
            }
            if (Szamlalo == SzamTomb.Length)
            {
                Console.WriteLine("Nincs ilyen elem a tömbben");
            }
            else
            {
                Console.WriteLine("Van ilyen elem a tömbben, mégpedig : {0}", Szamlalo + 1);
            }
        }

        private static void Feladat5MaximumTetel()
        {
            Console.WriteLine("Feladat 5: Maximum keresés a tömbben");
            int MaximumErtek = int.MinValue;
            int MaximumHely = 0;
           // Console.WriteLine("Az int legkisebb értéke: {0}", MaximumErtek);
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(MaximumErtek<SzamTomb[i])
                {
                    MaximumErtek = SzamTomb[i];
                    MaximumHely = i + 1;
                }
            }
            Console.WriteLine("A tömb legnagyobb értéke: {0}", MaximumErtek);
            Console.WriteLine("A legnagyobb értéket ezen a helyen veszi fel: {0}", MaximumHely);
        }

        private static void Feladat4MinimumTetel()
        {
            Console.WriteLine("Feladat 4: Minimum keresés a tömbben");
            int MinimumErtek = int.MaxValue;
            int MinimumHely = 0;
            //Console.WriteLine("A legnagyobb érték az intben: {0}", MinimumErtek);
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(SzamTomb[i]<MinimumErtek)
                {
                    MinimumErtek = SzamTomb[i];
                    MinimumHely = i + 1;
                }
            }
            Console.WriteLine("A tömböm legkisebb értéke: {0}",MinimumErtek);
            Console.WriteLine("A legkisebb érték a tömbben ezen a helyen van: {0}", MinimumHely);
        }

        private static void Feladat3OsszegzesiTetel()
        {
            Console.WriteLine("Feladat 3: Összegzési tétel, Átlagolási tétel");
            int Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                Osszeg += SzamTomb[i];
            }
            Atlag =(double) Osszeg / SzamTomb.Length;
            Console.WriteLine("A tömb elemeinek összege: {0}", Osszeg);
            Console.WriteLine("A tömb elemeinek átlaga: {0:0.00}",Atlag);
        }

        private static void Feladat2Kiiratas()
        {
            Console.WriteLine("Feladat 2: tömb eleminek kiiratása");
            Console.WriteLine("A tömb negyedik eleme : {0}", SzamTomb[3]);
            Console.WriteLine("A tömb 12-edik eleme: {0}",SzamTomb[11]);
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                Console.WriteLine("{0:00}. eleme a tömbnek: {1}", i+1,SzamTomb[i]);
            }
        }

        private static void Feladat1TombFeltoltes()
        {
            Console.WriteLine("Feladat 1: Tömb feltöltéa manuálisan");
            SzamTomb = new int[13] {15,26,32,43,-125,-58,72,19,23,42,136,634,187};
        }
    }
}
