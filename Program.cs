using System.Drawing;
using task17.Model;

namespace task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avtomobil");

            Console.Write("İlkin yanacaq miqdarini daxil edin (default 20): ");
            double initialFuel = double.TryParse(Console.ReadLine(), out double result) ? result : 20;

            Console.Write("Tank tutumunu daxil edin (default 40): ");
            double tankCapacity = double.TryParse(Console.ReadLine(), out result) ? result : 40;

            Console.Write("100 km-e yanacaq serfiyyatini daxil edin(default 10): ");
            double fuelConsumption = double.TryParse(Console.ReadLine(), out result) ? result : 10;

            Car car = new Car(initialFuel, tankCapacity, fuelConsumption);

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. surucu");
                Console.WriteLine("2. zaprafka");
                Console.WriteLine("3. yanacaq goster");
                Console.WriteLine("4. km goster");
                Console.Write("seciminizi daxil edin: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Surmek ucun kilometrleri daxil edin: ");
                            if (double.TryParse(Console.ReadLine(), out double kilometers))
                            {
                                if (car.Drive(kilometers))
                                {
                                    Colored.Write("yaxsi yol!", ConsoleColor.Green);
                                    Console.WriteLine($" - yanacaq qalb: {car.Fuel:F2} litr - kilometr: {car:F2} km");
                                }
                                else
                                {
                                    Colored.Write("Bu yolla getmek mumkun deyil.", ConsoleColor.Red);
                                }
                            }
                            else
                            {
                                Colored.Write("yanlis daxiletme", ConsoleColor.Red);
                            }
                            break;

                        case 2:
                            Console.Write("yanacaq doldurma meblegin daxil et: ");
                            if (double.TryParse(Console.ReadLine(), out double amount))
                            {
                                if (car.Refuel(amount))
                                {
                                    Colored.Write("yaxsi yanacaq doldurun!", ConsoleColor.Green);
                                    Console.WriteLine($" - yanacaq: {car.Fuel:F2} litr");
                                }
                                else
                                {
                                    Colored.Write("yanlis daxil olundu.", ConsoleColor.Red);
                                }
                            }
                            else
                            {
                                Colored.Write("yanlis daxiletme", ConsoleColor.Red);
                            }
                            break;

                        case 3:
                            Console.WriteLine($"yanacq: {car.Fuel:F2} litr");
                            break;

                        case 4:
                            Console.WriteLine($"Mileage: {car:F2} km");
                            break;

                        default:
                            Colored.Write("yanlis daxiletme tekrar yoxla.", ConsoleColor.Red);
                            break;
                    }
                }
                else
                {
                    Colored.Write("yanlis daxiletme tekrar yoxla.", ConsoleColor.Red);
                }
            }
        }
    }
    }

    
