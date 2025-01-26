namespace Day8
{
    public struct HireDate : IComparable
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

         public int CompareTo(object? obj)

        {
            if (obj == null) return 1;

            Counter.C++;
            HireDate HD = (HireDate)obj;
            if (Year != HD.Year)
                return Year.CompareTo(HD.Year);
             else if (Month != HD.Month)
                return Month.CompareTo(HD.Month);
             else
                return Day.CompareTo(HD.Day);
        }

        public override string ToString()
        {
            return $"{Day}-{Month}-{Year}";
        }
    }
}
