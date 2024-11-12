using System.Runtime.InteropServices.JavaScript;

namespace LibExt;

public static class ListExtMethods
{
    public static List<string> ToUpper(this List<string> list)
    {
        return list.Select(s => s.ToUpper()).ToList();
    }

    public static List<string> ToLower(this List<string> list)
    {
        return list.Select(s => s.ToLower()).ToList();
    }

    public static string LongestString(this List<string> list)
    {
        return list.OrderByDescending(s => s.Length).FirstOrDefault();
    }

    public static string ShortestString(this List<string> list)
    {
        return list.OrderBy(s => s.Length).FirstOrDefault();
    }

    public static T MaxValue<T>(this List<T> list) where T : IComparable
    {
        return list.Max();
    }

    public static T MinValue<T>(this List<T> list) where T : IComparable
    {
        return list.Min();
    }

    public static double ListTotal(this List<int> list)
    {
        return list.Sum();
    }

    public static double ListAverage(this List<int> list)
    {
        return list.Average();
    }

    public static class ListFilter
    {
        public static class String
        {
            public static List<string> EndWith(List<string> list, string contrainte)
            {
                return list.Where(item => item.ToString().EndsWith(contrainte)).ToList();
            }

            public static List<string> StartWith(List<string> list, string contrainte)
            {
                return list.Where(item => item.ToString().StartsWith(contrainte)).ToList();
            }

            public static List<string> Contains(List<string> list, string contrainte)
            {
                return list.Where(item => item.ToString().Contains(contrainte)).ToList();
            }

            public static List<string> MoreThanOrEqual(List<string> list, int moreThan)
            {
                return list.Where(item => item.ToString().Length >= moreThan).ToList();
            }
            
            public static List<string> MoreThan(List<string> list, int moreThan)
            {
                return list.Where(item => item.ToString().Length > moreThan).ToList();
            }
            
            public static List<string> LessThan(List<string> list, int moreThan)
            {
                return list.Where(item => item.ToString().Length < moreThan).ToList();
            }
            
            public static List<string> LessThanOrEqual(List<string> list, int moreThan)
            {
                return list.Where(item => item.ToString().Length <= moreThan).ToList();
            }
            
        }
        
        public static class Int
        {
            public static List<int> EndWith(List<int> list, string contrainte)
            {
                return list.Where(item => item.ToString().EndsWith(contrainte)).ToList();
            }

            public static List<int> StartWith(List<int> list, string contrainte)
            {
                return list.Where(item => item.ToString().StartsWith(contrainte)).ToList();
            }

            public static List<int> Contains(List<int> list, string contrainte)
            {
                return list.Where(item => item.ToString().Contains(contrainte)).ToList();
            }
            
            public static List<int> MoreThanOrEqual(List<int> list, int moreThanOrEqual)
            {
                return list.Where(item => item.ToString().Length >= moreThanOrEqual).ToList();
            }
            
            public static List<int> MoreThan(List<int> list, int moreThan)
            {
                return list.Where(item => item.ToString().Length > moreThan).ToList();
            }
            
            public static List<int> LessThan(List<int> list, int lessThan)
            {
                return list.Where(item => item.ToString().Length < lessThan).ToList();
            }
            
            public static List<int> LessThanOrEqual(List<int> list, int lessThanOrEqual)
            {
                return list.Where(item => item.ToString().Length <= lessThanOrEqual).ToList();
            }
            
        }

    }
    
    public static List<string> ToUpperAny(this List<string> list)
    {
        var result = new List<string>();
        for (int i = 0; i < list.Count(); i++)
        {
            result.Add(list[i].ToUpper());
        }

        return result;
    }

    public static List<T> ListLimit<T>(this List<T> list, int limit)
    {
        var result = new List<T>();
        if (limit >= 0)
        {
            if (limit <= list.Count)
            {
                for (var i = 0; i < limit; i++)
                {
                    result.Add(list[i]);
                }
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

        return result;
    }
    
}