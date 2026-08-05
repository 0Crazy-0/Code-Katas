// https://leetcode.com/problems/valid-anagram/description/

static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    int[] Counts = new int[26];

    for (var i = 0; i < s.Length; i++)
    {
        Counts[s[i] - 'a']++;
        Counts[t[i] - 'a']--;
    }

    foreach (var count in Counts)
    {
        if (count is not 0)
            return false;
    }
    return true;
}
