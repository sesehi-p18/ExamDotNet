namespace TestFixMethod;

[TestClass]
public class TestExtMethods
{
    [TestMethod]
    public void TestLeft()
    {
        var data= LibExt.TestExtMethods.left(3,"testText");
        Assert.AreEqual(data, "tes");
    }

    [TestMethod]
    public void TestRight()
    {
        var data= LibExt.TestExtMethods.right(3,"testText");
        Assert.AreEqual(data, "ext");
    }
    
    [TestMethod]
    public void TestEllipsis()
    {
        var data= LibExt.TestExtMethods.ellipsis(3,"***");
        Assert.AreEqual(data, "Alp***");
    }
    
    [TestMethod]
    public void TestFillLeft()
    {
        var data= LibExt.TestExtMethods.fillLeft("Indi4", 8,'*');
        Assert.AreEqual(data, "***Indi4");
    }
    
    [TestMethod]
    public void TestFillRight()
    {
        var data= LibExt.TestExtMethods.FillRight("Indi4", 8,'*');
        Assert.AreEqual(data, "Indi4***");
    }
    
}