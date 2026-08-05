// https://leetcode.com/problems/top-k-frequent-elements/description/

static int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> count = [];
    List<int>[] freq = new List<int>[nums.Length + 1];

    for (int i = 0; i < freq.Length; i++)
    {
        freq[i] = [];
    }

    foreach (int n in nums)
    {
        if (count.ContainsKey(n))
        {
            count[n]++;
        }
        else
        {
            count[n] = 1;
        }
    }

    foreach (var entry in count)
    {
        freq[entry.Value].Add(entry.Key);
    }

    var res = new int[k];
    var index = 0;

    for (var i = freq.Length - 1; i > 0 && index < k; i--)
    {
        foreach (int n in freq[i])
        {
            res[index++] = n;

            if (index == k)
                return res;
        }
    }
    return res;
}
