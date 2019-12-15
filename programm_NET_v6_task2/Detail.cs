using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task2
{
    //Деталь - изделие, изготовленное из однородного по наименованию и марке материала без применения  сборочных операций
    public class Detail : Product
    {
      
        public Detail()
        {
            name = "";
            number = new Random().Next();
            title = "Деталь ";
            weight = 0.0;
            type = "DETAIL";
            marking = type + new Random().Next();
            manufacturer = "";

        }

        public void showInfo()
        {
            string str = "Номер детали: " + number + "\nНаименование: " + title + name + "\nВес: " + weight + "кг"+ "\nПроизволитель: " + manufacturer + "\nМаркировка: " + marking;
            Console.WriteLine(str);
            Console.WriteLine("----------------------------");
        }

    }
}
