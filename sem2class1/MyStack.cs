using System.Collections;

namespace sem2class1;

public class MyStack<T>
{
    private T[] _stack;
    private int _counter = -1;
    
    public MyStack(int maxSize)
    {
        _stack = new T[maxSize];
    }
    
    public void Push(T value)
    {
        if (_counter == (_stack.Count() - 1)) throw new ArgumentException("The stack is full");
        _stack[_counter + 1] = value;
        _counter++;
    }

    public T Pop()
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
    }

    public int Count()
    {
        return _counter + 1;
    }
}