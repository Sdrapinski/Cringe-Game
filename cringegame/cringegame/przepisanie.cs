using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace cringegame
{
    class Przepisanie
    {

        public static object precyzja(ref Player player)
        {
            Console.Clear();
            Funkcje.Kolorek(ConsoleColor.Magenta,
                "Witaj kolejnej grze tym razem przetestujemy twoją precyzję i szybkosc \n w jak najkrótszym czasie musisz bezbłędnie przepisać podany ciąg liter");
            Funkcje.Kolorek(ConsoleColor.Green, "Kliknij byle jaki klawisz jezeli jestes gotowy");
          char smietnik =   Console.ReadKey().KeyChar;
            string ciag = ciagznakow(player.trudnosc);
           if(!zadanie(ciag))
            {
                player.hp -= 25;
            }
            return player;
        
        }

        public static string ciagznakow(int trudnosc)
        {
            string ciag = "";
            char a, b;
            for (int i = 0; i < 10*trudnosc; i++)
            {
                a = (char)Funkcje.losujzprzedzialu(97, 122);
                if (trudnosc==3)
                {
                    b = (char)Funkcje.losujzprzedzialu(65, 90);
                }
                else
                {
                    b = (char)Funkcje.losujzprzedzialu(97, 122);
                }
                
                ciag += a;
                ciag += b;
            }
            return ciag;
        }

        public static bool zadanie(string ciag)
        {
            Console.Clear();
            Funkcje.Kolorek(ConsoleColor.Blue, ciag);
            Stopwatch stoper = new Stopwatch();
            stoper.Start();
           string ciag2 =  Console.ReadLine();
            stoper.Stop();
            long wynik = stoper.ElapsedMilliseconds / 1000;
            if(String.Equals(ciag , ciag2) && wynik <= 2.5 *ciag.Length )
            {
                Funkcje.Kolorek(ConsoleColor.Green, "Brawo Udało ci się");
                Console.WriteLine(wynik + " sekund");
                return true;
            }
            else
            {
                if(String.Equals(ciag, ciag2))
                {
                    Funkcje.Kolorek(ConsoleColor.Red, "Za wolno");
                }
                else
                {
                    Funkcje.Kolorek(ConsoleColor.Red, "Zrobiles błąd w przepisywaniu");
                }
               
                return false;
            }
        }
    }
}
