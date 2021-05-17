using System;

namespace ControleSalario.Entities
{
    class HourContract
    {
        public DateTime date { get; set; }

        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
