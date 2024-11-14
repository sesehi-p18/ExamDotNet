using LibExt;

namespace TestFixMethod;
[TestClass]
public class TestListMethods
{

    private List<string> _tags = new List<string> {
        "Home", "Work", "Sport", "Travel", "Cinema", "Music"
    };
    private List<int> _values = new List<int> {10, 20, 30, 47, -20};
    private List<int> _values2 = new List<int>{
        -50, -20, 0, 10, 15, 18, 20, 22, 32, 30, 40, 45, 50, 60
    };
    
    [TestInitialize]
    public void Initialize()
    {
        
    }
    
    [TestMethod]
    public void TestEvenValues()
    {
        var expectedList = new List<int> {10, 20, 30, -20};
        CollectionAssert.AreEqual(expectedList, _values.EvenValues());
    }
    
    [TestMethod]
    public void TestOddValues()
    {
        var expectedList = new List<int> {47};
        CollectionAssert.AreEqual(expectedList, _values.OddValues());
    }
    
    [TestMethod]
    public void TestTransformStringsToUpper()
    {
        var tags = new List<string> { "home", "work", "sport" };
        var result = tags.Transform(tag => tag.ToUpper());
        var expected = new List<string> { "HOME", "WORK", "SPORT" };

        CollectionAssert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestTransformStringsToLower()
    {
        var tags = new List<string> { "HOME", "WORK", "SPORT" };
        var result = tags.Transform(tag => tag.ToLower());
        var expected = new List<string> { "home", "work", "sport" };

        CollectionAssert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestTransformStringsWithJpg()
    {
        var tags = new List<string> { "home", "work", "sport" };
        var result = tags.Transform(tag => tag.ToLower() + ".jpg");
        var expected = new List<string> { "home.jpg", "work.jpg", "sport.jpg" };

        CollectionAssert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void TestTransformIntegers()
    {
        var values = new List<int> { 10, 20, 30, 47, -20 };
        var result = values.Transform(value => value * 2);
        var expected = new List<int> { 20, 40, 60, 94, -40 };

        CollectionAssert.AreEqual(expected, result);
    }
    
}