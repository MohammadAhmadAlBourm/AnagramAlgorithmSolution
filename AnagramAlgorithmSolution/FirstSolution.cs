namespace AnagramAlgorithmSolution;

internal static class FirstSolution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] chars1 = s.ToCharArray();
        char[] chars2 = t.ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        var str1 = new string(chars1);
        var str2 = new string(chars2);

        return str1 == str2;
    }
}