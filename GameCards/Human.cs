using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCards
{
    public abstract class Human
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public string Name { get; set; }

        public int Index { get; set; }
        public Human(int hp, int attack, string name, int index)
        {

            HP = hp;
            Attack = attack;
            Name = name;
            Index = index;
        }





        public override string ToString()
        {
            return $"(HP: {HP}, Attack: {Attack})";
        }



    }
}

