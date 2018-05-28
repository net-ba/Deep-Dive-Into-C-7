## ValueTuple

---

### Since C# 3 we have `System.Tuple`

```csharp
public Tuple<string, int> GetPerson()
{
    return new Tuple<string, int>("Fero", 22);
}

public void Print()
{
    var person = GetPerson();
    Console.Write($"Name:{person.Item1}; Age:{person.Item2}");
}
```

---

### C# 7.0 introduced `System.ValueTuple`

```csharp
public (string, int) GetPerson()
{
    return ("Fero", 22);
}

public void Print()
{
    var person = GetPerson();                
    Console.Write($"Name:{person.Item1}; Age:{person.Item2}");
}
```

---

### ... and you can give proper names to ItemX

```csharp
public (string name, int age) GetPerson()
{
    return (name: "Fero", age: 22);
}

public void Print()
{                
    var person = GetPerson();
    Console.Write($"Name:{person.name}; Age:{person.age}");
}
```

---

### System.ValueTuple vs System.Tuple

 * System.Tuple is reference type
 * ValueTuple is value type
 * System.Tuple is immutable
 * ValueTuple is mutable

 --- 

### ValueTuple vs Anonymous types

 * Anonymous types are generated classes
 * Anonymous are immutable
 * You can't return anonymous types from method ⃰
