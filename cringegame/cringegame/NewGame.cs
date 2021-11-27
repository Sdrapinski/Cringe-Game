using System;
using System.Collections.Generic;
using System.Text;

namespace cringegame
{
    class NewGame
    {
        public static void Nowagra() {
            Console.Clear();
            Funkcje.Kolorek(ConsoleColor.Magenta,"Witaj w nowej grze \npodaj imie swojej postaci");
            string imie = Console.ReadLine();
            int poziom = PoziomTrudnosci();
            Player osoba = new Player(imie,poziom);
            Console.Clear();
            Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wiaj: # twój numer to: #", osoba.imie, osoba.numer);
        }

        public static int PoziomTrudnosci()
        {
           int wybor= Funkcje.ParseToInt("Wybierz poziom trudnosci \n1-latwy 4 życia \n2- normlany 2 życia \n3-realistyczny 1 żyicie", 1, 3);
            Console.WriteLine(wybor);
            switch (wybor)
            {
                case 1:
                    return 100;
                case 2:
                    return 50;
                case 3:
                    return 25;
                default:
                    return 50;
            }
        }


       
    }
}
