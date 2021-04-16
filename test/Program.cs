using System;
using System.Collections.Generic;
using System.Linq;

namespace CalorieCalculator
{
    class Program
    {

        static void Main()
        {
            Dictionary<string, int> ModelPrice = new Dictionary<string, int> // Список
                {{ "Samsung Galaxy M21", 17550 },
                { "Xiaomi Mi 10T", 33425 },
                { "Google Pixel 4a", 44856 },
                { "Huawei Honor 10X Lite", 15874 },
                { "OPPO A53", 10999 },
                { "OnePlus 8", 36549 },
                { "Sony Xperia 10 II", 23500 },
                { "Realme X3 SuperZoom", 29390 },
                { "Motorola Moto G9 Plus", 17990}};
                Dictionary<string, int> Menu = new Dictionary<string, int> { };
                Console.Clear();
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("1. Посетитель");
                Console.WriteLine("2. Администатор");
                Console.WriteLine("3. Выход");
                switch (Console.ReadLine())
                {
                    case "1": // Посетитель
                        Console.Clear();
                        MenuClient();
                        break;
                    case "2": // Администатор
                        Console.Clear();
                        MenuAdmin();
                        break;
                    case "3":
                        break; // Выход
                    default:
                        Console.WriteLine("Попробуйте еще раз.. ");
                        Console.ReadKey();
                        Main();
                        break;
                }
            void MenuAdmin() // Администратор
            {
                Console.Clear();
                Console.WriteLine("1. Добавить товар");
                Console.WriteLine("2. Удалить товар");
                Console.WriteLine("3. Назад");
                Console.WriteLine("4. Выход");
            }
            switch (Console.ReadLine())
            {
                case "1":
                    AddPhone();
                    break;
                case "2":
                    DeletePhone();
                    break;
                case "3":
                    Main();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Попробуйте еще раз..");
                    Console.ReadKey();
                    MenuAdmin();
                    break;
            }
            void MenuClient() // Посетитель
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("1. Вывод списка");
                Console.WriteLine("2. Отсортировать список");
                Console.WriteLine("3. Назад");
                Console.WriteLine("4. Выход");
                switch (Console.ReadLine())
                {
                    case "1": // Вывод списка
                        Console.Clear();
                        ListOutput();
                        break;
                    case "2": // Сортировка списка
                        Console.Clear();
                        ListSort();
                        break;
                    case "3":
                        Main();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Попробуйте еще раз.. ");
                        Console.ReadKey();
                        Main();
                        break;
                }
            }
            void AddPhone()
            {
                Console.Clear();
                Console.Write("Введите короткое описание формата: ");
                string model = Console.ReadLine();
                while (model.Trim() == "")
                {
                    Console.Write("Введите модель: ");
                    model = Console.ReadLine();
                }
                Console.Write("Введите стоимость: ");
                int price = int.Parse(Console.ReadLine());
                ModelPrice.Add(model, price);
                
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню");
                Console.ReadKey();
                Main(); // С маином нормально все, но когда Админское меню вставляешь, то оно вылетает. Ну короче именно с этим неясности

            }
            void DeletePhone()
            {

            }
            void ListSort()
            {

            }
            void SearhElem()
            {
                
            }
            void ListOutput()
            {
                Console.Clear();
                if (ModelPrice.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    foreach (KeyValuePair<string, int> elem in ModelPrice)
                    {
                        Console.WriteLine("х Модель - {0},\n  Цена - {1}", elem.Key, elem.Value);
                    }
                }
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню");
                Console.ReadKey();
                MenuClient(); // Оно работает, да
            }
        }
    }
}