namespace LibExt;

public static class DateTimeExtMethods
{
    public static string ToIso8601(string inputDate)
    {
        DateTime parsedDate = DateTime.ParseExact(inputDate, "dd-MM-yyyy", null);
        string result = parsedDate.ToString("yyyy-MM-dd");
        return result;  
    }
    
    public static bool IsBetween(this DateTime date, DateTime date1, DateTime date2)
    {
        return date >= date1 && date <= date2;
    }

    public static bool IsWeekDay(this DateTime date)
    {
        return date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
    }

    public static bool IsWeekEnd(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }

    public static bool IsLeapYear(this DateTime date)
    {
        int year = date.Year;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
    
}