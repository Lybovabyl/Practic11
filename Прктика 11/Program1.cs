using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_1
{

    class Car
    {

        private int speed;


        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 || value > 300)
                {
                    Console.WriteLine("Скорость не может превышать 300!");
                }
                else
                {
                    speed = value;
                }
            }
        }

        public string Model { get; set; } = "Unknown";

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }


        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car сar = new Car("BMW", 150);
            сar.Drive();




        }
    }
}

