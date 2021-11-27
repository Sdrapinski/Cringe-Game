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
        public Player(string imie,float hp)
        {
            this.imie = imie;
            this.hp = hp;
            
        }
        public string imie;
        public float hp;
       
        
       
    }
}
