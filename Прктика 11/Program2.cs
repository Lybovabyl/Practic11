using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп___2
{
    internal class Phone
    {
        private int battery;

        public int BatteryLevel
        {
            get => battery;
            set
            {
                if (value < 0)
                {
                    battery = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("Заряд не может превышать 100!");
                    battery = 100;
                }
                else
                {
                    battery = value;
                }
            }
        }

        public string Brand { get; set; }

        public Phone(string brand, int initialCharge)
        {
            Brand = brand;
            BatteryLevel = initialCharge;
        }

        public void Use()
        {
            if (BatteryLevel >= 10)
            {
                BatteryLevel -= 10;
                Console.WriteLine($"{Brand}: заряд {BatteryLevel}%.");
            }
            else
            {
                Console.WriteLine($"{Brand}: недостаточно заряда для использования.");
            }
        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone("Samsung", 80);

            
            myPhone.Use();
            myPhone.Use(); 
            myPhone.Use();
            myPhone.BatteryLevel = 150;

        }
    }
}
