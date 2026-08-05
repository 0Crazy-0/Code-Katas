// https://leetcode.com/problems/contains-duplicate/

static bool ContainsDuplicate(int[] nums)
{
    HashSet<int> ints = [];

    for (int x = 0; x < nums.Length; x++)
    {
        if (ints.Contains(nums[x]))
            return true;

        ints.Add(nums[x]);
    }
    return false;
}
