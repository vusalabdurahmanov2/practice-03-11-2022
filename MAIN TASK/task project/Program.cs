using System;
using task_project.models;

namespace task_project
{
    class Program
    {
        static void Main(string[] args)
        {

            car car1 = new car(5,5,90.94,"yasil",6,6,6);
            
            Console.WriteLine($"Masin\nMator gucu:{car1.motor}\nrengi:{car1.color}\nSernisin sayi:{car1.PassangersCount}\nteker sayi:{car1.cycle}\nSurduyu yol:{car1.driveway}\nsureti:{car1.GetSpeed()}km/saat\nSurduyu zaman:{car1.drivetime}");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            bicycle bicycle1 = new bicycle(5, 90, "yasil", 6, 6, 6);
            Console.WriteLine($"Velosiped\nteker sayi:{bicycle1.cycle}\nSurduyu yol:{bicycle1.driveway}\nrengi:{bicycle1.color}\nSernisin sayi:{bicycle1.PassangersCount}\nSureti:{bicycle1.GetSpeed()}km/saat\nSurduyu zaman:{bicycle1.drivetime}");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            bus bus1 = new bus(5, 5, 90, "yasil", 6, 6, 6);
            Console.WriteLine($"Avtobus\nMator gucu:{bus1.motor}\nrengi:{bus1.color}\nSernisin sayi:{car1.PassangersCount}\nteker sayi:{bus1.cycle}\nSurduyu yol:{bus1.driveway}\nsureti:{bicycle1.GetSpeed()}km/saat\nSurduyu zaman:{bus1.drivetime}");
        }

    }
}
