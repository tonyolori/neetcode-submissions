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
    public bool HasCycle(ListNode head) {
        ListNode slowPointer = head;
        ListNode fastPointer = head?.next;

        while(fastPointer!= null){

            if(fastPointer == slowPointer){
                return true;
            }
            slowPointer = slowPointer.next;
            fastPointer = fastPointer?.next; 
            fastPointer = fastPointer?.next;
        }

        return false;
    }
}