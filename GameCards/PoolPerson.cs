using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCards
{
    public class PoolPerson
    {

        public static Dictionary<int, Person> Input()
        {
            Person Gargoyle = new Person(80, 5, "Gargoyle", 1);
            var Ghoul = new Person(100, 10, "Ghoul", 2);
            var Zombi = new Person(120, 4, "Zombi", 3);
            var Banshee = new Person(32, 1, "Banshee", 4);
            var Ghost = new Person(45, 6, "Ghost", 5);
            var Skeleton = new Person(265, 23, "Skeleton", 6);
            var Spirit = new Person(321, 42, "Spirit", 7);
            var Slug = new Person(421, 32, "Slug", 8);
            var Demon = new Person(21, 32, "Demon", 9);
            var Mermaid = new Person(123, 321, "Mermaid", 10);

            var MassPerson = new Dictionary<int, Person>();
            MassPerson[1] = Gargoyle;
            MassPerson[2] = Ghoul;
            MassPerson[3] = Zombi;
            MassPerson[4] = Banshee;
            MassPerson[5] = Ghost;
            MassPerson[6] = Skeleton;
            MassPerson[7] = Spirit;
            MassPerson[8] = Slug;
            MassPerson[9] = Demon;
            MassPerson[10] = Mermaid;
            return MassPerson;
        }

        public static Dictionary<int, Person> DeckEnemy(Dictionary<int, Person> PoolCards)
        {
            Random randCard = new Random();
            var DeckEnemy = new Dictionary<int, Person>();
            Console.WriteLine("Враг выбрал такие карточки:");
            for (int i = 1; i <=4; i++)
            {

                DeckEnemy[i] = PoolCards[randCard.Next(1, 11)];
            }
            return DeckEnemy;

        }
        public static Dictionary<int, Person> DeckHero(Dictionary<int, Person> PoolCards)
        {
            var DeckHero = new Dictionary<int, Person>();
            Console.WriteLine("Введите номера карты , которые хотите добавить");
            for (int i = 1; i <= 4; i++)
            {

                DeckHero[i] = PoolCards[Convert.ToInt32(Console.ReadLine())];
            }
            return DeckHero;
        }
        public static void PrintDict(Dictionary<int, Person> cards)
        {
            int number = 1;
            for (int i = 1; i < cards.Count + 1; i++)
            {
                Console.WriteLine($"{number}. {cards[i].Name} - {cards[i]}");
                number++;
            }
            Console.WriteLine();
        }
        public static Person CardEnemy(Dictionary<int, Person> cards)
        {
            Random randCard = new Random();
            var CardEnemy = new Person(0, 0, " ", 0);
            Console.WriteLine();
            Console.WriteLine("Карточка врага:");
            for (int i = 1; i < cards.Count + 1; i++)
            {
                CardEnemy = cards[randCard.Next(1, 5)];
            }
            return CardEnemy;
        }
    }
}

