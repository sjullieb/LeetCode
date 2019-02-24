/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
    Dictionary<ListNode, bool> hashTable = new Dictionary<ListNode, bool>{};
    ListNode ln1 = headA;
   // int indexCounter = 0;
    while (ln1 != null)
    {
        hashTable.Add(ln1, true);
       // indexCounter++;
        ln1 = ln1.next;
    }
    
    bool found = false;
    ln1 = headB;
    //indexCounter = 0;
    while (ln1 != null)
    {
        if (hashTable.ContainsKey(ln1))
        {
            found = true;
            break;
        }    
        else
        {
            //indexCounter++;
            ln1 = ln1.next;
        }
    }
    if (found == true)
    {
        return ln1;
    }
    return null;
}
}