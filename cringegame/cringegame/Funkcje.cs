using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace cringegame
{
    class Funkcje
    {
        public static Random rnd = new Random();
        

        public static void KolorujKonkretne(ConsoleColor color, string text, params object[] args)
        {
            /* podajesz w stringu # w miejsce czegos co chcesz zakolorowac a w params to zakolorwane ma zostac
             np Funkcje.KolorujKonkretne(ConsoleColor.Green, "Wiaj: # twój numer to: #", osoba.imie, osoba.numer) */
            for (int i = 0, a = 0; i < text.Length; i++)
            {
                if (text[i] == '#')
                {
                    Console.ForegroundColor = color;
                    Console.Write(args[a].ToString());
                    Console.ResetColor();
                    a++;
                }
                else
                {
                    Console.Write(text[i]);
                }

            }
        }

        public static void Kolorek(ConsoleColor color, string message)
        {
            // funkcja do wyswietlenia kolorowego textu
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();

        }
        public static int ParseToInt(string komunikat, int min = 0, int max = 999)
        {
            // pobiera komunikat do wyswietlenia i opcjonalnie min oraz max 
            Console.WriteLine(komunikat);
            bool czyok = false, czyliczba = false;
            int wynik = 0;
            while (!czyok)
            {
                czyliczba = int.TryParse(Console.ReadLine(), out wynik);
                if (czyliczba && ((wynik >= min && wynik <= max) || (min == 0 && max == 999)))
                {

                    return wynik;
                }
                else
                {
                    Kolorek(ConsoleColor.Red, "Prosze wprowadzic POPRAWNĄ liczbe ponownie!");
                    continue;
                }
            }
            return wynik;

        }
        public static bool Timer(int sekund)
        {
            // funkcja do skopiowania i przerobienia pod swoją potrzebe
            int sec = DateTime.Now.Second;
            while (DateTime.Now.Second - sekund - sec <= 0)
            {
                // rob cos
                Console.WriteLine(DateTime.Now.Second - sekund - sec);
                Console.ReadKey();
            }
            return false;
        }
        public static long CzasReakcji()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("kliknij");
            Console.ReadKey();
            stopwatch.Stop();
            long wynik = stopwatch.ElapsedMilliseconds;

            return wynik;
        }

        public static int losujzprzedzialu(int min,int max)
        {
             int numer = rnd.Next(min, max + 1);
            return numer;
         }

        public static bool TakCzyNie(string powiadomienie)
        {
           
            bool czyokej = false;
            char wybor='0';
            Kolorek(ConsoleColor.Blue, powiadomienie);
            while (!czyokej)
            {
                wybor = Console.ReadKey().KeyChar;
                if(wybor =='T' || wybor =='t' || wybor =='N' || wybor == 'n')
                {
                    czyokej = true;
                }
                else
                {
                    Kolorek(ConsoleColor.Red, powiadomienie);
                }
            }
            if(wybor=='T' || wybor == 't')
            {
                return true;
            }
            else
            {
                return false;
            }
          
            
        }
       
    }
     
    }


