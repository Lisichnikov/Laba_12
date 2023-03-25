using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дорогой пользователь, введи название города для поиска индекса: ");
            string s = Console.ReadLine();
            // создаю значение s которое будет вводит пользователь

            // создаю новый словарь
            Hashtable dict = new Hashtable()
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

            // вывожу на консоль то что написал пользователь
            Console.WriteLine($"индекс этого города: {dict[s]}");
        }
    }
}
