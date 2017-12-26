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
            var currWeek = DateTimeFormatInfo.InvariantInfo.Calendar.GetWeekOfYear(DateTime.Today,
                DateTimeFormatInfo.InvariantInfo.CalendarWeekRule,
                DateTimeFormatInfo.InvariantInfo.FirstDayOfWeek);
            var weekPrefix = currWeek > 9 ? $"{currWeek}" : $"0{currWeek}";
            _datePrefix = weekPrefix + DateTime.Today.ToString("yy");
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
