using System.Numerics;

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
            var result = FindMedianSortedArrays(nums1, nums2);
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
        /// Input: nums1 = [], nums2 = [1]
        /// Output: 1.00000
        /// </summary>
        [Fact]
        public void Test3()
        {
            int[] nums1 = [], nums2 = [1];
            var expected = 1;
            var result = FindMedianSortedArrays(nums1, nums2);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// TODO: 待优化
        /// 给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。
        /// 算法的时间复杂度应该为 O(log (m+n)) 。
        /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        /// The overall run time complexity should be O(log (m+n)).
        /// </summary> 
        /// <returns></returns> 
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var maxLength = nums1.Length + nums2.Length;
            var maxMedianIndex = (int)Math.Ceiling(maxLength / 2.0);

            var nums1Index = 0;
            var nums2Index = 0;
            var newIndex = 0;
            var newArray = new int[maxLength];

            while (newIndex <= maxLength - 1)
            {
                if (nums1Index > nums1.Length - 1)
                {
                    newArray[newIndex] = nums2[nums2Index];
                    nums2Index++;
                }
                else if (nums2Index > nums2.Length - 1)
                {
                    newArray[newIndex] = nums1[nums1Index];
                    nums1Index++;
                }
                else
                {
                    var currentNum1 = nums1[nums1Index];
                    var currentNum2 = nums2[nums2Index];

                    if (currentNum1 <= currentNum2)
                    {
                        newArray[newIndex] = currentNum1;
                        nums1Index++;
                    }
                    else
                    {
                        newArray[newIndex] = currentNum2;
                        nums2Index++;
                    }
                }

                newIndex++;
            }

            var isfu = maxLength % 2 == 0;
            if (isfu)
            {
                return (newArray[maxLength / 2 - 1] + newArray[maxLength / 2]) / 2.0;
            }
            else
            {
                return newArray[maxLength / 2];
            }
        }
    }
}
