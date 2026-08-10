// https://leetcode.com/problems/product-of-array-except-self/

static int[] ProductExceptSelf(int[] nums)
{
    var n = nums.Length;
    var res = new int[n];

    Array.Fill(res, 1);

    for (var i = 1; i < n; i++)
    {
        res[i] = res[i - 1] * nums[i - 1];
    }

    var postfix = 1;

    for (var i = n - 1; i >= 0; i--)
    {
        res[i] *= postfix;
        postfix *= nums[i];
    }

    return res;
}
