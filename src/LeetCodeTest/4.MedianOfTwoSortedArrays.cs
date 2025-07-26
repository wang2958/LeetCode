namespace LeetCodeTest
{
    public class _4_MedianOfTwoSortedArrays
    {
        /// <summary>
        /// Input: nums1 = [1,3], nums2 = [2]
        /// Output: 2.00000
        /// </summary>
        [Fact]
        public void Test1()
        {
            int[] nums1 = [1, 3], nums2 = [2];
            var expected = 2;
            var result =  FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Input: nums1 = [1,2], nums2 = [3,4]
        /// Output: 2.50000
        /// </summary>
        [Fact]
        public void Test2()
        {
            int[] nums1 = [1, 2], nums2 = [3, 4];
            var expected = 2.5;
            var result = FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。
        /// 算法的时间复杂度应该为 O(log (m+n)) 。
        /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        /// The overall run time complexity should be O(log (m+n)).
        /// </summary> 
        /// <returns></returns> 
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            throw new NotImplementedException();
        }
    }
}
