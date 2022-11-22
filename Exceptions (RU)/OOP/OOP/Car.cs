using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{   
     class Car
    {
        public string _Type;
        public Engine _engine;
        public Chassis _chassis;
        public Transmission _transmission;

        public Car()
        {

        }
        public Car(string type,Engine engine, Chassis chassis, Transmission transmission)
        {
            if (type == "Bus"|| type == "Minicar" || type == "Truck" || type == "Scooter")
            {
                _Type = type;
                _engine = engine;
                _chassis = chassis;
                _transmission = transmission;
            }
            else
            {
                throw new CarException("Ошибка инициализации");
            }
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
