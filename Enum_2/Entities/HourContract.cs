using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_2.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract()
        {

        }
        public HourContract(DateTime date,double value,int hour)
        {
            Date = Date;
            ValuePerHour = value;
            Hours = hour;
        }
        public double TotalValue()
        {
            return ValuePerHour*Hours;
        }
    }
}
