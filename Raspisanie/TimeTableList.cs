using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
    class TimeTableList
       
    {
        List<TimeTableItem> list;
        public TimeTableList()
        {
            list = new List<TimeTableItem>();
        }
        public void Add(TimeTableItem item)
        {
            list.Add(item);
        }
        public void GetTimeTable()
        {
            foreach (var item in list)
            {
                item.Print();
            }
        }
       
    }
}
