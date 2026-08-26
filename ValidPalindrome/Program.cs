// https://leetcode.com/problems/valid-palindrome/

static bool IsPalindrome(string s)
{
    List<char> clean = [];
    foreach (var c in s)
    {
        if (char.IsLetterOrDigit(c))
            clean.Add(char.ToLower(c));
    }

    var left = 0;
    var right = clean.Count - 1;

    while (left < right)
    {
        if (clean[left] != clean[right])
            return false;

        left++;
        right--;
    }
    return true;
}
