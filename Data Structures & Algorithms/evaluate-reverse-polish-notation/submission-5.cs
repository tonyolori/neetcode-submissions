public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int result = 0;

        for (int i = 0; i < tokens.Length; i++) {
            string token = tokens[i];
            int b, a = 0;

            switch (token) {
                case "+":
                    b = stack.Pop();
                    a = stack.Pop();
                    result = a + b;
                    stack.Push(result);
                    break;
                case "*":
                    b = stack.Pop();
                    a = stack.Pop();
                    result = a * b;
                    stack.Push(result);
                    break;
                case "-":
                    b = stack.Pop();
                    a = stack.Pop();
                    result = a - b;
                    stack.Push(result);
                    break;
                case "/":
                    b = stack.Pop();
                    a = stack.Pop();
                    result = a / b;
                    stack.Push(result);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }
        return stack.Peek();
    }
}
