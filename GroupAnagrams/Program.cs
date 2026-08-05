// https://leetcode.com/problems/group-anagrams/description/

static List<List<string>> GroupAnagrams(string[] strs)
{
    Dictionary<string, List<string>> res = [];

    foreach (var s in strs)
    {
        var charArray = s.ToCharArray();

        charArray.Sort();

        string sortedS = new(charArray);

        if (!res.ContainsKey(sortedS))
            res[sortedS] = [];

        res[sortedS].Add(s);
    }
    return [.. res.Values];
}
