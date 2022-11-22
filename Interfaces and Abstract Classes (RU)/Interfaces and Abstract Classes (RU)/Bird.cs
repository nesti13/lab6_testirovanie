using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstract_Classes__RU_
{
    public class Bird : IFlyable
    {
        private string name;
        private Coordinate coordinate;
        private int speed;
        private int time;

        public Bird(string name, Coordinate coordinate)
        {
            Random random = new Random();
            speed = random.Next(1, 20);
            time = 0;
            this.name = name;
            this.coordinate = coordinate;

        }
        public IFlyable FlyTo()
        {
            coordinate.x = coordinate.x + speed;
            coordinate.y = coordinate.y + speed;
            coordinate.z = coordinate.z + speed;
            Console.WriteLine("Новые координаты");
            coordinate.Print();
            GetFlyTime();
            return null;
        }
        public IFlyable GetFlyTime()
        {
            time = time + 1;
            return null;
        }
    }
}
