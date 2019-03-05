/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        ListNode previous = dummy;
        ListNode first = null;
        ListNode second = null;
        first = previous.next;
        if ((first == null) || first.next == null)
            return dummy.next;
                
        second = first.next;
        
        do
        {
            first.next = second.next;
            second.next = first;
            previous.next = second;
            previous = first;
            first = null;
            second = null;
            if (previous == null || previous.next == null)
                return dummy.next;
            first = previous.next;
        
            if((first == null) || (first.next == null))
                return dummy.next;
            second = first.next;
            
        }
        while((first != null) && (second != null));
        return dummy.next;
    }
}