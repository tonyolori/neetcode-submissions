public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s){
            if(c == '}' ){
                if(stack.Count == 0 || stack.Pop() != '{')  
                    return false;
            }
            else if(c ==')' ){
                if(stack.Count == 0 || stack.Pop() != '(')  
                    return false;
            }
            else if(c == ']'){
                if(stack.Count == 0 || stack.Pop() != '[')  
                    return false;
            }
            else{
                stack.Push(c);
            }
        }
        if(stack.Count > 0){
            return false;
        }
            return true;
    }
}
