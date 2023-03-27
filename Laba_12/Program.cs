using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дорогой пользователь, введи название города для поиска индекса: ");
            string s = Console.ReadLine();

            // создаю новый словарь
            Hashtable index = new Hashtable()
            {
                ["пенза"] = 58,
                ["иркутск"] = 38,
                ["липецк"] = 48,
                ["москва"] = 50,
                ["мурманск"] = 51,
                ["новгород"] = 53,
                ["орел"] = 57,
                ["самара"] = 63,
                ["саратов"] = 64,
                ["сахалинская область"] = 65
            };

            if (index.ContainsKey(s))
            {
                Console.WriteLine($"индекс этого города: {index[s]}");
                // выводит индекс города по ключу

                index.Remove(s);
                // удаляем

                foreach (var i in index.Keys)
                {
                    Console.WriteLine(index[i]);
                }
                // перебираем массив и выводим все элементы словаря

                index.Clear();
                // полностью удаляем содержимое словаря
            }
            else
            {
                Console.WriteLine("Такого ключа не существует, шэф");
                //это сообщение выводится в консоль если ключа не существует
            }
        }
    }
}