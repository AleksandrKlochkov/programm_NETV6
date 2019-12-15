using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_2
{
    //Механизм система подвижно соединенных деталей, предна­значенная для преобразования движения одного или нескольких тел
    public class Mechanizm : Detail
    {

        protected string type; //тип механизма

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Mechanizm(string name, int number, double weight, string marking, string manufacturer, string type) : base(name, number, weight, marking, manufacturer)
        {
            this.type = type;
        }

        public void show()
        {
            string str = "Номер механизма: " + number + "\nВес: " + weight + "\nНаименование: " + name + "\nТим Механизма: " + type;
            Console.WriteLine(str);
            Console.WriteLine("----------------------------");

        }
    }
}
