using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_2
{
    //Узел – это сборочная единица, состоящая из деталей
    public class Node : Detail //Узел
    {
        protected bool turning; // поворотный не поворотный


        public bool Turning
        {
            get { return turning; }
            set { turning = value; }
        }

        public Node(string name, int number, double weight, string marking, string manufacturer, bool turning)
            : base(name, number, weight, marking, manufacturer)
        {
            this.turning = turning;
        }

        public void show()
        {
            string turningItem = turning ? "Да" : "Нет";
            string str = "Номер узла: " + number + "\nВес узла: " + weight + "\nНаименование узла: " + name + "\nПроизволитель узла: " + manufacturer + "\nПоворотный: " + turningItem;
            Console.WriteLine(str);
            Console.WriteLine("----------------------------");

        }
    }
}
