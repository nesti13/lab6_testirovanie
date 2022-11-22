using System;
using System.Collections.Generic;

namespace Object_Oriented_Design_Principles__RU_
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var carlist = new List<Car>();
            Command command = new Command();
            Choise choise1 = new Choise();
            choise1.SetCommand(0, new CommandForType(command));
            choise1.SetCommand(1, new CommandForAll(command));
            Console.WriteLine("Введите характеристики машин");
            Console.WriteLine("Введите марку");
            string mark = Console.ReadLine();
            Console.WriteLine("Введите модель");
            string model = Console.ReadLine();
            Console.WriteLine("Введите количество");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цена");
            int price = Convert.ToInt32(Console.ReadLine());
            Car car_user = new Car(mark, model, count, price);
            carlist.Add(car_user);
            Console.WriteLine("Выберите команду");
            Console.WriteLine("1- количество марок автомобилей");
            Console.WriteLine("2- общее количество автомобилей");
            Console.WriteLine("3- средняя стоимость автомобиля");
            Console.WriteLine("4- средняя стоимость автомобилей каждой марки (марка задается пользователем)");
            Console.WriteLine("5- добавить машину");
          
            int choise = Convert.ToInt32(Console.ReadLine());
            while (choise>0&&choise<5)
            {
                switch (choise)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите марку");
                            string mark_for_1 = Console.ReadLine();
                            choise1.PressCount(0, carlist, mark_for_1);
                            break;
                        }
                    case 2:
                        {
                            choise1.PressCount(1,carlist);
                            break;
                        }
                    case 3:
                        {
                            choise1.PressPrice(1, carlist);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите марку");
                            string mark_for_1 = Console.ReadLine();
                            choise1.PressPrice(0, carlist, mark_for_1);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите характеристики машин");
                            Console.WriteLine("Введите марку");
                            string mark1 = Console.ReadLine();
                            Console.WriteLine("Введите модель");
                            string model1 = Console.ReadLine();
                            Console.WriteLine("Введите количество");
                            int count1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите цена");
                            int price1 = Convert.ToInt32(Console.ReadLine());
                            Car car_user1 = new Car(mark1, model1, count1, price1);
                            carlist.Add(car_user1);
                            break;
                        }
                    default: break;
                }
                Console.WriteLine("Выберите команду");
                choise = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
