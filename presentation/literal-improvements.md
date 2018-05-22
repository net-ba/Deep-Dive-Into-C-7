## Numeric literal syntax improvements

---

### Binary literals

```csharp
Assert.AreEqual(42, 0b101010);      
```
---

### Digit separators

```csharp
Assert.AreEqual(10000000, 10_000_000); 
Assert.AreEqual(42, 0b_0010_1010);     
Assert.AreEqual(42, 0x__2A);
Assert.AreEqual(42F, 42D, delta : 0.000_001D);
```