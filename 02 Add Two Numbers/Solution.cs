/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        ListNode node = new ListNode(0);
        ListNode result = node;

        while ((l1 != null) && (l2 != null)){
            int sum = l1.val + l2.val + node.val;
            node.val = sum % 10;

            if((l1.next != null) || (l2.next != null) || (sum/10 == 1))
            {
                ListNode newNode = new ListNode(sum/10);
                node.next = newNode;
                node = newNode;
            }
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 == null)
            l1 = l2;

        while (l1 != null){
            int sum = l1.val + node.val;
            node.val = sum % 10;
            if ((l1.next != null) || (sum/10 != 0))
            {
                ListNode newNode = new ListNode(sum/10);
                node.next = newNode;
                node = newNode;
            }
            l1 = l1.next;
        }

        return result;
    }
}
