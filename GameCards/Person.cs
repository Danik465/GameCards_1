using System;


namespace GameCards
{
    public class Person : Human
    {
        public Person(int hp, int attack, string name, int index) : base(hp, attack, name, index) // Наследуемый конструктор класса 
        {

        }
        public static void GivenDamege(ref Person person1, ref Person person2) // Метод получения урона
        {
            person2.HP = person2.HP - person1.Attack;
            if(person2.HP >= 0)person1.HP = person1.HP - person2.Attack;

        }

        public static void GameLogic(ref Person person1, ref Person person2)  // Пока что не нужный метод
        {
            while (true)
            {
                Person.GivenDamege(ref person1, ref person2);
                Console.WriteLine($"Первый получил {person2.Attack}, его здоровье - {person1.HP}");
                Console.WriteLine($"Второй получил {person1.Attack}, его здоровье - {person2.HP}");
                Console.WriteLine();
                if (person2.HP <= 0)  // Дописать это действие после смерти ГГ
                {
                    Console.WriteLine("Ты победил");
                    break;
                }
                else if (person1.HP <= 0)
                {
                    Console.WriteLine("Ты проиграл");
                    break;
                }
            }

        }
    }
}
