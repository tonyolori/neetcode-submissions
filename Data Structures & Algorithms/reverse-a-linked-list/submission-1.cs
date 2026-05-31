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
    public ListNode ReverseList(ListNode head) {

        if(head == null){
            return null;
        }

        Stack<int> values = new Stack<int>();
        ListNode curr = head;

        while(curr != null){
            values.Push(curr.val);
            curr = curr.next;
        };

        ListNode result = new ListNode(values.Pop());
        ListNode tail = result;

        while(values.Count >0){
            tail.next = new ListNode(values.Pop());
            tail = tail.next;

        }

        return result;
    }
}
