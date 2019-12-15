using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task3
{
    //Механизм система подвижно соединенных деталей, предна­значенная для преобразования движения одного или нескольких тел
    public class Mechanizm : Product
    {

        public Mechanizm()
        {
            name = "";
            number = new Random().Next();
            title = "Механизм ";
            weight = 0.0;
            type = "MECHANIZM";
            marking = type + new Random().Next();
            manufacturer = "";
        }

        public override string showInfo()
        {
            string str = "Номер механизма: " + number + "\nНаименование механизма: " + title + name + "\nВес механизма: " + weight + "кг" + "\nПроизволитель механизма: " + manufacturer + "\nМаркировка механизма: " + marking;
            return str;
  
        }
    }
}
