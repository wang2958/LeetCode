namespace LeetCodeTest
{
    public class _5_LongestPalindromicSubstring
    {
        /// <summary>
        /// Input: s = "babad"
        /// Output: "bab"
        /// Note: "aba" is also a valid answer.
        /// </summary>
        [Fact]
        public void Test1()
        {
            string s = "babad";
            var expected = "bab";  // "aba" is also a valid answer
            var result = LongestPalindrome(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Input: s = "cbbd"
        /// Output: "bb"
        /// </summary>
        [Fact]
        public void Test2()
        {
            string s = "cbbd";
            var expected = "bb";
            var result = LongestPalindrome(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 给定一个字符串 s，找到 s 中最长的回文子串。
        /// </summary> 
        /// <returns></returns> 
        public string LongestPalindrome(string s)
        {
            throw new NotImplementedException();
        }
    }
}
