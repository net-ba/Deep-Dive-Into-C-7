## Deconstruction

---

### Deconstucting tuples

```csharp
var fero = (name: "Fero", age: 42);
(var name, var age) = fero;
Assert.AreEqual("Fero", name);
Assert.AreEqual(42, age);
```

---

### Using discards

```csharp
var fero = (name: "Fero", age: 42);
(var name,  _) = fero;
Assert.AreEqual("Fero", name);
```

---

### Implementing custom deconstruction

```csharp
public void Deconstruct(out string name, out int age)
{
    name = Name;
    age = Age;
}

var fero = new Person(name: "Fero", age: 42);
(var name, var age) = fero;
Assert.AreEqual("Fero", name);
Assert.AreEqual(42, age);
```

---

### Implementing deconstruction with extension method

```csharp
public void Deconstruct(this Person, out string name, out int age)
{
    name = Name;
    age = Age;
}

var fero = new Person(name: "Fero", age: 42);
(var name, var age) = fero;
Assert.AreEqual("Fero", name);
Assert.AreEqual(42, age);
```


