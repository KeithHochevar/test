using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Fayomi_20180327
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();

            car1.make = "Chevy";
            car1.model = "Cruze";
            //car1.setTopSpeed(110);
            car1.SpeedUp();
            car1.SpeedUp();
            car1.SpeedUp();
            car1.SpeedUp();
            car1.SpeedUp();
            car1.SpeedUp();
            Console.WriteLine("Current Speed:" + car1.getSpeed());

            Car car2 = new Car();
            car2.make = "Ford";
            car2.model = "Focus";
            car2.setTopSpeed(100);
            for (int i = 0; i < 50; i++)
            {
                car2.SpeedUp();
                car2.ToString();
            }
            */

            Car car3 = new Car();
            car3.make = "Ford";
            car3.model = "Focus";
            car3.setTopSpeed(220);
            car3.ToString();
            for (int i = 0; i < 55; i++)
            {
                car3.SpeedUp();
            }
            car3.ToString();
            car3.Honk();
            while (car3.getSpeed() > 25)
            {
                car3.SlowDown();
            }
            car3.ToString();
            car3.Beep();


        }
    }
}
