// https://leetcode.com/problems/longest-consecutive-sequence/description/

static int LongestConsecutive(int[] nums)
{
    if (nums.Length is 0)
        return 0;

    HashSet<int> values = [];

    foreach (var n in nums)
        values.Add(n);

    var maxLength = 0;

    foreach (var num in values)
    {
        if (!values.Contains(num - 1))
        {
            var currentLength = 1;

            while (values.Contains(num + currentLength))
            {
                currentLength++;
            }

            if (currentLength > maxLength)
                maxLength = currentLength;
        }
    }

    return maxLength;
}
