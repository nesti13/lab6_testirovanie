using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstract_Classes__RU_
{
    public interface IFlyable
    {
        
        public void FlyTo()
        {
            Console.WriteLine("FlyTo");

        }
        public void GetFlyTime()
        {
            Console.WriteLine("GetFlyTime");
        }
    }
}
