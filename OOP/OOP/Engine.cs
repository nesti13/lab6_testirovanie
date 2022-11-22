using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Engine
    {
        int _Power;
        int _Volume;
        string _Type;
        int _Serial_number;

        public Engine()
        {

        }
        public Engine(int power, int volume, string type, int serial_number)
        {
            _Power = power;
            _Volume = volume;
            _Type = type;
            _Serial_number = serial_number;
        }
        public void Print()
        {
            Console.WriteLine($"Двигатель");
            Console.WriteLine("Type , Serial_number,Volume, Power");
            Console.WriteLine($"{_Type}, {_Serial_number},{_Volume}, {_Power}");

        }
    }
}
