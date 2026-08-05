// https://leetcode.com/problems/two-sum/description/

static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> numToIndex = [];

    for (int i = 0; i < nums.Length; i++)
    {
        if (numToIndex.ContainsKey(target - nums[i]))
            return [numToIndex[target - nums[i]], i];

        if (!numToIndex.ContainsKey(nums[i]))
            numToIndex.Add(nums[i], i);
    }
    return [];
}
