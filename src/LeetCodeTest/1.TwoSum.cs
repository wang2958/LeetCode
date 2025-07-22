namespace LeetCodeConsole
{ 
    public class _1_TwoSum
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };
            int[] result = TwoSum(nums, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };
            int[] result = TwoSum(nums, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };
            int[] result = TwoSum(nums, target);
            Assert.Equal(expected, result);
        }
         
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                numDict[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
