using LibExt;

namespace TestFixMethod;

[TestClass]
public class TestLinq
{
    
    private List<Event> _events;

    [TestInitialize]
    public void Initialize()
    {
        _events = Event.InitEvents();
    }
    
    [TestMethod]
    public void TestEvents()
    {
        var expected = new List<Event> { _events[2], _events[0], _events[1], _events[3] };
        var juneEvents = _events
            .Where(e => e.StartDate.Month == 6 && e.StartDate.Year == 2024)
            .OrderBy(e => e.StartDate)
            .ToList();
        
        CollectionAssert.AreEqual(expected, juneEvents);
        
    }
}