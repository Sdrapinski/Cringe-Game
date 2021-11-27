using System;
using System.Collections.Generic;
using System.Text;

namespace cringegame
{
    class NewGame
    {
        public static void Nowagra() {
            Console.WriteLine("Witaj w nowej grze \npodaj imie swojej postaci");
            string imie = Console.ReadLine();
            Player osoba = new Player(imie,100);
            Console.Clear();
            Console.WriteLine($"Wiaj: # twój numer to: {osoba.numer}");
            Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wiaj: # twój numer to: #", osoba.imie, osoba.numer);
        }


       
    }
}
