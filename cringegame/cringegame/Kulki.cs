using System;

namespace cringegame
{
    class Kulki
    {
        public static Random rnd = new Random();
        public static object Gra( ref Player player)
        {
            Console.Clear();
            Console.WriteLine("=== Kulki - gra: Parzyste/Nieparzyste! ===");
            Console.WriteLine("");
            Console.WriteLine("Jeśli użytkownik odgadnie czy komputer myśli o liczbie parzystej lub nieparzystej, dostaje punkt! \n Jeśli zbierze 5 / 5 pkt, przchodzi do dalszego etapu");
            Console.WriteLine("Wybierz numer od 1-2 na klawiaturze, aby sprawdzić czy przeciwnik ma parzyste lub nieparzyste kulki: ");

            int wybierz;
            int gracz = 0;
            int komp = 0;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1 - NIEPARZYSTE");
                Console.WriteLine("2 - PARZYSTE");
                Console.WriteLine("");

                int kulka = rnd.Next(1, 8);
                Console.Write("Wybrany numer: ");
                wybierz = Funkcje.ParseToInt("", 1, 2);

                Console.WriteLine("");

                if (wybierz == 1)
                {
                    if (kulka == 1 || kulka == 3 || kulka == 5 || kulka == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (kulka % 2 != 0)
                        gracz++;
                        Console.Clear();
                        Console.WriteLine($"Odgadnięto NIEPARZYSTĄ liczbę kulek! \n Status: WYGRANA z komputerem! \n Gracz: {gracz} pkt, Komputer: {komp} pkt");
                        Console.WriteLine("");
                    }
                    else
                    {
                        if (kulka % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                        komp++;
                        Console.Clear();
                        Console.WriteLine($"Nie odgadnięto liczby kulek przeciwnika! \n Status: PRZEGRANA z komputerem! \n Gracz: {gracz} pkt, Komputer: {komp} pkt");
                        Console.WriteLine("");
                    }
                }
                else if (wybierz == 2)
                {
                    if (kulka == 2 || kulka == 4 || kulka == 6 || kulka == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (kulka % 2 == 0)
                        gracz++;
                        Console.Clear();
                        Console.WriteLine($"Odgadnięto PARZYSTĄ liczbę kulek! \n Status: WYGRANA z komputerem! \n Gracz: {gracz} pkt, Komputer: {komp} pkt");
                        Console.WriteLine("");
                    }
                    else
                    {
                        if (kulka % 2 != 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                        komp++;
                        Console.Clear();
                        Console.WriteLine($"Nie odgadnięto liczby kulek przeciwnika! \n Status: PRZEGRANA z komputerem! \n Gracz: {gracz} pkt, Komputer: {komp} pkt");
                        Console.WriteLine("");
                    }
                }
                if (gracz == 5)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Ostateczne starcie wygrał: Gracz! GRATULACJE przechodzisz dalej!");
                    Console.WriteLine("");
                    return player;
                    
                }
                else
                {
                    if (komp == 5)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Ostateczne starcie wygrał: Komputer! Poniosłeś PORAŻKĘ!");
                        Console.WriteLine("");
                        player.hp -= 25;
                        return player;
                    }
                }
            }
        }
    }
}
