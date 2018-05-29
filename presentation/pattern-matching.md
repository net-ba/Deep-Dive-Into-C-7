## Pattern matching

---

### Pattern matching definition


Test that a value has a certain "shape" and extract information when it does.


---

### Supported patterns

- Type pattern
- Constant pattern	
- null pattern
- var pattern

---

### Type pattern

```csharp
// C# 6	
if (objectToTest is int)
{
    var i = (int) objectToTest;
    // do something with i
}

// C# 7
if (objectToTest is int j)
{
    // do something with j
}
```

---

### Constant pattern

```csharp
// C# 6
if (objectToTest is int)
{
    var i = (int) objectToTest;
    if (i == constant)
    {
        // do something
    }
}

// C# 7
if (objectToTest is int j && j == constant)
{
    // do something
}
```

---

### Constant pattern

```csharp
// C# 7 - it is possible to check for constant values
if (objectToTest is 5)
{
    // do something
}


// C# 7 - it is possible to check for constant values
private const int myConstantValue = 5;
if (objectToTest is myConstantValue )
{
    // do something
}

```

---

### Constant pattern

```csharp
// C# 6
var myClass = objectToTest as MyClass;
if (myClass != null && myClass.MyInt == constant)
{
    // do something
}

// C# 7
if (objectToTest is MyClass mc && mc.MyInt == constant)
{
    // do something
}

```

---

### null pattern

```csharp
// C# 7
if (objectToTest is null)
{
    // do something
}

```

---

### Switch patterns

```csharp
switch (objectToTest)
{
	// Constant pattern
    case 777:
        Console.WriteLine($"Found an int 777");
        break;

	// Type pattern with constant pattern
    case int i when i == 42:
        Console.WriteLine($"Found an int 42 {i}");
        break;
	

```

---

### Switch patterns

```csharp
	// Type pattern
    case int i:
        Console.WriteLine($"Found an int {i}");
        break;

    case 2d:
        Console.WriteLine($"Found a double 2d");
        break;
	
```

---

### Switch patterns

```csharp
	// null pattern
    case null:
        Console.WriteLine($"Found a null");
        break;    

    case Point p when p.X == 0 && p.Y == 0:
        Console.WriteLine($"Found the origin");
        break;
```

---

### Switch patterns

```csharp
	// var pattern
    case var o:
        Console.WriteLine($"Tested object is {o.GetType()}");
        break;

    default:
        Console.WriteLine($"Cannot tell");
        break;
}
```

