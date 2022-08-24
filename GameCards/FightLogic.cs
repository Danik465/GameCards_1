using System;
using System.Collections.Generic;

namespace GameCards
{
    public class FightLogic
    {

        public static void GameLogic(Dictionary<int, Person> Deckhero, Dictionary<int, Person> Deckenemy)
        {
            Console.Clear();
            Console.WriteLine("Ваши карты:");
            PoolPerson.PrintDict(Deckhero);

            Console.WriteLine("карты врага:");
            PoolPerson.PrintDict(Deckenemy);


            while (Deckhero.Count > 0 && Deckenemy.Count > 0)
            {
                Console.WriteLine();
                

                
                Console.WriteLine();

                Console.WriteLine("Какую карточку хотите выбрать?");
                int number = Convert.ToInt32(Console.ReadLine());
                int number1 = Convert.ToInt32(Console.ReadLine());
                Person FightCardHero = Deckhero[number];

                Console.WriteLine($" {FightCardHero.Name} - {FightCardHero}");

                var FightCardEnemy = Deckenemy[number1];

                Console.WriteLine($" {FightCardEnemy.Name} - {FightCardEnemy}");

                if (FightCardHero.HP > 0 && FightCardEnemy.HP > 0)
                {
                    Person.GivenDamege(ref FightCardHero, ref FightCardEnemy);
                    if (FightCardHero.HP <= 0)
                        {
                            Deckhero.Remove(number);
                            Console.WriteLine(Deckhero.Count);
                        }
                    else if (FightCardEnemy.HP <= 0)
                        {
                            Deckenemy.Remove(number1);
                        Console.WriteLine(Deckenemy.Count);
                    }
                }
                
                
                

            }

            if (Deckhero.Count == 0)
            {
                Console.WriteLine("Вы проиграли"); 
            }
            if (Deckenemy.Count == 0)
            {
                Console.WriteLine("Вы победили");
            }

            Console.WriteLine();
            
        }
    }
}
