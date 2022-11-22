using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstract_Classes__RU_
{
    public class Airplane : IFlyable
    {
        private string name;
        private Coordinate coordinate;
        private int speed;
        private int time;
        public Airplane(string name, Coordinate coordinate)
        {
            this.name = name;
            this.coordinate = coordinate;
            this.speed = 200;
            this.time = 0;
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
            if (speed < 1000)
            {
                speed = speed + 10;
            }
            return null;
        }
    }
}
