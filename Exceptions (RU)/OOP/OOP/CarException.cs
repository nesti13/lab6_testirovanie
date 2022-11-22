using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class CarException:Exception
    {
        public CarException(string message) : base(message) { }
    }
}
