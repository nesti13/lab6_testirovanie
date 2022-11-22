using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace OOP
{
    class Program
    {

        static void Main(string[] args)
        {


            Engine engine_for_bus = new Engine(200, 20, "forbus", 2002);
            Chassis chassis_for_bus = new Chassis(4, 200, 1000);
            Transmission transmission_for_bus = new Transmission(6, "Cool_for_bus", "Tesla");
            Car bus = new Car("Bus", engine_for_bus, chassis_for_bus, transmission_for_bus);
            // bus.Print();
             Engine engine_for_minicar = new Engine(300, 10, "forminicar", 1707);
            Chassis chassis_for_minicar = new Chassis(4, 400, 20000);
            Transmission transmission_for_minicar = new Transmission(6, "Cool_for_minicar", "Bugaty");
            Car minicar = new Car("Minicar", engine_for_minicar, chassis_for_minicar, transmission_for_minicar);
           // minicar.Print();

            Engine engine_for_Truck = new Engine(500, 10, "forTruck", 1707);
            Chassis chassis_for_Truck = new Chassis(4, 400, 20000);
            Transmission transmission_for_Truck = new Transmission(6, "Cool_for_Truckr", "Bugaty");
            Car Truck = new Car("Truck", engine_for_Truck, chassis_for_Truck, transmission_for_Truck);
            //Truck.Print();

            Engine engine_for_Scooter = new Engine(500, 10, "forScooter", 1707);
            Chassis chassis_for_Scooter = new Chassis(4, 400, 20000);
            Transmission transmission_for_Scooter = new Transmission(6, "Cool_for_Scooter", "Bugaty");
            Car Scooter = new Car("Scooter", engine_for_Scooter, chassis_for_Scooter, transmission_for_Scooter);
            //Scooter.Print();

           

            var Collection_of_car = new List<Car>();
            Collection_of_car.Add(bus);
            Collection_of_car.Add(minicar);
            Collection_of_car.Add(Scooter);
            Collection_of_car.Add(Truck);
            getAutoParameter(Collection_of_car, "type", "Bus");
           // getAutoParameter(Collection_of_car, "transmission count", "6");
           // getAutoParameter(Collection_of_car, "transmission count", "3");
            var select = from p in Collection_of_car
                         orderby p._transmission._Count_of_speed
                         select p;
            //Полную информацию о всех транспортных средствах, сгруппированную по типу трансмиссии.
            XmlDocument XDoc = new XmlDocument();
            XmlNode xmlNode = XDoc.CreateElement("cars");
            XDoc.AppendChild(xmlNode);
            foreach (Car car in select)
            {
                
               

                XmlNode carNode = XDoc.CreateElement("car");
                XmlAttribute attribute = XDoc.CreateAttribute("Type");
                attribute.Value = $"{car._Type}";
                carNode.Attributes.Append(attribute);

                XmlNode EngineNode = XDoc.CreateElement("Engine");
                XmlNode e_c_Power = XDoc.CreateElement("Power");
                e_c_Power.InnerText = $"{car._engine._Power}";
                XmlNode e_c_Volume = XDoc.CreateElement("Volume");
                e_c_Volume.InnerText = $"{car._engine._Volume}";
                XmlNode e_c_Type = XDoc.CreateElement("Type");
                e_c_Type.InnerText = $"{car._engine._Type}";
                XmlNode e_c_Serial_number = XDoc.CreateElement("Serial_number");
                e_c_Serial_number.InnerText = $"{car._engine._Serial_number}";
                EngineNode.AppendChild(e_c_Power);
                EngineNode.AppendChild(e_c_Volume);
                EngineNode.AppendChild(e_c_Type);
                EngineNode.AppendChild(e_c_Serial_number);
                carNode.AppendChild(EngineNode);



                XmlNode ChassisNode = XDoc.CreateElement("Chassis");
                XmlNode c_c_count_wheel = XDoc.CreateElement("_count_wheel");
                c_c_count_wheel.InnerText = $"{car._chassis._count_wheel}";
                XmlNode c_c_number = XDoc.CreateElement("_number");
                c_c_number.InnerText = $"{car._chassis._number}";
                XmlNode c_c_permissible_load = XDoc.CreateElement("_permissible_load");
                c_c_permissible_load.InnerText = $"{car._chassis._permissible_load}";
                ChassisNode.AppendChild(c_c_count_wheel);
                ChassisNode.AppendChild(c_c_number);
                ChassisNode.AppendChild(c_c_permissible_load);
                carNode.AppendChild(ChassisNode);

                XmlNode TransmissionNode = XDoc.CreateElement("Transmission");
                XmlNode t_c_Type = XDoc.CreateElement("_Type");
                t_c_Type.InnerText = $"{car._transmission._Type}";
                XmlNode t_c_number = XDoc.CreateElement("_Creater");
                t_c_number.InnerText = $"{car._transmission._Creater}";
                XmlNode t_c_permissible_load = XDoc.CreateElement("_permissible_load");
                t_c_permissible_load.InnerText = $"{car._transmission._Count_of_speed}";
                TransmissionNode.AppendChild(t_c_Type);
                TransmissionNode.AppendChild(t_c_number);
                TransmissionNode.AppendChild(t_c_permissible_load);
                carNode.AppendChild(TransmissionNode);
                xmlNode.AppendChild(carNode);


            }
            
            XDoc.Save("C:\\Users\\thesi\\Desktop\\5\\НПО\\8lab\\Collections (RU)\\OOP\\OOP\\test-doc.xml");


            //Полную информацию о всех транспортных средствах, обьем двигателя которых больше чем 1.5 литров;
            var selectedcar = from p in Collection_of_car
                              where p._engine._Volume > 15
                              select p;

            XmlDocument XDoc1 = new XmlDocument();
            XmlNode xmlNode1 = XDoc1.CreateElement("cars");
            XDoc1.AppendChild(xmlNode1);
            foreach (Car car in selectedcar)
            {



                XmlNode carNode = XDoc1.CreateElement("car");
                XmlAttribute attribute = XDoc1.CreateAttribute("Type");
                attribute.Value = $"{car._Type}";
                carNode.Attributes.Append(attribute);

                XmlNode EngineNode = XDoc1.CreateElement("Engine");
                XmlNode e_c_Power = XDoc1.CreateElement("Power");
                e_c_Power.InnerText = $"{car._engine._Power}";
                XmlNode e_c_Volume = XDoc1.CreateElement("Volume");
                e_c_Volume.InnerText = $"{car._engine._Volume}";
                XmlNode e_c_Type = XDoc1.CreateElement("Type");
                e_c_Type.InnerText = $"{car._engine._Type}";
                XmlNode e_c_Serial_number = XDoc1.CreateElement("Serial_number");
                e_c_Serial_number.InnerText = $"{car._engine._Serial_number}";
                EngineNode.AppendChild(e_c_Power);
                EngineNode.AppendChild(e_c_Volume);
                EngineNode.AppendChild(e_c_Type);
                EngineNode.AppendChild(e_c_Serial_number);
                carNode.AppendChild(EngineNode);



                XmlNode ChassisNode = XDoc1.CreateElement("Chassis");
                XmlNode c_c_count_wheel = XDoc1.CreateElement("_count_wheel");
                c_c_count_wheel.InnerText = $"{car._chassis._count_wheel}";
                XmlNode c_c_number = XDoc1.CreateElement("_number");
                c_c_number.InnerText = $"{car._chassis._number}";
                XmlNode c_c_permissible_load = XDoc1.CreateElement("_permissible_load");
                c_c_permissible_load.InnerText = $"{car._chassis._permissible_load}";
                ChassisNode.AppendChild(c_c_count_wheel);
                ChassisNode.AppendChild(c_c_number);
                ChassisNode.AppendChild(c_c_permissible_load);
                carNode.AppendChild(ChassisNode);

                XmlNode TransmissionNode = XDoc1.CreateElement("Transmission");
                XmlNode t_c_Type = XDoc1.CreateElement("_Type");
                t_c_Type.InnerText = $"{car._transmission._Type}";
                XmlNode t_c_number = XDoc1.CreateElement("_Creater");
                t_c_number.InnerText = $"{car._transmission._Creater}";
                XmlNode t_c_permissible_load = XDoc1.CreateElement("_permissible_load");
                t_c_permissible_load.InnerText = $"{car._transmission._Count_of_speed}";
                TransmissionNode.AppendChild(t_c_Type);
                TransmissionNode.AppendChild(t_c_number);
                TransmissionNode.AppendChild(t_c_permissible_load);
                carNode.AppendChild(TransmissionNode);
                xmlNode1.AppendChild(carNode);


            }

            XDoc1.Save("C:\\Users\\thesi\\Desktop\\5\\НПО\\8lab\\Collections (RU)\\OOP\\OOP\\exe1.xml");

            //Тип двигателя, серийный номер и его мощность для всех автобусов и грузовиков;

            var selectedcar1 = from p in Collection_of_car
                              where p._Type == "Bus"|| p._Type == "Truck"
                               select p;


            XmlDocument XDoc2 = new XmlDocument();
            XmlNode xmlNode2 = XDoc2.CreateElement("cars");
            XDoc2.AppendChild(xmlNode2);
            foreach (Car car in selectedcar1)
            {



                XmlNode carNode = XDoc2.CreateElement("car");
                XmlAttribute attribute = XDoc2.CreateAttribute("Type");
                attribute.Value = $"{car._Type}";
                carNode.Attributes.Append(attribute);

                XmlNode EngineNode = XDoc2.CreateElement("Engine");
                XmlNode e_c_Power = XDoc2.CreateElement("Power");
                e_c_Power.InnerText = $"{car._engine._Power}";
                XmlNode e_c_Volume = XDoc2.CreateElement("Volume");
                e_c_Volume.InnerText = $"{car._engine._Volume}";
                XmlNode e_c_Type = XDoc2.CreateElement("Type");
                e_c_Type.InnerText = $"{car._engine._Type}";
                XmlNode e_c_Serial_number = XDoc2.CreateElement("Serial_number");
                e_c_Serial_number.InnerText = $"{car._engine._Serial_number}";
                EngineNode.AppendChild(e_c_Power);
                EngineNode.AppendChild(e_c_Volume);
                EngineNode.AppendChild(e_c_Type);
                EngineNode.AppendChild(e_c_Serial_number);
                carNode.AppendChild(EngineNode);



                XmlNode ChassisNode = XDoc2.CreateElement("Chassis");
                XmlNode c_c_count_wheel = XDoc2.CreateElement("_count_wheel");
                c_c_count_wheel.InnerText = $"{car._chassis._count_wheel}";
                XmlNode c_c_number = XDoc2.CreateElement("_number");
                c_c_number.InnerText = $"{car._chassis._number}";
                XmlNode c_c_permissible_load = XDoc2.CreateElement("_permissible_load");
                c_c_permissible_load.InnerText = $"{car._chassis._permissible_load}";
                ChassisNode.AppendChild(c_c_count_wheel);
                ChassisNode.AppendChild(c_c_number);
                ChassisNode.AppendChild(c_c_permissible_load);
                carNode.AppendChild(ChassisNode);

                XmlNode TransmissionNode = XDoc2.CreateElement("Transmission");
                XmlNode t_c_Type = XDoc2.CreateElement("_Type");
                t_c_Type.InnerText = $"{car._transmission._Type}";
                XmlNode t_c_number = XDoc2.CreateElement("_Creater");
                t_c_number.InnerText = $"{car._transmission._Creater}";
                XmlNode t_c_permissible_load = XDoc2.CreateElement("_permissible_load");
                t_c_permissible_load.InnerText = $"{car._transmission._Count_of_speed}";
                TransmissionNode.AppendChild(t_c_Type);
                TransmissionNode.AppendChild(t_c_number);
                TransmissionNode.AppendChild(t_c_permissible_load);
                carNode.AppendChild(TransmissionNode);
                xmlNode2.AppendChild(carNode);


            }

            XDoc2.Save("C:\\Users\\thesi\\Desktop\\5\\НПО\\8lab\\Collections (RU)\\OOP\\OOP\\exe2.xml");
            RemoveAutoException(Collection_of_car, "Bu");
            Console.WriteLine("-------------------------------exeption------------------------");
            foreach(Car car1 in Collection_of_car)
            {
                car1.Print();
            }
        }

        private static void getAutoParameter(List<Car> list, string parameter, string value)
        {
            int result=0;
            if (list != null || parameter == "type" || parameter == "engine power" || parameter == "engine volume" || 
                parameter == "engine type" || parameter == "engine serial_number" || 
                parameter == "chassis count" || parameter == "chassis number" || parameter == "chassis load" 
                || parameter == "transmission count" || parameter == "transmission creater" || parameter == "transmission type")
            {
                foreach (Car car in list)
                {
                    if (parameter == "transmission count" && car._transmission._Count_of_speed == Convert.ToInt32(value))
                    {
                        car.Print();
                        result++;
                    }
                    if (parameter == "transmission creater" && car._transmission._Creater == value)
                    {
                        car.Print();
                        result++;
                    }
                    if (parameter == "transmission type" && car._transmission._Type == value)
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "type" && car._Type == value)
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "engine power" && car._engine._Power ==Convert.ToInt32(value))
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "engine volume" && car._engine._Volume == Convert.ToInt32(value))
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "engine type" && car._engine._Type == value)
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "engine serial_number" && car._engine._Serial_number == Convert.ToInt32(value))
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "chassis countr" && car._chassis._count_wheel == Convert.ToInt32(value))
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "chassis number" && car._chassis._number == Convert.ToInt32(value))
                    {
                        result++;
                        car.Print();
                    }
                    if (parameter == "chassis load" && car._chassis._permissible_load == Convert.ToInt32(value))
                    {
                        result++;
                        car.Print();
                    }
                }
                if(result==0)
                { throw new CarException("GetAutoByParameterException"); }
            }
            else
            {
                throw new CarException("GetAutoByParameterException");
            }
        }
        public static void RemoveAutoException(List<Car> cars, string type)
        {
            int result = 0;
            var list = new List<Car>();
            foreach (Car cars1 in cars)
            {
                if (cars1._Type == type)
                {
                    result++;
                    list.Add(cars1);
                    
                }
            }
            if (list != null)
            {
                foreach(Car car in list)
                cars.RemoveAll(x => x == car);
            }
            if (result==0)
            {
                throw new CarException("RemoveAutoException");
            }
        }
    }
}
