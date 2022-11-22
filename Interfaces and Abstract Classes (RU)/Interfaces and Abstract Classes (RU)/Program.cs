using System;

namespace Interfaces_and_Abstract_Classes__RU_
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate newc = new Coordinate(0, 0, 0);
             Drone drone= new Drone("Дрон 1", newc);
            drone.FlyTo();
            drone.FlyTo();
            drone.FlyTo();
            drone.FlyTo();
            drone.FlyTo();
        }
    }
}
