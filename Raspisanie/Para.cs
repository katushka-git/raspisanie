using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
    class TimeTableItem
    {
        string teacher;
        string subject;
        int auditory;
        int number;
        string day;
        public TimeTableItem(string Teacher, string Subject, int Auditory, int Number, string Day)
        {
            teacher = Teacher;
            subject = Subject;
            auditory = Auditory;
            number = Number;
            day = Day;
          
        }
        public void  Print ()
        {
             Console.WriteLine($"Предователь: { Teacher:50}, Пара: {Subject:20}, Аудитория: {Auditory:3}, Номер пары: {Number:1}, День недели: {Day}");
           
        }
        public string Teacher {
            get { return teacher; }
            set { teacher = value; }
        }
        public string Subject {
            get { return subject; }
            set { subject = value; }
        }
        public int Auditory { get { return auditory; }
            set { auditory = value; }
        }
        public int Number { get {return number; }
            set { number = value; }

        }
        public string Day { get { return day; }
            set { day = value; }
        }
    }
}
