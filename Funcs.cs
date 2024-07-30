using System.Diagnostics;

namespace ConsoleApp1;

public class Funcs
{
    // public static int lonelyinteger(List<int> a)
    // {
    //     var unique = a.First(grp => grp.Count() == 1).Key;
    //     return unique;
    // }
    
    public static int DiagSum(List<List<int>> arr, bool secondary = false)
    {
        var off = 0;
        var diff = arr.Sum(t => t[off++]);
        off = arr[0].Count - 1;
        diff = arr.Aggregate(diff, (current, t) => (int)(current - t[off--]));
        return Math.Abs(diff);
    }

    public static List<int> FreqArray(List<int> arr)
    {
        var counts = arr.GroupBy(t => t).ToDictionary(g => g.Key, g => g.Count());
        List<int> freq = [];
        for (var num = 0; num < arr.Count; num++)
        {
            var group = counts.GetValueOrDefault(num, 0);
            freq.Add(group);
        }
        return freq;
    }
}