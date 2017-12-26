using System;
using System.Globalization;

namespace STETools
{
    public class SerialNumberGenerator
    {
        const string Chars = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
        private string _modelPrefix;
        private string _datePrefix;
        private int capacity = 3;
        private Random _generator;

        public SerialNumberGenerator()
        {
            _generator = new Random();
            _modelPrefix = "STE320";
            _datePrefix = DateTime.Today.ToString("yy") + DateTimeFormatInfo.InvariantInfo.Calendar.GetWeekOfYear(DateTime.Today,
                              DateTimeFormatInfo.InvariantInfo.CalendarWeekRule,
                              DateTimeFormatInfo.InvariantInfo.FirstDayOfWeek);
        }

        public string Generate()
        {
            string serial = "";
            for (int i = 0; i < capacity; i++)
            {
                serial += Chars[_generator.Next(0, Chars.Length-1)];
            }
            return _modelPrefix + _datePrefix + serial;
        }
    }
}
