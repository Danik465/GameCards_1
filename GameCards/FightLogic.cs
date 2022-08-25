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
            PoolPerson.PrintDict(Deckhero); // Вывод колоды героя

            Console.WriteLine("Карты врага:");
            PoolPerson.PrintDict(Deckenemy);// Вывод колоды врага


            while (Deckhero.Count > 0 && Deckenemy.Count > 0) // Цикл (количество элементов в колоде героя и врага должны быть больше 0)
            {
                Console.WriteLine();
                
                Console.WriteLine();
                PoolPerson.PrintDict(Deckhero); // Вывод колоды героя

                Console.WriteLine("Карты врага:");
                PoolPerson.PrintDict(Deckenemy);// Вывод колоды вра

                Console.WriteLine("Какую карточку хотите выбрать?");
                int number = Convert.ToInt32(Console.ReadLine()); // Определение номера карточки для боя героя
                int number1 = Convert.ToInt32(Console.ReadLine());// Определение номера карточки для боя врага

                Person FightCardHero = Deckhero[number];

                Console.WriteLine($" {FightCardHero.Name} - {FightCardHero}");

                var FightCardEnemy = Deckenemy[number1];

                Console.WriteLine($" {FightCardEnemy.Name} - {FightCardEnemy}");

                if (FightCardHero.HP > 0 && FightCardEnemy.HP > 0) //Если (хп героя и врага больше нуля)
                {
                    Person.GivenDamege(ref FightCardHero, ref FightCardEnemy); // Домажим карточки
                    if (FightCardHero.HP <= 0)// Проверяем если (хп героя больше либо равно 0)
                        {
                            Deckhero.Remove(number); // Удаляем карточку из колоды
                        Console.WriteLine();
                        Console.WriteLine("ваша карточка уничтожена:");
                        Console.WriteLine($" {FightCardHero.Name} - {FightCardHero}");
                        Console.WriteLine(Deckhero.Count);
                        Console.WriteLine();
                        }
                    else if (FightCardEnemy.HP <= 0) //Проверяем если(хп врага больше либо равно 0)
                        {
                            Deckenemy.Remove(number1); // Удаляем карточку из колоды
                        Console.WriteLine();
                        Console.WriteLine("карточка врага уничтожена:");
                        Console.WriteLine($" {FightCardEnemy.Name} - {FightCardEnemy}");
                        Console.WriteLine(Deckhero.Count);
                        Console.WriteLine();
                    }
                }
                
                
                

            }

            if (Deckhero.Count == 0)
            {
                Console.WriteLine("Вы проиграли");
                PoolPerson.PrintDict(Deckhero);
            }
            if (Deckenemy.Count == 0)
            {
                Console.WriteLine("Вы победили");
                PoolPerson.PrintDict(Deckenemy);
            }

            Console.WriteLine();
            
        }
    }
}
