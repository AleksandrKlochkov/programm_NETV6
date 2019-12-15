using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm_NET_v6_task3
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

        public override string showInfo()
        {
            string str = "Номер детали: " + number + "\nНаименование детали: " + title + name + "\nВес детали: " + weight + "кг"+ "\nПроизволитель детали: " + manufacturer + "\nМаркировка детали: " + marking;
            return str;
        }

    }
}
