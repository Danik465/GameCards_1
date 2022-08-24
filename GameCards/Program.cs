using System;
using System.Collections.Generic;



namespace GameCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var PoolCards = PoolPerson.Input();
            PoolPerson.PrintDict(PoolCards);


            var DeckHero = PoolPerson.DeckHero(PoolCards);
            Console.Clear();
            

            var DeckEnemy = PoolPerson.DeckEnemy(PoolCards);


            FightLogic.GameLogic(DeckHero, DeckEnemy);
            






        }   
    }
}
