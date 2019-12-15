using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_2
{
    //Изделие является единицей промышленной продукции, любой предмет или набор предметов производства, изготовленный предприятием
    public class Product
    {
        // имя изделия 
        protected string name;
        // номер изделия
        protected int number;
        // вес изделия
        protected double weight;    

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

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Product(string name, int number, double weight)
        {
            this.name = name;
            this.number = number;
            this.weight = weight;
        }

        public virtual void show()
        {
            string str = "Номер изделия: " + number + "\nВес изделия: " + weight + "\nНаименование изделия: " + name;
            Console.WriteLine(str);
            Console.WriteLine("----------------------------");
        }

        public void add()
        {
            Console.WriteLine("Add");
        }

    }
}
