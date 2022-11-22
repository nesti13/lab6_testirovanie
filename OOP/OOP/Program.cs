using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine_for_bus = new Engine(200, 20, "forbus", 2002);
            Chassis chassis_for_bus = new Chassis(4, 200, 1000);
            Transmission transmission_for_bus = new Transmission(6,"Cool_for_bus", "Tesla");
            Car bus = new Car("Bus", engine_for_bus, chassis_for_bus, transmission_for_bus);
            bus.Print();

            Engine engine_for_minicar = new Engine(300, 10, "forminicar", 1707);
            Chassis chassis_for_minicar = new Chassis(4, 400, 20000);
            Transmission transmission_for_minicar = new Transmission(6, "Cool_for_minicar", "Bugaty");
            Car minicar = new Car("Minicar", engine_for_minicar, chassis_for_minicar, transmission_for_minicar);
            minicar.Print();

            Engine engine_for_Truck = new Engine(500, 10, "forTruck", 1707);
            Chassis chassis_for_Truck = new Chassis(4, 400, 20000);
            Transmission transmission_for_Truck = new Transmission(6, "Cool_for_Truckr", "Bugaty");
            Car Truck = new Car("Truck", engine_for_Truck, chassis_for_Truck, transmission_for_Truck);
            Truck.Print();

            Engine engine_for_Scooter = new Engine(500, 10, "forScooter", 1707);
            Chassis chassis_for_Scooter = new Chassis(4, 400, 20000);
            Transmission transmission_for_Scooter = new Transmission(6, "Cool_for_Scooter", "Bugaty");
            Car Scooter = new Car("Scooter", engine_for_Scooter, chassis_for_Scooter, transmission_for_Scooter);
            Scooter.Print();
        }
    }
}
