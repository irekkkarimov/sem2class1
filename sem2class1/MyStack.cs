using System.Collections;

namespace sem2class1;

public class MyStack<T> where T : IComparable
{
    private T[] _stack;
    private List<T> maximums;
    private int _counter = -1;
    
    public MyStack(int maxSize)
    {
        _stack = new T[maxSize];
        maximums = new List<T>();
    }
    
    public void Push(T value)
    {
        if (_counter == (_stack.Count() - 1)) throw new ArgumentException("The stack is full");
        _stack[_counter + 1] = value;
        if (!IsEmpty())
        {
            T tempMax = value.CompareTo(maximums[_counter]) != 1 ? maximums[_counter] : value;
            maximums.Add(tempMax);
        }
        else
        {
            maximums.Add(value);
        }

        _counter++;
    }

    public T Pop()
    {
        if (_counter == -1) throw new ArgumentException("The stack is empty");
        var res = _stack[_counter];
        maximums.RemoveAt(maximums.Count - 1);
        _counter--;
        return res;
    }

    public bool IsEmpty()
    {
        return _counter == -1;
    }

    public void Clear()
    {
        _counter = -1;
    }

    public int Count()
    {
        return _counter + 1;
    }

    public T GetMax()
    {
        if (maximums.Any())
            return maximums[^1];
        throw new ArgumentException("The stack is empty");
    }
}