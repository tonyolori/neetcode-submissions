public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else {
                // If stack is empty, no matching opener
                if (stack.Count == 0) {
                    return false;
                }
                char top = stack.Pop();

                // Check matching pairs
                if ((c == ')' && top != '(') || (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}