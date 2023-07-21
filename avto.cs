using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] cars =
            {
                {"Caddilac", "Audi", "Lexus", "Toyota" },
                {"BMW", "Subaru", "Land Rover", "Honda" },
                {"Nissan", "Lada", "Mazda", "Opel" }
            };
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nСписок марок автомобилей:\n");
                for (int i = 0; i < cars.GetLength(0); i++)
                {
                    for (int j = 0; j < cars.GetLength(1); j++)
                    {
                        Console.Write(cars[i, j] + " || ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Салон автомобилей");
                Console.WriteLine("\n\nОсновные команды:");
                Console.WriteLine("\n1 - Узнать марку по индексу.\n\n2 - Найти индекс по марке.\n\n3 - Выход из программы.");
                Console.Write("\nВыберите команду : ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер линии : ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер столбца : ");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Это марка : " + cars[line, column]);
                        break;
                    case 2:
                        string mark;
                        bool markisFound = false;
                        Console.Write("Введите марку автомобиля:");
                        mark = Console.ReadLine();
                        for (int i = 0; i < cars.GetLength(0); i++)
                        {
                            for (int j = 0; j < cars.GetLength(1); j++)
                            {
                                if (mark.ToLower() == cars[i, j].ToLower())
                                {
                                    Console.WriteLine($"Марка {cars[i, j]} находится по адресу {i + 1} {j + 1}");
                                    markisFound = true;
                                }
                            }
                        }
                        if (markisFound == false)
                        {
                            Console.WriteLine("Такой марки автомобиля нет.");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда.");
                        break;
                }
                if (isOpen)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
