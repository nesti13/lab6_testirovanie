using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Design_Principles__RU_
{
    public interface ICommand
    {
        void Count(List<Car> car, string type = null);
        void Price(List<Car> car, string type = null);
    }
    public class Command
    {
        public void count_types(List<Car> car, string type = null)
        { foreach (Car car1 in car) 
            {
                if(car1.mark==type)
                {
                    Console.WriteLine(car1.count);
                }
            } 
        }
        public void count_all(List<Car> car, string type = null)
        {
            int allcount = 0;
            foreach (Car car1 in car)
            {
                allcount = allcount + car1.count;
            }
            Console.WriteLine(allcount);
        }
        public void average_price(List<Car> car, string type = null) {

            int allcount = 0;
            int allprice = 0;
            foreach (Car car1 in car)
            {
                allcount++;
                allprice = allprice + car1.price;
            }
            Console.WriteLine(allprice/allcount);
        }
        public void price_type(List<Car> car, string type = null)
        {
            int allcount = 0;
            foreach (Car car1 in car)
            {
                if (car1.mark == type)
                {
                    allcount++;
                    Console.WriteLine(car1.price /allcount);
                }
            }
        }
    }
    public class CommandForType:ICommand
    {
        private Command command;
        public CommandForType(Command command) => this.command = command;
        public void Count(List<Car> car, string type = null) => command.count_types(car, type);
        public void Price(List<Car> car, string type = null) => command.price_type(car, type);
    }
    public class CommandForAll : ICommand
    {
        private Command command;
        public CommandForAll(Command command) => this.command = command;
        public void Count( List<Car> car, string type=null) => command.count_all( car, type);
        public void Price(List<Car> car, string type = null) => command.average_price(car, type);
    }
    public class Choise
    {
        private List<ICommand> commands;
        private Stack<ICommand> history;

        public Choise()
        {
            commands = new List<ICommand>() { null, null };
            history = new Stack<ICommand>();
        }
        public void SetCommand(int button, ICommand command) => commands[button] = command;
        public void PressPrice(int button,List<Car> car, string type = null)
        {
            commands[button].Price(car, type);
            history.Push(commands[button]);
        }
        public void PressCount(int button, List<Car> car,string type=null)
        {
            commands[button].Count(car, type);
            history.Push(commands[button]);
        }
    }
}
