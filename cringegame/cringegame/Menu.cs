using System;
using System.Collections.Generic;
using System.Text;

namespace cringegame
{
    class Menu
    {
        static void Main(string[] args)
        {

            Gra();
           
            
        }
        public static void Gra()
        {
            wyswietlacz();
            wyboropcji();
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
       public static void wyboropcji()
        {
           int wybor= Funkcje.ParseToInt("Wybierz opcje", 1, 3);
            switch (wybor)
            {
                case 1:
                    NewGame.Nowagra();
                    break;
                case 2:
                    Wczytaj.Wczytywanie();
                    break;
                case 3:
                    break;
                default:
                 NewGame.Nowagra();
                    break;
            }
        }
    }
    
}
