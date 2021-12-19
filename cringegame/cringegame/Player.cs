using System;
using System.Collections.Generic;
using System.Text;

namespace cringegame
{
    
    class Person
    {
        public static Random rnd = new Random();
        public int numer = rnd.Next(1, 457);
    }



    class Player : Person
    {
        public Player() { }
        public Player(string imie,float hp,int trudnosc)
        {
            this.imie = imie;
            this.hp = hp;
            this.trudnosc = trudnosc;
            
        }
        public int trudnosc;
        public string imie;
        public float hp;
       
        
       
    }
}
