namespace Day8Task2
{
    public struct HiringDate
    {
        #region Data
        public int Day;
        public int Month;
        public int Year;
        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region ToString Override
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        #endregion
    }
}
