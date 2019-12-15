using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_2
{
    //Деталь - изделие, изготовленное из однородного по наименованию и марке материала без применения  сборочных операций
    public class Detail : Product
    {

        protected string marking; //Маркировка или штрих код
        protected string manufacturer; // производитель

        public string Mark
        {
            get { return marking; }
            set { marking = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public Detail(string name, int number, double weight, string marking, string manufacturer) : base(name, number, weight)
        {
            this.marking = marking;
            this.manufacturer = manufacturer;
        }

        public void show()
        {
            string str = "Номер детали: " + number + "\nВес: " + weight + "\nНаименование: " + name + "\nПроизволитель: " + manufacturer + "\nМаркировка: " + marking;
            Console.WriteLine(str);
            Console.WriteLine("----------------------------");

        }

    }
}
