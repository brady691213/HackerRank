using System.Diagnostics;

namespace ConsoleApp1;

public class Tests
{
    public static List<int> ReadIntList(string path, bool withHeaders = false)
    {
        var text = File.ReadAllText(path);
        var lines = text.Split(['\n'], 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (!withHeaders)
        {
            return lines[0].Split(' ').Select(int.Parse).ToList();
        }
        var count = int.Parse(lines[0]);
        var nums = lines[1].Split(' ').Select(int.Parse).ToList();
        Debug.Assert(count == nums.Count);
        return nums;
    }
}