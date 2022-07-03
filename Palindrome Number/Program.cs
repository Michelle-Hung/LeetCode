// See https://aka.ms/new-console-template for more information

bool IsPalindrome(int x)
{
    if (x < 0)
    {
        return false;
    }
    var stringArray = x.ToString().ToCharArray();
    var isEqual = stringArray.SequenceEqual(stringArray.Reverse());
    return isEqual;
}

var isPalindrome = IsPalindrome(-9999999);
Console.WriteLine(isPalindrome);