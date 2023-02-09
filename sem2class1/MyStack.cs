using System.Collections;

namespace sem2class1;

public class MyStack
{
    private int[] _stack;
    private int _counter = -1;
    
    public MyStack(int maxSize)
    {
        _stack = new int[maxSize];
    }
    
    public void Push(int number)
    {
        if (_counter == (_stack.Count() - 1)) throw new ArgumentException("The stack is full");
        _stack[_counter + 1] = number;
        _counter++;
    }

    public int Pop()
    {
        if (_counter == -1) throw new ArgumentException("The stack is empty");
        var res = _stack[_counter];
        _counter--;
        return res;
    }

    public bool IsEmpty()
    {
        if (_counter == -1)
            return true;
        return false;
    }

    public void Clear()
    {
        _counter = -1;
        for (int i = 0; i < _stack.Length; i++)
        {
            _stack[i] = 0;
        }
    }

    public int Count()
    {
        return _counter + 1;
    }
}