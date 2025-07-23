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

        /// <summary>
        /// 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns> 
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
