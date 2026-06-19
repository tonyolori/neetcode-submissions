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
        ListNode first = head; 
        ListNode second = new ListNode(0,head);
        int i = 0;

        //first loop to get firsts ahead
        while(first != null && i< n){
            first = first.next;
            i++;
        }
        if(first == null){
            return head.next;
        }
        //move to the end
        while(first != null){
            first = first.next; 
            second = second.next;
        }

        ListNode curr = second.next; 
        ListNode next = curr.next;

        curr.next = null;
        second.next = next; 

        return head;


    }
}
