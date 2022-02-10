namespace Sandbox
{
    public class ReverseLinkedList
    {
        //#LinkedList
        public ListNode ReverseList(ListNode head) {
        
            ListNode current = head;
            ListNode previous = null;

            while (current != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            return previous;
        }
    }
}