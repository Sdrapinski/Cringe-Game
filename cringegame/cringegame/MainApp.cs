using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cringegame
{
    class Glowny 
    {
        static public int numer=1;
        static void Main(string[] args)
        {

            Gra();
            

        }
        public static void Gra()
        {
            wyswietlacz();
            Player player = wyboropcji();
            for (int i = numer; i <= 3; i++)
            {
                switch (i)
                {
                    case 1:
                        CzerwoneZielone.Rozgrywka(ref player);
                        
                        break;
                    case 2:
                        Przepisanie.precyzja(ref player);
                        break;
                    case 3:
                        BlackJack.Rozgrywka(ref player);
                        break;
                    default:
                        break;
                }
                info(player, i);
            }
           
           
            
            
            
        }

       public static void wyswietlacz()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine(@"
       _________        .__                          ________                       
       \_   ___ \_______|__| ____    ____   ____    /  _____/_____    _____   ____  
       /    \  \/\_  __ \  |/    \  / ___\_/ __ \  /   \  ___\__  \  /     \_/ __ \ 
       \     \____|  | \/  |   |  \/ /_/  >  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
        \______  /|__|  |__|___|  /\___  / \___  >  \______  (____  /__|_|  /\___  >
               \/               \//_____/      \/          \/     \/      \/     \/ 


");
            Console.WriteLine(@"
          _         _  _                    ___          
         / |  ___  | \| |_____ __ ____ _   / __|_ _ __ _ 
         | | |___| | .` / _ \ V  V / _` | | (_ | '_/ _` |
         |_|       |_|\_\___/\_/\_/\__,_|  \___|_| \__,_|
                                                 
");

            Console.WriteLine(@"
          ___        __      __          _         _ 
         |_  )  ___  \ \    / /_ ____  _| |_ __ _ (_)
          / /  |___|  \ \/\/ / _|_ / || |  _/ _` || |
         /___|         \_/\_/\__/__|\_, |\__\__,_|/ |
                                     |__/        |__/ 
");
            Console.WriteLine(@"
         ____       __      __     _    _    
        |__ /  ___  \ \    / /  _ (_)__| |___
         |_ \ |___|  \ \/\/ / || || / _` |_ /
        |___/         \_/\_/ \_, |/ \__,_/__|
                              |__/__/         
");
            Console.ResetColor();
        }
       public static Player wyboropcji()
        {
           int wybor= Funkcje.ParseToInt("Wybierz opcje", 1, 3);
            switch (wybor)
            {
                case 1:
                  return  NewGame.Nowagra();   
                case 2:
                    numer = 2;
                    return new Player("Wczytany", 50, 2);
                        //Wczytaj.Wczytywanie();
                case 3:
                    return new Player("Zakoncz", 0, 3);
                default:
                return NewGame.Nowagra();
                   
            }
        }
        public static void info(Player player,int nr)
        {
            Funkcje.KolorujKonkretne(ConsoleColor.Green, "Stan życia # numer gry #", player.hp, nr);
            Thread.Sleep(2000);
        }
    }
    
}
