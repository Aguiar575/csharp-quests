namespace CsharpQuests;

public static class Palindrome
{
    public static bool IsPalindrome(int value)
    {
        int num;
        int reverse;
        int aux;

        num = value; 
        reverse = 0;
        
        while (num != 0)
        {
            aux = num % 10;
            reverse = (reverse * 10) + aux;
            num = num / 10;
        }
        
        if (value == reverse) 
            return true;
        
        return false;
    }
}