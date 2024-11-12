using LibExt;

namespace TestFixMethod;

[TestClass]
public class TestDateTimeExt
{
    [TestMethod]
    public void ISO8601DateOnly()
    {
        var data = DateTimeExtMethods.ToIso8601("12-02-2026");
        Assert.AreEqual("2026-02-12", data);
    }

    [TestMethod]
    public void IsBetweenCheck()
    {
        var data = DateTimeExtMethods.IsBetween(
            new DateTime(2024, 05, 12),
            new DateTime(2022, 05, 12),
            new DateTime(2025, 05, 12)
            );
        Assert.IsTrue(data);
    }
    
    [TestMethod]
    public void IsWeekDayCheck()
    {
        var date1 = new DateTime(2024, 05, 13); //Lundi
        var date2 = new DateTime(2024, 05, 12); //Dimanche

        Assert.IsTrue(DateTimeExtMethods.IsWeekDay(date1));
        Assert.IsFalse(DateTimeExtMethods.IsWeekDay(date2));
    }
    
    [TestMethod]
    public void IsWeekEndCheck()
    {
        var date1 = new DateTime(2024, 05, 13); //Lundi
        var date2 = new DateTime(2024, 05, 12); //Dimanche

        Assert.IsTrue(DateTimeExtMethods.IsWeekEnd(date2));
        Assert.IsFalse(DateTimeExtMethods.IsWeekEnd(date1));
    }
    
    [TestMethod]
    public void IsLeapYearCheck()
    {
        bool data = DateTimeExtMethods.IsLeapYear(new DateTime(2024, 05, 12));
        bool dataFalse = DateTimeExtMethods.IsLeapYear(new DateTime(2025, 05, 12));
        
        Assert.IsTrue(data);
        Assert.IsFalse(dataFalse);
    }
    
}