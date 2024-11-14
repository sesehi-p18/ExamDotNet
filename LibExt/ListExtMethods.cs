namespace LibExt;

public static class ListExtMethods
{

    public static List<int> EvenValues(this List<int> values)
    {
        return values.Where(x => x % 2 == 0).ToList();
    }

    public static List<int> OddValues(this List<int> values)
    {
        return values.Where(x => x % 2 == 1).ToList();
    }
    
    public static List<TOutput> Transform<TInput, TOutput>(this List<TInput> inputList, Func<TInput, TOutput> transformFunc)
    {
        var outputList = new List<TOutput>();
        foreach (var item in inputList)
        {
            outputList.Add(transformFunc(item));
        }
        
        return outputList;
    }
    
}