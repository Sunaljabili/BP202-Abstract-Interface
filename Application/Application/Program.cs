using System;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nece mashin isteyirsiz ?");
            int carCount = Convert.ToInt32(Console.ReadLine());

            Car[] cars = new Car[carCount];

            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine("Rengi daxil edin : ");
                string color = Console.ReadLine();
                Console.WriteLine("Brand daxil edin : ");
                string brand = Console.ReadLine();
                Console.WriteLine("Millage daxil edin :");
                double millage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Fuelcapacity daxil edin : ");
                double fuelCapacity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("CurrentFuel daxil edin : ");
                double currentFuel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("FuelFor1KM daxil edin : ");
                double fuelFor1KM = Convert.ToDouble(Console.ReadLine());
                Car car = new Car()
                {
                    Brand = brand,
                    Color = color,
                    Millage = millage,
                    FuelCapacity = fuelCapacity,
                    CurrentFuel = currentFuel,
                    FuelFor1Km = fuelFor1KM
                };

                //car.Drive(20);
                cars[i] = car;


            }

           
            Console.WriteLine("----MENU----");
            Console.WriteLine("1.Mashinlari Millage gore filterle");
            Console.WriteLine("2.Butun mashinlari goster");
            Console.WriteLine("3.Prosesi bitir");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("min millage daxil edin : ");
                    double minMillage = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("max millage daxil edin : ");
                    double maxMillage = Convert.ToDouble(Console.ReadLine());
                    foreach (var item in cars)
                    {
                        if(item.Millage>=minMillage && item.Millage < maxMillage)
                        {
                            item.ShowInfo();
                        }
                    }
                    break;
                case 2:
                    foreach (var item in cars)
                    {
                        item.ShowInfo();
                    }
                    break;

                case 3:
                    Console.WriteLine("Proqram bitir");
                    break;
                default:
                    Console.WriteLine("Bele sechim yoxdur.");
                    break;

            }

        }
    }
}
