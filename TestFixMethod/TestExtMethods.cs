using LibExt;

namespace TestFixMethod;

[TestClass]
public class TestExtMethods
{
    [TestMethod]
    public void TestBooleanToInt()
    {
        bool a = true;
        bool b = false;
        Assert.AreEqual(1, a.BoolToInt());
        Assert.AreEqual(0, b.BoolToInt());
    }

    [TestMethod]
    public void TestSnakeCase()
    {
        var s = "Lorem IPSUM dolor Sit Amet";
        var expected1 = "lorem_ipsum_dolor_sit_amet";
        var expected2 = "lorem-ipsum-dolor-sit-amet";
        Assert.AreEqual(expected1, s.SnakeCase());
        Assert.AreEqual(expected2, s.SnakeCase("-"));
    }
    
    [TestMethod]
    public void TestFullTrim()
    {
        var s = " lorem ipsum dolor sit amet ";
        var expected = "lorem ipsum dolor sit amet";

        Assert.AreEqual(expected, s.CustomTrim());
    }

}