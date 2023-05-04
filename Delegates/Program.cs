using System;

namespace Delegates//Лабораторная работа по Мищенко №11(3_2)
{
    class Program
    {
        static void Main()
        {
            // Вызываем метод Run() класса Calculator 5 раз
            for (int i = 0; i < 5; i++)
            {
                // Выводим номер итерации на консоль
                Console.WriteLine($"Итерация {i + 1}:");

                // Вызываем метод Run() класса Calculator
                Calculator.Run();

                // Выводим пустую строку для разделения результатов
                Console.WriteLine();
            }
        }
    }
}

