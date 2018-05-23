## Expression Bodied Members

---

### Available in C# 6.0

```csharp
public partial class Example
{
    public int Getter => 42;                    
    public void Method() => _name = _name.ToUpperInvariant();    
}
```

---

## New in C# 7.0

```csharp
public partial class Example
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public char this[int i] => _name[i];
    public Example(string name) => _name = name;
    ~Example() => _name = null;
}
```
