using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstract_Classes__RU_
{
    public class Drone : IFlyable
    {
        private string name;
        private Coordinate coordinate;
        private int speed;
        private int time;
        public Drone(string name, Coordinate coordinate)
        {
            this.name = name;
            this.coordinate = coordinate;
            this.speed = 200;
            this.time = 1;
        }
        public IFlyable FlyTo()
        {
            if ((time % 10 != 0)&&(coordinate.x+speed<1000)&&(coordinate.y+speed<1000)&&(coordinate.z+speed<1000))
            {
                coordinate.x = coordinate.x + speed;
                coordinate.y = coordinate.y + speed;
                coordinate.z = coordinate.z + speed;
                Console.WriteLine("Новые координаты");
               
            }
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
