using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Построить иерархию классов в соответствии с вариантом задания.\r\nДеталь, механизм, изделие, узел\r\n1)Разработать методы и свойства для каждого из определяемых классов. ");
            Console.WriteLine();

            Product product = new Product("Изделие", 1111, 1.5);
            Detail detail = new Detail("Деталь", 22222, 1.0, "Поизводитель", "Маркировка");
            Mechanizm mechanizm = new Mechanizm("Механизм", 33333, 1.9, "Поизводитель", "Маркировка", "Передаточный механизм");
            Node node = new Node("Узел", 44444, 1.0, "Поизводитель", "Маркировка", false);
            product.show();
            detail.show();
            mechanizm.show();
            node.show();
            Console.ReadKey();
        }
    }
}
