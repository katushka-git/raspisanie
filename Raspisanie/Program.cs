using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeTableItem one = new TimeTableItem("Соловьев", "Менеджмент", 111, 1, "Понедельник");
            //one.Print();
            TimeTableItem two = new TimeTableItem("Малахова", "Программирование", 112, 2, "Вторник");
            //two.Print();
            TimeTableItem three = new TimeTableItem("Саломатина", "Информационная безопасность", 112, 2, "Среда");
            //three.Print();
            TimeTableItem four = new TimeTableItem("Стоянова", "Бухгалтерский учет", 312, 4, "Пятница");
            //four.Print();
            TimeTableList TTL = new TimeTableList();
            TTL.Add(one);
            TTL.Add(two);
            TTL.Add(three);
            TTL.Add(four);
            TTL.GetTimeTable();
            







        }
    }
}
