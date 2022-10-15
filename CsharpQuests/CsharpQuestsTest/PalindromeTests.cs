using CsharpQuests;

namespace CsharpQuestsTest;

public class PalindromeTests
{
    [Theory]
    [InlineData(0, true)]
    [InlineData(111, true)]
    [InlineData(101, true)]
    [InlineData(781, false)]
    [InlineData(1311, false)]
    [InlineData(09877890, false)]
    [InlineData(-111, true)]
    [InlineData(-11454451, false)]
    public void Should_return_palindrome(int value, bool expectedValue)
    {
        bool result = Palindrome.IsPalindrome(value);
        Assert.Equal(expectedValue, result);  
    }
}        
