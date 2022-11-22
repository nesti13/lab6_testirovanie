using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car
    {
        string _Type;
        Engine _engine;
        Chassis _chassis;
        Transmission _transmission;

        public Car()
        {

        }
        public Car(string type,Engine engine, Chassis chassis, Transmission transmission)
        {
            _Type = type;
            _engine = engine;
            _chassis = chassis;
            _transmission = transmission;

        }
        public void Print()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"Тип: {_Type}, Хар-ки:");
            _engine.Print();
            _chassis.Print();
            _transmission.Print();
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
