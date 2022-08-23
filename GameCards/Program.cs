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
            Console.WriteLine("Ваши карты:");
            PoolPerson.PrintDict(DeckHero);

            var DeckEnemy = PoolPerson.DeckEnemy(PoolCards);
            PoolPerson.PrintDict(DeckEnemy);


            Console.WriteLine("Какую карточку хотите выбрать?");

            int number = Convert.ToInt32(Console.ReadLine());
            Person FightCardHero = DeckHero[number];

            Console.WriteLine($" {FightCardHero.Name} - {FightCardHero}");

            var CardEnemy = PoolPerson.CardEnemy(DeckEnemy);

            Console.WriteLine($" {CardEnemy.Name} - {CardEnemy}");





            //FightLogic.GameLogic( goodboy, BadBoy, DeckHero, DeckEnemy);
            //   Console.WriteLine(goodboy);
            //   Console.WriteLine(BadBoy);
        }
    }
}
