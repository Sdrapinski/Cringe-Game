using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace cringegame
{
    class Wczytaj
    {
        public static Player Wczytywanie()
        {
            string path = "wczytaj.txt";
            StreamWriter streamWriter;
            if (!File.Exists(path))
            {
                streamWriter = File.CreateText(path);
                Console.WriteLine("Nie masz zanych zapisanych przejsc. Inicjalizuje nową grę");
                streamWriter.Close();
                return NewGame.Nowagra();
              
            }
            else
             {
                StreamReader sr = File.OpenText(path);
                Console.WriteLine("Plik został otwarty");
                string s = "";
                int i = 0;
                ArrayList Lista = new ArrayList();
                Console.Clear();
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(i + "." + s);
                    // numer imie hp trudnosc gra
                    Lista.Add(s);
                    i++;
                }
                sr.Close();
                int wybor =  Funkcje.ParseToInt("Wybierz zapisz", 0, i - 1);
                string wybrany_zapis = Lista[wybor].ToString();
                string[] props = wybrany_zapis.Split(' ');
                int numer = int.Parse(props[0]);
                string imie = props[1];
                float hp = float.Parse(props[2]);
                int trudnosc = int.Parse(props[3]);
                int numer_gry = int.Parse(props[4]);
                Console.WriteLine(imie + " " + hp + " " + trudnosc + " " + numer_gry);
                Thread.Sleep(4000);
                return new Player(imie, hp, trudnosc, numer_gry);
                

            }
            
        }

        public static void Zapisz(Player player,int numer)
        {
            string path = "wczytaj.txt";
            StreamWriter streamWriter;
            if (!File.Exists(path))
            {
                streamWriter = File.CreateText(path);
            }
            else
            {
                streamWriter = new StreamWriter(path, true); 
                
            }
            string tekst = player.numer + " " + player.imie + " " + player.hp + " " + player.trudnosc + " " + numer;
            streamWriter.WriteLine(tekst);
            streamWriter.Close();

        }
    }
}
