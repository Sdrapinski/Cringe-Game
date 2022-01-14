using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace cringegame
{
    class KoniecGry
    {

        public static int wczytane; 

        public static void TimerUpokorzenia(int numer)
        {
            int i = 10;
            while (i > 0)
            {
            i--;

            Console.Clear();
            Console.WriteLine("================================================================");
            Console.WriteLine($"    Nie udało się, skończyły ci się życia numerze {numer}");
            Console.WriteLine("            więc wybuchniesz za 10 sekund :)");
            Console.WriteLine("                     Odliczanie:  " + i.ToString());
            Console.WriteLine("       Autorzy: Szymon Drapiński & Aleksander Chomicz");
            Console.WriteLine("================================================================");

            if (i == 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Funkcje.Kolorek(ConsoleColor.Red, "===================================================================");
                Funkcje.Kolorek(ConsoleColor.Red, "        Zapraszamy ponownie do grania w Cringe Game :D ! ! ! !");
                Console.WriteLine("");
                Funkcje.Kolorek(ConsoleColor.Red, "               G A M E  O V E R Kolego!");
                Funkcje.Kolorek(ConsoleColor.Red, "====================================================================");

            }
                Thread.Sleep(1000);
        }

            GC.Collect();
        }


        public static void TimerGratulacje(int numer,int trudnosc,long time)
        {
            long wynik = (time / 100) * trudnosc + wczytane;
           
            int i = 10;
            while (i > 0)
            {


                i--;

                Console.Clear();
                Console.WriteLine("====================================================================================");
                Console.WriteLine("          SERDECZNIE GRATULUJEMY PRZEJŚCIA CAŁEJ GRY W JEDNYM KAWAŁKU!");
                Console.WriteLine("");
                Console.WriteLine("                Odliczanie do szczęścia:  " + i.ToString());
                Console.WriteLine("              Autorzy: Szymon Drapiński & Aleksander Chomicz");
                Console.WriteLine("====================================================================================");

                if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Funkcje.Kolorek(ConsoleColor.Green, "===================================================================");
                    Funkcje.Kolorek(ConsoleColor.Green, $"     Zapraszamy ponownie numerze {numer} do grania w Cringe Game :D ! ! ! !");
                    Console.WriteLine("");
                    Funkcje.Kolorek(ConsoleColor.Green, "                     G R A T U L A C J E !!!!");
                    Funkcje.Kolorek(ConsoleColor.Green, $"                TWOJ WYNIK TO IM MNIEJSZY TYM LEPIEJ");
                    Funkcje.Kolorek(ConsoleColor.Magenta, $"                               {wynik}");
                    Funkcje.Kolorek(ConsoleColor.Green, " ==================================================================");

                }
                Thread.Sleep(1000);
            }

            GC.Collect();
        }

    }
}
