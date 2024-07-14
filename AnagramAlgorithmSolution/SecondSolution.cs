namespace AnagramAlgorithmSolution;

internal static class SecondSolution
{

    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        int[] chars = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i]]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            chars[t[i]]--;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}