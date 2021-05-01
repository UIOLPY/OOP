using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2Fighters
{
    class Fighter
    {
        private int _healthPoint;
        private int _damage;
        private int _number;

        public int healthpoint
        {
            get
            {
                return _healthPoint;
            }
            set
            {
                _healthPoint = value;
            }
        }

        public int damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        public int number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        public Fighter(int healthPoint, int damage, int number)
        {
            _healthPoint = healthPoint;
            _damage = damage;
            _number = number;
        }

        public void ShowStatistic()
        {
            Console.WriteLine($"Боец {_number} : Здоровье: {_healthPoint}, Наносимый урон: {_damage}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Fighter player1 = new Fighter(100, random.Next(1, 10), 1);
            Fighter player2 = new Fighter(100, random.Next(1, 10), 2);


            while (player1.healthpoint > 0 && player2.healthpoint > 0)
            {
                player1.ShowStatistic();
                player2.ShowStatistic();

                Console.ReadKey();
                Console.Clear();

                if (player1.healthpoint < player2.damage && player2.healthpoint < player1.damage)
                {
                    Console.WriteLine("Ничья");
                }
                else
                {
                    if (player1.healthpoint < player2.damage)
                    {
                        player1.healthpoint = 0;
                        Console.WriteLine($"Боец {player2.number} победил");
                    }
                    if (player2.healthpoint < player1.damage)
                    {
                        player2.healthpoint = 0;
                        Console.WriteLine($"Боец {player1.number} победил");
                    }
                }

                player1.healthpoint -= player2.damage;
                player2.healthpoint -= player1.damage;
            }

                Console.ReadKey();
        }
    }
}


