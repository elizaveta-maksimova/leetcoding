using System;

namespace Sandbox
{
    //#LinkedList
    public class MiddleOfLinkedList
    {
        public static void Execute()
        {
            ListNode list18 = new ListNode(8, null);
            ListNode list16 = new ListNode(6, list18);
            ListNode list14 = new ListNode(4, list16);
            ListNode list12 = new ListNode(2, list14);
            ListNode list1 = new ListNode(1, list12);

            Console.WriteLine(RemoveNthNode(list1, 2).Val);
        }
        
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode current = head;
            ListNode next = head.Next;
            
            while (next != null)
            {
                current = current.Next;
                next = next.Next?.Next;
            }

            return current;
        }
        
        public static ListNode RemoveNthNode(ListNode head, int n)
        {
            ListNode current = head;
            ListNode next = head.Next;

            int i = 1;
            int j = 2;
            
            while (current != null)
            {
                if (next == null || next.Next == null)
                {
                    j -= n;
                }

                if (i == j)
                {
                    
                }
                
                current = current.Next;
                next = next.Next?.Next;

                i++;
                j += 2;
            }

            return current;
        }
    }
}