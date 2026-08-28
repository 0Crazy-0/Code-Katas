// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

static int[] TwoSum(int[] numbers, int target)
{
    var left = 0;
    var right = numbers.Length - 1;

    while (numbers[left] + numbers[right] != target)
    {
        if (numbers[left] + numbers[right] < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return [left + 1, right + 1];
}
