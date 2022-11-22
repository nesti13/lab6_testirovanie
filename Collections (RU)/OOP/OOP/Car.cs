using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
     class Car
    {
        public string _Type;
        public Yana _yana;
        public Chassis _chassis;
        public Transmission _transmission;

        public Car()
        {

        }
        public Car(string type,Yana yana, Chassis chassis, Transmission transmission)
        {
            _Type = type;
            _yana = yana;
            _chassis = chassis;
            _transmission = transmission;

        }
        public void Print()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"Тип: {_Type}, Хар-ки:");
            _yana.Print();
            _chassis.Print();
            _transmission.Print();
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
