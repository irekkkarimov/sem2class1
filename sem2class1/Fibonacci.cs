using System.Collections;

namespace sem2class1;

public class Fibonacci : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        var currentValue = 1;
        var previousValue = 1;
        yield return 1;
        yield return 1;
        while (true)
        {
            yield return currentValue + previousValue;
            (previousValue, currentValue) = (currentValue, currentValue + previousValue);
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
        
    IEnumerable<int> GetNumbers(int n){
        if (n < 0) throw new ArgumentException("n < 0");
        yield return 0;
        for(int i = 1; i < n; i++)
            if (i % 10000 == 0) break;
            else yield return i;
        yield break;
    }
}