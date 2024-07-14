namespace AnagramAlgorithmSolution;

internal static class ThirdSolution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var dict = new Dictionary<char, int>();

        foreach (var item in s)
        {
            if (dict.TryGetValue(item, out int value)) dict[item] = ++value;
            else dict[item] = 1;
        }

        foreach (var item in t)
        {
            if (!dict.TryGetValue(item, out int value)) return false;
            else dict[item] = --value;
        }

        return true;
    }
}