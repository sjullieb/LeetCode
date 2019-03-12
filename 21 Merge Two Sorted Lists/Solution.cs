/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;
        if (l1.val > l2.val)
        {
            ListNode tmp = l1;
            l1 = l2;
            l2 = tmp;
        }
        ListNode current = dummy;
        while((l1 != null) && (l2 != null))
        {
            current.next = l1;
            current = l1;
            l1 = current.next;
            if((l1 != null) && (l1.val > l2.val))
            {
                ListNode tmp = l1;
                l1 = l2;
                l2 = tmp;
            }
        }
        if(l2 != null)
            current.next = l2;
        return dummy.next;
    }
}