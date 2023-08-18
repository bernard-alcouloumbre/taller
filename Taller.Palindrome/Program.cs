using Taller.Palindrome;

if(args.Length > 0)
{
    string sentence = args[0];
    string longestPalindrome = Palindrome.LongestPalindrome(sentence);
    Console.WriteLine(longestPalindrome);
    Console.ReadLine();
}