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
            Fabula();
            Funkcje.Kolorek(ConsoleColor.Magenta,"Witaj w nowej grze \npodaj imie swojej postaci");
            string imie = Console.ReadLine();
            int[] poziom = new int[2];
            poziom = PoziomTrudnosci();
            Player osoba = new Player(imie,poziom[0],poziom[1],1);
            Console.Clear();
            if(osoba.imie.Length > 0)
            {
                Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wiaj: # twój numer to: # Zaraz zacznie sie gra", osoba.imie, osoba.numer);
            }
            else
            {
                osoba.imie = "Bezimienny";
                Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wiaj: # twój numer to: # Zaraz zacznie sie gra", osoba.imie, osoba.numer);
              
            }
          
            Thread.Sleep(2000);
            return osoba;
          
        }

        public static int[] PoziomTrudnosci()
        {
           int wybor= Funkcje.ParseToInt("Wybierz poziom trudnosci \n1-latwy 4 życia \n2- normlany 2 życia \n3-ekspert 1 żyicie", 1, 3);
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

        public static void Fabula()
        {
            Funkcje.Kolorek(ConsoleColor.Blue, @"
Jesteś jednym z 465 graczy, którzy wzieli udział w Bardzo oryginalnej grze o tajemniczej nazwie 'CRINGE GAME' 
Przed tobą 6 trudnych zadań postaraj się zdobyć jak najwięcej punktów.
Musisz być pomysłowy i przebiegły jeżeli chcesz wykręcić jak najwyższy wynik, Niech moc będzie z tobą :D
            ");
        }
       
    }
}
