using System;

static bool IsPalindrome(string word) 
{
    bool result = true;
    for (int i = 0; i < word.Length / 2; i++) 
    {
        int e = i + 1;
        var check1 = word[i];
        var check2 = word[i == 0 ? ^1 : ^e];
        if (word[i] != word[i == 0 ? ^1 : ^e]) 
        {
            result = false;
            break;
        }
    }
    return result;
}

Console.WriteLine(IsPalindrome("Anna").ToString());
Console.WriteLine(IsPalindrome("civic").ToString());
Console.WriteLine(IsPalindrome("kayak").ToString());
Console.WriteLine(IsPalindrome("level").ToString());
Console.WriteLine(IsPalindrome("madam").ToString());
Console.WriteLine(IsPalindrome("mom").ToString());
Console.WriteLine(IsPalindrome("noon").ToString());
Console.WriteLine(IsPalindrome("racecar").ToString());
Console.WriteLine(IsPalindrome("radar").ToString());
Console.WriteLine(IsPalindrome("redder").ToString());
Console.WriteLine(IsPalindrome("refer").ToString());
Console.WriteLine(IsPalindrome("rerepaperfer").ToString());
Console.WriteLine(IsPalindrome("rotator").ToString());
Console.WriteLine(IsPalindrome("12321").ToString());
Console.WriteLine(IsPalindrome("15651").ToString());