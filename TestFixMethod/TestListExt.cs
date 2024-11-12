using LibExt;

namespace TestFixMethod;

[TestClass]
public class TestListExt
{

    [TestMethod]
    public void TestListUpper()
    {
        var data = ListExtMethods.ToUpper(new List<string> { "a", "b", "c" });
        var expected = new List<string> { "A", "B", "C" };
        CollectionAssert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListLower()
    {
        var data = ListExtMethods.ToLower(new List<string> { "A", "B", "C" });
        var expected = new List<string> { "a", "b", "c" };
        CollectionAssert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListLonguest()
    {
        var data = ListExtMethods.LongestString(new List<string> { "A", "BB", "CCC" });
        var expected = "CCC";
        Assert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListShorter()
    {
        var data = ListExtMethods.ShortestString(new List<string> { "A", "BB", "CCC" });
        var expected = "A";
        Assert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListMaxValue()
    {
        var data = ListExtMethods.MaxValue(new List<int> { 125, 250, 500 });
        var expected = 500;
        Assert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListMinValue()
    {
        var data = ListExtMethods.MinValue(new List<int> { 125, 250, 500 });
        var expected = 125;
        Assert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListTotal()
    {
        var data = ListExtMethods.ListTotal(new List<int> { 125, 250, 500 });
        var expected = 875;
        Assert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListAverage()
    {
        var data = ListExtMethods.ListAverage(new List<int> { 300, 500 });
        var expected = 400;
        Assert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListFilter()
    {
        var data = ListExtMethods.ListFilter.String.Contains(new List<string> { "lundi", "mardi", "mercredi", "jeudi", "vendredi" }, "re");
        var expected = new List<string> { "mercredi", "vendredi" };
        CollectionAssert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListUpperAny()
    {
        var data = ListExtMethods.ToUpperAny(new List<string> { "lundi", "mardi", "mercredi", "jeudi", "vendredi" });
        var expected = new List<string> { "LUNDI", "MARDI", "MERCREDI", "JEUDI", "VENDREDI" };
        CollectionAssert.AreEqual(data, expected);
    }
    
    [TestMethod]
    public void TestListLimit()
    {
        var data = ListExtMethods.ListLimit(new List<string> { "lundi", "mardi", "mercredi", "jeudi", "vendredi" }, 3);
        var dataInt = ListExtMethods.ListLimit(new List<int> { 10, 20, 30, 40, 50, 60 }, 3);
        var expected = new List<string> { "lundi", "mardi", "mercredi" };
        var expectedInt = new List<int> { 10, 20, 30 };
        CollectionAssert.AreEqual(data, expected);
        CollectionAssert.AreEqual(dataInt, expectedInt);
    }
    
}