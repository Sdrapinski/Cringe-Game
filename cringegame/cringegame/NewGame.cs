using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace cringegame
{
    class NewGame
    {
        public static Player Nowagra() {
            Console.Clear();
            Funkcje.Kolorek(ConsoleColor.Magenta,"Witaj w nowej grze \npodaj imie swojej postaci");
            string imie = Console.ReadLine();
            int[] poziom = new int[2];
            poziom = PoziomTrudnosci();
            Player osoba = new Player(imie,poziom[0],poziom[1]);
            Console.Clear();
            Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wiaj: # twój numer to: # Zaraz zacznie sie gra", osoba.imie, osoba.numer);
            Thread.Sleep(2000);
            return osoba;
          
        }

        public static int[] PoziomTrudnosci()
        {
           int wybor= Funkcje.ParseToInt("Wybierz poziom trudnosci \n1-latwy 4 życia \n2- normlany 2 życia \n3-realistyczny 1 żyicie", 1, 3);
            Console.WriteLine(wybor);
            int[] wynik = new int[2];
            switch (wybor)
            {
                case 1:
                    wynik[0] = 100;
                    wynik[1] = 1;
                    return wynik;
                case 2:
                    wynik[0] = 50;
                    wynik[1] = 2;
                    return wynik;
                case 3:
                    wynik[0] = 25;
                    wynik[1] = 3;
                    return wynik;
                default:
                    wynik[0] = 50;
                    wynik[1] = 2;
                    return wynik;
            }
        }


       
    }
}
