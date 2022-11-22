using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Chassis
    {
        int _count_wheel;
        int _number;
        int _permissible_load;

        public Chassis()
        {

        }
        public Chassis(int count, int number, int load)
        {
            _count_wheel = count;
            _number = number;
            _permissible_load = load;
        }
        public void Print()
        {
            Console.WriteLine($"Шасси");
            Console.WriteLine("count_wheel, number,permissible_load}");
            Console.WriteLine($"{_count_wheel}, {_number},{_permissible_load}");

        }
    }
}
