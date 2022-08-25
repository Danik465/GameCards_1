using System;
using System.Collections.Generic;



namespace GameCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var PoolCards = PoolPerson.Input(); // Определяем словарь всех карт
            PoolPerson.PrintDict(PoolCards);// Выводим его на экран


            var DeckHero = PoolPerson.DeckHero(PoolCards); // Создаем колоду героя
            Console.Clear();
            

            var DeckEnemy = PoolPerson.DeckEnemy(PoolCards); // Создаем колоду врага


            FightLogic.GameLogic(DeckHero, DeckEnemy); // Метод игры(не готовый) 
            






        }   
    }
}
