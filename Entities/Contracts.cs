using System;
namespace Exercicios.Entities
{
    class HourContract
    {
        public DateTime Date { get;  private set; }
        public int Hours { get;  private set; }
        public double ValuePerHours { get;  private set; }
        public double TotalValue()
        {
            return Hours * ValuePerHours;
        }
        public HourContract()
        { }
        public HourContract(DateTime date, int hours, double valuePerHour)
        {
            Date = date;
            Hours = hours;
            ValuePerHours = valuePerHour;
        }
    }

}
