using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Timers;


namespace cringegame
{
     class Bomba
    {
        public static Random rnd = new Random();

        public static object GlownaGra( ref Player player)
        {
            Console.Clear();
            Console.WriteLine("Witaj w ostatniej już gierce! Miło, że dotrwałeś do tego momentu :D \n Przygotuj się na ostatnie wyzwanie! \n Zadanie 'Deaktywacja Bomby'!");
            Console.WriteLine("");
            Console.WriteLine("*** Powodzenia *** ");
            Console.WriteLine("Masz JEDNĄ szansę!!!!! Nie zmarnuj jej!");
            
           
          
            Console.WriteLine("Następujące kolory do wyboru: ");
            Console.WriteLine("1) Niebieski");
            Console.WriteLine("2) Żółty");
            Console.WriteLine("3) Czerwony");
            Console.WriteLine("4) Zielony");
            int wybor = Funkcje.ParseToInt("", 1, 4);

            switch (wybor)
            {
                case 1: Kolor("Niebieski",ref player); break;
                case 2: Kolor("Żółty",ref player); break;
                case 3: Kolor("Czerwony",ref player); break;
                case 4: Kolor("Zielony",ref player); break;
               default: break;
            }
            return player;
        }

        public static void Kolor(string color,ref Player player )
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Jeśli jesteś pewny to przepisz nazwę koloru '{color}' i wciśnij Enter na klawiaturze.");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.Write("Nazwa koloru: ");
              string kolor = Console.ReadLine();

                int szansa = rnd.Next(0, 100);

                if (szansa < 50)
                {
                    Funkcje.Kolorek(ConsoleColor.Red, "Zły kabel przeciąłeś! Porażka!");
                   
                    player.hp -= 25;
                   
                    break;
                }
                else if (kolor != color)
                {
                    Funkcje.Kolorek(ConsoleColor.Red, "Wprowadzono błędną nazwę!");
                  
                    player.hp -= 25;
                    break;
                    
                }
                else if (szansa >= 50)
                {
                    Funkcje.Kolorek(ConsoleColor.Green, "Prawidłowy kabel przeciąłeś! Correct! Dzisiaj nie wybuchniesz :D");
                   
                    break;
                }
            } 
        }
       
       

    }
}
