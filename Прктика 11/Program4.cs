using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп___4
{
    internal class Program
    {
        internal class Player
        {
            private int level;
            private int health;

            public string Name
            { get; set; }

            public int Level
            {
                get
                { return level; }
                set
                {
                    if (value < 1 || value > 101)
                    {
                        Console.WriteLine("Уровень должен быть от 1 до 100!");
                        level = 100;
                    }
                    else
                    {
                        level = value;
                    }
                }
            }

            public int Health
            {
                get
                { return health; }
                set
                {
                    if (value < 0 || value > 101)
                    { }
                    else
                    {
                        health = value;
                    }
                }
            }

            public bool IsAlive
            {
                get
                { return Health > 0; }
            }

            public Player(string name, int level, int health)
            {
                Name = name;
                Level = level;
                Health = health;
            }

            public void TakeDamage(int damage)
            {
                Health -= damage;
                if (Health < 0) Health = 0;
                Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {(IsAlive ? "Да" : "Нет")}");
            }
        }


        static void Main(string[] args)
        {

            {
                Player player = new Player("Тыковка", 5, 70);
                Console.WriteLine($"Игрок: {player.Name}, уровень: {player.Level}, здоровье: {player.Health}, жив: {(player.IsAlive ? "Да" : "Нет")}");

                player.TakeDamage(30); 
                player.TakeDamage(30); 

                player.Level = 0; 
                Console.ReadLine();
            }
        }
    }
}
