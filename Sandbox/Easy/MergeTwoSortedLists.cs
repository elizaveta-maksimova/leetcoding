using System;

namespace Sandbox
{
    public class MergeTwoSortedLists
    {
        // You are given the heads of two sorted linked lists list1 and list2.
        // Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
        // Return the head of the merged linked list.

        // #LinkedList
        public static void Execute()
        {
            ListNode list14 = new ListNode(4, null);
            ListNode list12 = new ListNode(2, list14);
            ListNode list1 = new ListNode(1, list12);

            ListNode list24 = new ListNode(4, null);
            ListNode list32 = new ListNode(3, list24);
            ListNode list2 = new ListNode(1, list32);

            Console.WriteLine(Execute(list1, list2));
        }

        public static ListNode Execute(ListNode list1, ListNode list2)
        {
            ListNode finalTemp = new ListNode();
            ListNode final = finalTemp;

            int i = 0;

            if (list1 == null)
            {
                return list2;
            }
            
            if (list2 == null)
            {
                return list1;
            }

            do
            {
                if (list1.Val < list2.Val)
                {
                    final.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    final.Next = list2;
                    list2 = list2.Next;
                }

                final = final.Next;
                i++;
            } while (list1 != null && list2 != null);

            final.Next = list1 ?? list2;

            return finalTemp.Next;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
}