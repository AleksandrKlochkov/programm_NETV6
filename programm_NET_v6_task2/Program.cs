using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Построить иерархию классов в соответствии с вариантом задания.\r\nДеталь, механизм, изделие, узел\r\n1)Разработать методы и свойства для каждого из определяемых классов. ");
            Console.WriteLine();

            Product detail = new Detail();
            detail.name = "Корпус редуктора";
            detail.weight = 5.5;
            detail.manufacturer = "LADA";
            detail.info();
            ((Detail)detail).showInfo();

            Product node = new Node();
            node.name = "Редуктор";
            node.weight = 7.5;
            node.manufacturer = "УАЗ";
            node.info();
            ((Node)node).showInfo();

            Product mechanizm = new Mechanizm();
            mechanizm.name = "Механические передачи";
            mechanizm.weight = 9.5;
            mechanizm.manufacturer = "BMW";
            mechanizm.info();
            ((Mechanizm)mechanizm).showInfo();

            Console.ReadKey();
        }
    }
}
