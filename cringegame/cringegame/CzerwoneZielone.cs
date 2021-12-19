using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace cringegame
{
    class CzerwoneZielone
    {
        public static object Rozgrywka(ref Player player)
        {
            Console.Clear();
            Funkcje.Kolorek(ConsoleColor.Magenta, "Witaj w pierwszej grze \n Po pojawieniu się zielonego kwadratu musisz jak najszybciej nacisnąć dowolny przycisk bedzie 5 rund" +
                "\n wcisnij dowolny klaiwsz by zacząć gre");
            char a = Console.ReadKey().KeyChar;
            int wynik = 0;
            for (int i = 1; i <=5; i++)
            {
                Console.Clear();
                Funkcje.Kolorek(ConsoleColor.Blue, $"runda {i} / 5");
                int rodzaj = Kwadrat();
                wynik += timerCzerwoneZielone(rodzaj);

            }
            Console.WriteLine($"twoj wynik to {wynik}");
            if(wynik < 1 + player.trudnosc)
            {
                Funkcje.Kolorek(ConsoleColor.Red, "Niestety popełniłeś błąd zbyt duzą liczbe razy");
                player.hp -= 25;
            }
            return player;
        }


        public static int Kwadrat()
        {
            int wybor = Funkcje.losujzprzedzialu(0, 1);
            ConsoleColor[] consoleColors = { ConsoleColor.Red, ConsoleColor.Green };
            Funkcje.Kolorek(consoleColors[wybor], 
@" ____________________________________
/_____/_____/_____/_____/_____/_____/
 ._.                           ._.   
 | |                           | |   
 |_|                           |_|   
 |-|                           |-|   
 | |  /\   /\  /\  /\  /\  /\  | |   
 |_|  \/   \/  \/  \/  \/  \/  |_|   
 ._.                           ._.   
 | |                           | |   
 |_|                           |_|   
 |-|                           |-|   
 | |  ________________________ | |   
 |_| /_____/_____/_____/_____/ |_|");
            return wybor;

        }
        public static int timerCzerwoneZielone(int rodzaj)
        {
            DateTime beginWait = DateTime.Now;
            while (!Console.KeyAvailable && DateTime.Now.Subtract(beginWait).TotalMilliseconds < 800)
                Thread.Sleep(250);

            if (!Console.KeyAvailable)
            {
                if(rodzaj == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
               
            else
            {
                char a = Console.ReadKey().KeyChar;
                if (rodzaj == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}
