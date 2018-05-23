## Throw expression

---

```csharp
public class ThrowExpressionExample
{
    public string Throw() 
        => throw new NotImplementedException();

    public double Sqrt(double? num)
    {
        double val = num 
            ?? throw new ArgumentNullException(nameof(num));
        return val >= 0 
            ? Math.Sqrt(val) 
            : throw new ArgumentOutOfRangeException(nameof(num));
    }
}
```