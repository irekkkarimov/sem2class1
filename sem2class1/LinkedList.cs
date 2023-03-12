using System.Collections;

namespace sem2class1;


public class Node<T>
{
    public T Value { get; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}


public class MyLinkedList<T> : IEnumerable<Node<T>>
{
    public Node<T> Head;
    public Node<T> Tail;

    public MyLinkedList()
    {
        Head = null;
        Tail = Head;
    }

    public void AddFirst(T value)
    {
        if (Head == null)
        {
            Head = new Node<T>(value);
            Tail = Head;
        }
        else
        {
            var temp = new Node<T>(value);
            temp.Next = Head;
            Head = temp;
        }
    }

    public void AddLast(T value)
    {
        if (Head == null) AddFirst(value);
        Tail.Next = new Node<T>(value);
        Tail = Tail.Next;
    }

    public void AddAfter(Node<T> node, T value)
    {
        var temp = new Node<T>(value);
        temp.Next = node.Next;
        node.Next = temp;
    }

    public Node<T> RemoveFirst()
    {
        if (Head == null)
        {
        }

        Node<T> result = Head;
        Head = Head.Next;
        return result;
    }

    public Node<T> RemoveAfter(Node<T> node)
    {
        Node<T> result;
        if (node == Tail) return null;

        if (node.Next == Tail)
        {
            result = Tail;
            Tail = node;
            return result;
        }
        result = node.Next;
        node = node.Next.Next;
        return result;
    }








    public bool IsEmpty => (Head == null);
    public IEnumerator<Node<T>> GetEnumerator()
    {
        if (IsEmpty)
        {
            yield break;
        }
        var current = Head;
        while (current.Next != null)
        {
            yield return current;
            current = current.Next;
        }

        yield return current;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}