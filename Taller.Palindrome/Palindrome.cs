namespace Taller.Palindrome
{
    public class Palindrome
    {
        public static string LongestPalindrome(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return string.Empty;
            }
                
            if(sentence.Length == 1)
            {
                return sentence;
            }

            string result = GetLongestSubstringPalindrome(sentence);

            return result;
        }

        private static string GetLongestSubstringPalindrome(string sentence)
        {
            int[] answerBounds = new int[] { 0, 0 };
            string lowerSentence = sentence.ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                int oddLength = ExpandAroundCenter(i, i , lowerSentence);
                int evenLength = ExpandAroundCenter(i, i + 1, lowerSentence);

                if (oddLength > answerBounds[1] - answerBounds[0] + 1)
                {
                    int distance = oddLength / 2;
                    answerBounds[0] = i - distance;
                    answerBounds[1] = i + distance;
                }

                if (evenLength > answerBounds[1] - answerBounds[0] + 1)
                {
                    int distance = (evenLength / 2) - 1;
                    answerBounds[0] = i - distance;
                    answerBounds[1] = i + 1 + distance;
                }                
            }

            int start = answerBounds[0];
            int length = answerBounds[1] - answerBounds[0] + 1;

            return sentence.Substring(start, length);
        }

        private static int ExpandAroundCenter(int left, int right, string sentence)
        {
            while (left >= 0 && right < sentence.Length && sentence[left] == sentence[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
