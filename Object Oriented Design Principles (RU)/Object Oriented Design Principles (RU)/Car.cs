using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Design_Principles__RU_
{
    public class Car
    {
        public string mark;
        public string model;
        public int count;
        public int price;

        public Car()
        {

        }
        public Car(string mark, string model, int count, int price )
        {
            this.mark = mark;
            this.model = model;
            this.count = count;
            this.price = price;
        }
    }
}
