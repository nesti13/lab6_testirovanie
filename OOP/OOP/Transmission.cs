using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Transmission
    {
        int _Count_of_speed;
        string _Creater;
        string _Type;
        
        public Transmission()
        {

        }
        public Transmission(int count, string creater, string type)
        {
            _Count_of_speed = count;
            _Creater = creater;
            _Type = type;
        }
        public void Print()
        {
            Console.WriteLine($"Трансмиссия");
            Console.WriteLine("Count_of_speed, Creater,Type");
            Console.WriteLine($"{_Count_of_speed}, {_Creater},{_Type}");

        }
    }
}
