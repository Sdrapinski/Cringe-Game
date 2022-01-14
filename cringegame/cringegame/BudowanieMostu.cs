using System;
using System.Text;
using System.Diagnostics;

namespace cringegame
{
    class BudowanieMostu
    {
        public static object Most(ref Player player)
        {
            int licznik_poz = 0;
            int licznik_neg = 0;
            Console.Clear();
            Console.WriteLine("Witaj w kolejnym etapie o nazwie: 'Budowanie Mostu'. \n Twoje zadanie polega na tym by zbudować most. \n Jeśli Ci się to uda, przejdziesz do kolejnego etapu zbudowawszy swój most :D \n Musisz ułożyć 10 razy dobrze ale możesz pomylić się także 10 razy");
            Console.WriteLine("");
            while (true)
            {
                int wybor = Funkcje.ParseToInt("Układaj starannie: \n 1 - CEGŁA \n 2 - BARIERKA ", 1, 2);

                int Losowanie = Funkcje.losujzprzedzialu(0, 1);
                
                int cegla = 1;
                int barierka = 2;

                if (cegla == 1)
                {
                    if (Losowanie == 1)
                    {
                        ConsoleColor[] kolory = { ConsoleColor.Green, ConsoleColor.DarkGreen };

                        Funkcje.Kolorek(kolory[Losowanie],
                        @"
                        ██ -||- ██               
                        ");

                        licznik_poz++;
                        Funkcje.Kolorek(ConsoleColor.Green, $"Licznik dobrze ułożonych elementów: {licznik_poz}");
                        Console.Write(Losowanie);
                    }
                    else if (Losowanie == 0)
                    {
                        licznik_neg++;
                        Funkcje.Kolorek(ConsoleColor.Magenta,$"Licznik źle ułożonych elementów: {licznik_neg}");
                    }
                }

                else if (barierka == 2)
                {
                    if (Losowanie == 1)
                    {
                        ConsoleColor[] kolory = { ConsoleColor.Green, ConsoleColor.DarkGreen };

                        Funkcje.Kolorek(kolory[Losowanie],
                        @"
                        ██ -||- ██
                        ");

                        licznik_poz++;
                        Funkcje.Kolorek(ConsoleColor.Green, $"Licznik dobrze ułożonych elementów: {licznik_poz}");
                        Console.Write(Losowanie);
                    }
                    else if (Losowanie == 0)
                    {
                        licznik_neg++;
                        Funkcje.Kolorek(ConsoleColor.Magenta, $"Licznik źle ułożonych elementów: {licznik_neg}");
                    }
                }
                if (licznik_poz == 10)
                {
                    Console.Clear(); Funkcje.Kolorek(ConsoleColor.Green,"Gratulacje, przechodzisz dalej! 10/10 prób udanych! :) \n Udało Ci się zbudować most!");
                    Console.Write(@"
                        ██ -||- ██
                        ██ -||- ██                       
                        ██ -||- ██
                        ██ -||- ██                                  
                        ██ -||- ██
                        ██ -||- ██       
                        ██ -||- ██
                        ██ -||- ██
                        ██ -||- ██
                        ██ -||- ██
                        ");
                    return player;
                }
                else if (licznik_neg == 10)
                    {
                    Console.Clear(); Funkcje.Kolorek(ConsoleColor.Red, "Poniosłeś PORAŻKĘ! Widocznie nie wszystkie elementy były dobrze ułożone! \n MOŻE SIĘ UDA NASTĘPNYM RAZEM :D");
                    Console.Write(@"
                       $$$$$$$$$    $$$$$$      $$$   $$$
                       $$$        $$$    $$$    $$$   $$$
                       $$$$$$    $$$      $$$   $$$   $$$
                       $$$      $$$$$$$$$$$$$   $$$   $$$
                       $$$      $$$       $$$   $$$   $$$
                       $$$      $$$       $$$   $$$   $$$$$$$$$$      
                    ");
                    player.hp -= 25;
                    return player;
                    }
            } 
        }
       
    }
}
