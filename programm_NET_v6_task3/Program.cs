using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Расширить иерархию классов из задания №2 с использованием виртуального класса в качестве основы иерархии. Показать пример использования полиморфизма методов.");
            Console.WriteLine();

            Product detail = new Detail();
            detail.name = "Корпус редуктора";
            detail.weight = 5.5;
            detail.manufacturer = "LADA";
            detail.info();

            Product node = new Node();
            node.name = "Редуктор";
            node.weight = 7.5;
            node.manufacturer = "УАЗ";
            node.info();

            Product mechanizm = new Mechanizm();
            mechanizm.name = "Механические передачи";
            mechanizm.weight = 9.5;
            mechanizm.manufacturer = "BMW";
            mechanizm.info();

            Console.ReadKey();
        }
    }
}
