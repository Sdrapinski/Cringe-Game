using System;
using System.Collections.Generic;
using System.Text;

namespace cringegame
{
    class BlackJack
    {
        public static object Rozgrywka(ref Player player)
        {
            int wynik = 0;

            int wynik_komputer = Funkcje.losujzprzedzialu(17, 25 - player.trudnosc);
            Console.Clear();
            bool czyDalej = true;
            Funkcje.Kolorek(ConsoleColor.Magenta, "Witaj w kolejnej grze tym razem to BlackJack zdobądz jak najblizej 21 ale nie przestrzeł  \nPo nacisnieciu klawisza rozpocznie sie gra");
            char play = Console.ReadKey().KeyChar;
            Console.Clear();
            while (czyDalej)
            {
                int wylosowana =  Funkcje.losujzprzedzialu(2, 11);
                if(wylosowana == 11)
                {
                    wynik += Funkcje.ParseToInt("Wylosowałeś ASA chcesz by był 1 czy 11 ? \n 1 - 1 \n 2 - 11", 1, 2);
                }else
                {
                    wynik += wylosowana;
                }
                if(wynik > 21)
                {
                    Funkcje.Kolorek(ConsoleColor.Red, $"Wylosowałeś {wylosowana} co oznacza ze  Przestrzeliłeś numerze {player.numer}. Przegrałeś HaHa");
                    player.hp -= 25;
                    return player;
                }
                else
                {
                    Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wylosowałeś # twoj aktualny wynik to: # ", wylosowana, wynik);
                    Console.WriteLine();
                    czyDalej= Funkcje.TakCzyNie("Czy chcesz dobrać kolejną kartę T/N");
                    Console.Clear();
                }
            }
            if(wynik_komputer > 21)
            {
                Funkcje.Kolorek(ConsoleColor.Green, $"Brawo Gracz {Funkcje.losujzprzedzialu(1,457)} przestrzelił wygrałeś przechodzisz dalej :D");
                return player;
            }
            else
            {
                if(wynik > wynik_komputer)
                {
                    Funkcje.Kolorek(ConsoleColor.Green, $"Brawo zdobyłeś {wynik} punktów a przeciwnik zdobył {wynik_komputer} wygrałeś przechodzisz dalej :D");
                    return player;
                }
                else
                {
                    Funkcje.Kolorek(ConsoleColor.Red, $"Buuuu zdobyłeś {wynik} punktów a przeciwnik zdobył {wynik_komputer} Przegrałeś");
                    player.hp -= 25;
                    return player;
                }
            }

        }

    }
}
