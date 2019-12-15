using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task3
{
    //Узел – это сборочная единица, состоящая из деталей
    public class Node : Product //Узел
    {
        public Node()
        {
            nodeType = false;
            name = "";
            number = new Random().Next();
            title = "УЗЕЛ ";
            weight = 0.0;
            type = "NODE";
            marking = type + new Random().Next();
            manufacturer = "";
        }

        public override string showInfo()
        {
            string turningItem = nodeType ? "Сложный узел" : "Простой узел";
            string str = "Номер узла: " + number + "\nНаименование узла: " + title + name + "\nВес узла: " + weight + "кг" + "\nПроизволитель узла: " + manufacturer + "\nМаркировка узла: " + marking+ "\nТип узла: " + marking;
            return str;

        }
    }
}
