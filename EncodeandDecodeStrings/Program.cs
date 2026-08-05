// https://neetcode.io/problems/string-encode-and-decode/question

static string Encode(IList<string> strs)
{
    var res = "";

    foreach (var s in strs)
    {
        res += $"{s.Length}%{s}";
    }

    return res;
}

static List<string> Decode(string s)
{
    List<string> res = [];

    var i = 0;

    while (i < s.Length)
    {
        var j = i;

        while (s[j] is not '%')
        {
            j++;
        }

        var length = int.Parse(s[i..j]);

        var contentStart = j + 1;

        var word = s.Substring(contentStart, length);

        res.Add(word);

        i = contentStart + length;
    }
    return res;
}
