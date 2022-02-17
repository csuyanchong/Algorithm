using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化链表
            ListNode first = new ListNode(-9);
            ListNode second = new ListNode(3);
            //ListNode third = new ListNode(4);
            //LinkNode first = new LinkNode(1);
            //LinkNode second = new LinkNode(2);
            LinkedList list1 = new LinkedList();
            list1.head = first;
            //first.next = second;
            //second.next = third;
            DisplayList(list1.head);

            ListNode f1 = new ListNode(5);
            ListNode f2 = new ListNode(7);
            //ListNode f3 = new ListNode(4);
            //ListNode f4 = new ListNode(5);

            LinkedList list2 = new LinkedList();
            //list2.head = f1;
            //f1.next = f2;
            //f2.next = f3;
            ////f3.next = f4;

            DisplayList(list2.head);


            //ListNode headNew = MergeTwoList(list1.head, list2.head);
            ListNode headNew = MergeTwoListNew(list1.head, list2.head);
            DisplayList(headNew);
            ////1.删除链表倒数第n个节点。
            //list.head = RemoveNthFromEndSolve1(list.head, 1);
            //list.head = RemoveNthFromEndSolve2(list.head, 1);

            //2.反转链表。
            //list.head = ReverseList(list.head);


            //打印链表
            //DisplayList(list.head);
            Console.ReadKey();
        }

        /// <summary>
        /// 删除倒数第N个节点，方法1：先计算链表总长度
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ListNode RemoveNthFromEndSolve1(ListNode head, int n)
        {
            if (head.next == null)
            {
                //只有1个节点
                head = null;
                return head;
            }

            int len = GetLengthOfLinkedList(head);

            if (n == len)
            {
                //如果删除的是头节点
                head = head.next;
            }
            else
            {
                //不是头结点，那么获取上一个节点，然后删除该节点。
                ListNode cur = head;
                int count = 1;

                while (count < len - n)
                {
                    count++;
                    cur = cur.next;
                }
                //cur位于删除的节点的上一个
                cur.next = cur.next.next;
            }
            return head;
        }


        public static ListNode RemoveNthFromEndSolve2(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }

            ListNode fast, slow, cur;
            fast = slow = cur = head;
            while (cur != null)
            {
                cur = cur.next;
                if (n-- > 0)
                {
                    fast = fast.next;
                }

                if (n == 0)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
            }

            slow.next = slow.next.next;
            return head;
        }


        /// <summary>
        /// 链表反转。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head;
            ListNode slow = null;
            ListNode fast = head.next;

            while (cur != null)
            {
                fast = cur.next;
                cur.next = slow;
                slow = cur;
                cur = fast;
            }
            head = slow;
            return head;
        }

        public static ListNode MergeTwoList(ListNode list1, ListNode list2)
        {
            //可以优化为带头结点的链表。
            if (list1 == null && list2 == null)
            {
                return null;
            }

            ListNode cur1, cur2, curNew, headNew, fast1, fast2;
            cur1 = list1;
            cur2 = list2;
            curNew = headNew = null;
            while (cur1 != null && cur2 != null)
            {
                fast1 = cur1.next;
                fast2 = cur2.next;
                if (cur1.val < cur2.val)
                {
                    if (curNew == null)
                    {
                        headNew = curNew = cur1;
                    }
                    else
                    {
                        curNew.next = cur1;
                        curNew = curNew.next;
                    }
                    cur1 = fast1;
                }
                else if (cur1.val == cur2.val)
                {
                    if (curNew == null)
                    {
                        headNew = curNew = cur1;
                        curNew.next = cur2;
                    }
                    else
                    {
                        curNew.next = cur1;
                        curNew.next.next = cur2;
                    }
                    curNew = cur2;
                    cur1 = fast1;
                    cur2 = fast2;
                }
                else
                {
                    if (curNew == null)
                    {
                        headNew = curNew = cur2;
                    }
                    else
                    {
                        curNew.next = cur2;
                        curNew = curNew.next;
                    }
                    cur2 = fast2;
                }
            }

            while (cur1 != null)
            {
                if (curNew == null)
                {
                    headNew = curNew = cur1;
                }
                else
                {
                    curNew.next = cur1;
                    curNew = curNew.next;
                }
                cur1 = cur1.next;
            }

            while (cur2 != null)
            {
                if (curNew == null)
                {
                    headNew = curNew = cur2;
                }
                else
                {
                    curNew.next = cur2;
                    curNew = curNew.next;
                }
                cur2 = cur2.next;
            }

            return headNew;
        }


        public static ListNode MergeTwoListNew(ListNode list1, ListNode list2)
        {
            ListNode headNew = new ListNode(0);
            ListNode cur1 = list1;
            ListNode cur2 = list2;
            ListNode curNew = headNew;

            while (cur1 != null && cur2 != null)
            {
                if (cur1.val <= cur2.val)
                {
                    curNew.next = cur1;
                    cur1 = cur1.next;
                }
                else
                {
                    curNew.next = cur2;
                    cur2 = cur2.next;
                }
                curNew = curNew.next;
            }

            while (cur1 != null)
            {
                curNew.next = cur1;
                cur1 = cur1.next;
                curNew = curNew.next;
            }

            while (cur2 != null)
            {
                curNew.next = cur2;
                cur2 = cur2.next;
                curNew = curNew.next;
            }
            return headNew.next;

        }
        /// <summary>
        /// 获取链表长度
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int GetLengthOfLinkedList(ListNode head)
        {
            int n = 0;
            while (head != null)
            {
                n++;
                head = head.next;
            }
            return n;
        }
        public static void DisplayList(ListNode head)
        {
            Console.WriteLine("******* 打印链表 *******");
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
        public class LinkedList
        {
            public ListNode head;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int data)
            {
                val = data;
                next = null;
            }
        }
    }
}
