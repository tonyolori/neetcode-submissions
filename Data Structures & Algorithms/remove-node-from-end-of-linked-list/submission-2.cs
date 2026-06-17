/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode curr = head;
        ListNode prev= curr;
        int i = 1;
        int length = 1;

        while(curr!=null){
            curr = curr.next;
            length++;
        }
        curr = head;
        int backLength = length-n; 

        while(curr!= null && i<backLength){
            prev = curr;
            curr = curr.next;
            i++;
        }

        if(backLength ==1){
            return head.next;
        }

        ListNode next = curr.next;
        if(next == null){
            prev.next = null;
            return head;
        }
    
        curr.next = null;
        prev.next = next;

        return head;
    }
}
