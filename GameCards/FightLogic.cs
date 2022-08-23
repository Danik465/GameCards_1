using System;
using System.Collections.Generic;

namespace GameCards
{
    public class FightLogic
    {

        public static void GameLogic(Dictionary<int, Person> DeckHero, Dictionary<int, Person> DeckEnemy)
        {
            Random rand = new Random();






            /*
            while (hero.HP > 0 && enemy.HP > 0)
            {
               // hero.Attack = 0;
               // enemy.Attack = 0;
                bool firstAttackHero = false;
                bool firstAttackEnemy = false;
                bool attack = true;
              
                List<int> CardsInHandHero = new List<int>();
                List<int> CardsInHandEnemy = new List<int>();

                while (hero.Attack - enemy.Attack < Math.Abs(5))
                {

                    if (attack == true)
                    {
                        if (firstAttackHero == true)
                        {
                            for (int i = 0; i < CardsInHandHero.Count; i++)
                            {
                                CardsInHandHero.Add(i);
                            }
                            for (int i = 0; i < CardsInHandHero.Count; i++)
                            {
                                DeckHero.Remove(key: i);
                            }
                            firstAttackHero = false;
                        }
                        else
                        {
                            CardsInHandHero.Add(1);
                            DeckHero.Remove(key: 1);
                           
                        }
                        Person.GivenDamege(ref hero, ref enemy);
                    }
                    else
                    {
                        if (firstAttackEnemy == true)
                        {
                            for (int i = 0; i < CardsInHandEnemy.Count; i++)
                            {
                                CardsInHandEnemy.Add(i);
                            }
                            for (int i = 0; i < CardsInHandEnemy.Count; i++)
                            {
                                DeckEnemy.Remove(key: i);
                            }
                            firstAttackEnemy = false;
                        }
                        else
                        {
                            CardsInHandHero.Add(1);
                            DeckEnemy.Remove(key: 1);
                            
                        }
                        Person.GivenDamege(ref enemy, ref hero);
                    }
                    attack = !attack;


                }

                if (hero.Attack > enemy.Attack)
                {
                    enemy.HP--;
                    break;
                }
                else
                {
                    hero.HP--;
                    break;
                }
            }

            if (hero.HP <= 0)
            {
                Console.WriteLine("Ты сдох");
                
            }
            else
            {
                Console.WriteLine("Ты победил");
            }
           */
        }
    }
}
