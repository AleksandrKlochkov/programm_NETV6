﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task3
{
    //Изделие является единицей промышленной продукции, любой предмет или набор предметов производства, изготовленный предприятием
    public class Product 
    {
        // имя 
        public string name;
        // название 
        public string title;
        // номер
        public int number;
        // вес 
        public double weight;
        // тип
        public string type;
        // маркировка или штрих код
        public string marking;
        // производитель
        public string manufacturer;
        // тип узла
        public bool nodeType;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public void info()
        {
            string str = "\nНаименование изделия: " + Name +"_"+ Number + "\nТип изделия: " + Type;
            Console.WriteLine(str);
            Console.WriteLine("----------------------");
            Console.WriteLine(showInfo() + "\r\n----------------------------");
           
        }

        public virtual string showInfo()
        {
            return "";
        }

    }
}
