namespace LeetCodeTest
{
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Input: s = "abcabcbb"
        /// Output: 3
        /// </summary>
        [Fact]
        public void Test1()
        {
            var s = "abcabcbb";
            var expected = 3;
            var result = LengthOfLongestSubstring(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Input: s = "bbbbb"
        /// Output: 1
        /// </summary>
        [Fact]
        public void Test2()
        {
            var s = "bbbbb";
            var expected = 1;
            var result = LengthOfLongestSubstring(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Input: s = "pwwkew"
        /// Output: 3
        /// </summary>
        [Fact]
        public void Test3()
        {
            var s = "pwwkew";
            var expected = 3;
            var result = LengthOfLongestSubstring(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Input: s = " "
        /// Output: 0
        /// </summary>
        [Fact]
        public void Test4()
        {
            var s = " ";
            var expected = 1;
            var result = LengthOfLongestSubstring(s);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 给定一个字符串 s，请你找出其中不含有重复字符的 最长 子串 的长度。
        /// Given a string s, find the length of the longest substring without duplicate characters.
        /// </summary> 
        /// <returns></returns> 
        public int LengthOfLongestSubstring(string s)
        {
            var left = 0;
            var right = 0;
            var chatArray = s.ToArray();
            var maxLength = 0;
            while (right < chatArray.Length)
            {
                var target = chatArray[right];
                for (int i = left; i < right; i++)
                {
                    if (target == chatArray[i])
                    {
                        maxLength = Math.Max(maxLength, right - left);
                        left = i + 1;
                    }
                }
                right++;
            }
            return Math.Max(maxLength, right - left);
        }
    }
}
