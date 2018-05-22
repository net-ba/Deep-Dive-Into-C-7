## Out Variables

---

### C# 6 and prior

```csharp
public bool Convert(string str, out int i)
{
    return int.TryParse(str, out i);
}

public void Using_out_CSharp6()
{
    int i;
    var res = Convert("123", out i);

    Assert.IsTrue(res);
    Assert.AreEqual(123, i);
}
```

---

### New in C# 7.0

```csharp
public void Using_out_CSharp7_with_explicit_type_declaration()
{    
    var res = Convert("123", out int i);
    Assert.IsTrue(res);
    Assert.AreEqual(123, i);
}

public void Using_out_CSharp7_with_var()
{
    var res = Convert("abc", out var i);
    Assert.IsFalse(res);
    Assert.AreEqual(0, i);
}
```