/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null)
            return head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode first = head;
        while(first.next != null)
        {
            ListNode current = first.next;
            first.next = current.next;
            current.next = dummy.next;
            dummy.next = current;
        }
        return dummy.next;
    }
}