public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val) {
        if (stack.Count == 0) {
            stack.Push(val);
            minStack.Push(val);
        }

        else {
            stack.Push(val);
            minStack.Push(Math.Min(val, minStack.Peek()));
        }
    }

    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
       return minStack.Peek();
    }
}
