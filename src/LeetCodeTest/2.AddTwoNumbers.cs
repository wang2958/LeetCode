namespace LeetCodeTest
{
    public class _2_AddTwoNumbers
    {
        /// <summary>
        /// 输入：l1 = [2,4,3], l2 = [5,6,4]
        /// 输出：[7, 0, 8]
        /// </summary>
        [Fact]
        public void Test1()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
            var result = AddTwoNumbers(l1, l2);

            var currentExpected = expected;
            var currentResult = result;
            while (currentExpected != null)
            {
                Assert.Equal(currentExpected.val, currentResult.val);
                currentExpected = currentExpected.next;
                currentResult = currentResult.next;
            }
        }

        /// <summary>
        /// 输入：l1 = [0], l2 = [0]
        /// 输出：[0]
        /// </summary>
        [Fact]
        public void Test2()
        {
            var l1 = new ListNode(0);
            var l2 = new ListNode(0);
            var expected = new ListNode(0);
            var result = AddTwoNumbers(l1, l2);

            var currentExpected = expected;
            var currentResult = result;
            while (currentExpected != null)
            {
                Assert.Equal(currentExpected.val, currentResult.val);
                currentExpected = currentExpected.next;
                currentResult = currentResult.next;
            }
        }

        /// <summary>
        /// 输入：l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        /// 输出：[8, 9, 9, 9, 0, 0, 0, 1]
        /// </summary>
        [Fact]
        public void Test3()
        {
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1)))))))); ;
            var result = AddTwoNumbers(l1, l2);

            var currentExpected = expected;
            var currentResult = result;
            while (currentExpected != null)
            {
                Assert.Equal(currentExpected.val, currentResult.val);
                currentExpected = currentExpected.next;
                currentResult = currentResult.next;
            }
        }

        /// <summary>
        /// 给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
        /// 请你将两个数相加，并以相同形式返回一个表示和的链表。
        /// 你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns> 
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode resultPrv = null;

            var currentl1 = l1;
            var currentl2 = l2;
            var isNextIncrement = false;

            while (currentl1 != null || currentl2 != null)
            {
                var l1Value = currentl1?.val ?? 0;
                var l2Value = currentl2?.val ?? 0;
                var currentValue = l1Value + l2Value + (isNextIncrement ? 1 : 0);

                isNextIncrement = currentValue >= 10;
                currentl1 = currentl1?.next;
                currentl2 = currentl2?.next;

                currentValue = currentValue % 10;
                if (result == null)
                {
                    result = new ListNode(currentValue, null);
                    resultPrv = result;
                }
                else
                {
                    resultPrv.next = new ListNode(currentValue, null);
                    resultPrv = resultPrv.next;
                }
            }

            if (isNextIncrement) resultPrv.next = new ListNode(1);

            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
