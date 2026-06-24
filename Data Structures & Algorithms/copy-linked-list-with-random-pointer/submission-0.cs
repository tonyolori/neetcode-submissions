/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {

        Node curr = head;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();

        if(curr == null){
            return null;
        }

        while(curr != null){
            map[curr] = new Node(curr.val);
            curr = curr.next;
        }

        //map the next values
        curr = head;
        while(curr!= null){
            map[curr].next = curr.next == null? null : map[curr.next];
            map[curr].random = curr.random == null ? null : map[curr.random];
            curr = curr.next;
        }

        return map[head];
        
    }
}
