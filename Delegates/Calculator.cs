using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //Определяем класс Calculator
    class Calculator
    {
        // Объявляем делегат MathOperation, который принимает значение double и возвращает значение double
        delegate double MathOperation(double value);

        // Определяем статические методы для математических операций
        static double Add(double value) //сложение
        {
            return value + 10;
        }

        static double Subtract(double value) //вычитание
        {
            return value - 5;
        }

        static double Multiply(double value) //умножение
        {
            return value * 2;
        }

        static double Divide(double value) //деление
        {
            return value / 2;
        }

        // Определяем метод Run(), который формирует массив указателей на методы и последовательно вызывает каждый метод
        public static void Run()
        {
            // Создаем массив указателей на методы MathOperation размера 4
            MathOperation[] operations = new MathOperation[4];

            // Заполняем массив указателей на методы
            operations[0] = Add;
            operations[1] = Subtract;
            operations[2] = Multiply;
            operations[3] = Divide;

            // Начальное значение, которое будет передано первому методу
            double value = 10;

            /* Проходим по всем элементам массива указателей на методы и последовательно вызываем каждый метод,
             передавая ему результат предыдущего метода в качестве параметра*/
            for (int i = 0; i < operations.Length; i++)
            {
                value = operations[i](value);
                Console.WriteLine($"Шаг {i}: {value}");
            }
        }
    }
}