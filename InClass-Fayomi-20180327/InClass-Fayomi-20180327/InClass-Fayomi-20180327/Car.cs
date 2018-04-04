using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Fayomi_20180327
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        private int speed = 0;
        private int topSpeed;

        public void SpeedUp()
        {
            // speed = speed + 5;
            if (speed < topSpeed)
            {
                speed++;
            }
        }

        public void SlowDown()
        {
            if (speed > 0)
            {
                speed--;
            }
            // Console.WriteLine("Slowing Down...");
        }

        public void ToString()
        {
            Console.WriteLine("I'm a " + make + " " + model + "and I'm going " + speed + "mph");
        }

        public void setTopSpeed(int pTopSpeed)
        {
            this.topSpeed = pTopSpeed;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void Honk()
        {
            Console.WriteLine("Honk Honk!");
        }

        public void Beep()
        {
            Console.WriteLine("BEEP BEEP!");
        }
    }
}