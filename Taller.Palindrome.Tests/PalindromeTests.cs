using FluentAssertions;
using Xunit;

namespace Taller.Palindrome.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void ShouldReturnAnEmptyStringForNullInput()
        {
            string result = Palindrome.LongestPalindrome(null);
            result.Should().Be(string.Empty);
        }

        [Fact]
        public void ShouldReturnAnEmptyStringForEmptyInput()
        {
            string result = Palindrome.LongestPalindrome(string.Empty);
            result.Should().Be(string.Empty);
        }

        [Fact]
        public void ShouldReturnTheInputItselfForOneCharacter()
        {
            string result = Palindrome.LongestPalindrome("a");
            result.Should().Be("a");
        }

        [Fact]
        public void ShouldReturnabaWithabacInput()
        {
            string result = Palindrome.LongestPalindrome("abac");
            result.Should().Be("aba");
        }

        [Fact]
        public void ShouldReturngeeksskeegWithwegeeksskeegyuwecInput()
        {
            string result = Palindrome.LongestPalindrome("wegeeksskeegyuwe");
            result.Should().Be("geeksskeeg");
        }

        [Fact]
        public void ShouldBeCaseInsensitive()
        {
            string result = Palindrome.LongestPalindrome("MAdam");
            result.Should().Be("MAdam");
        }

        [Fact]
        public void ShoultTreatWhitespaceAsAValidCharacter()
        {
            string result = Palindrome.LongestPalindrome("we geeks skeegyuwe");
            result.Should().Be("geeks skeeg");
        }

        [Fact]
        public void ShouldNotRemoveWhitespace()
        {
            string result = Palindrome.LongestPalindrome("m adam ");
            result.Should().Be("ada");
        }
    }
}
