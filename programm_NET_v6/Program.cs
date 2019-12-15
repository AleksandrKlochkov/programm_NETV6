using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool task = false;
            int a;
            int b;
            double c;
            do
            {
            Console.WriteLine("Выполнение задания по предмету 'Программирование под платформу .NET' Вариант-6");
            task = false;
            Console.WriteLine("Задание 1");
            Console.WriteLine("Написать C# программу, реализующую функцию согласно варианту задания. Исходные данные вводятся с клавиатуры.\r\nРеализовать функцию возведения в куб разности двух  целых чисел ");
            Console.WriteLine();
            Console.WriteLine("Введите число а: ");
            string keyA = Console.ReadLine();
            Console.WriteLine("Введите число b: ");
            string keyB = Console.ReadLine();
            if (!int.TryParse(keyA, out a) || !int.TryParse(keyB, out b))
            {
                Console.WriteLine("Ошибка! Вы ввели не верные значения, попробуйте снова");
                task = true;
            }
            else
            {
                //Возведение разности в 3 степень
                c = Math.Pow(a - b, 3);
                Console.WriteLine("Результат: " + c);
                Console.WriteLine("Нажмите любую клавишу для выхода в меню");
                Console.WriteLine();
                Console.ReadKey();
                task = true;
            }
        }while (task == true);
        Console.ReadKey();
        }
    }
}

