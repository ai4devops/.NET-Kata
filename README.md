## 🍕 Exercise3 ~ 10 minutes

Implement a method `SizeSplitter` that takes two parameters: an array and an integer (size).
We assume that the array contains only words of type String, and the arbitrary rule is to form two groups: the first with words of the given size (second parameter of the method), and the other group with all other words.

The `SizeSplitter` method must return an array of two arrays – the two groups defined above – with the contents sorted in alphabetical order.

Example:

```csharp
SizeSplitter(["dog", "data", "ask", "my", "win", "two", "beer", "as"], 3); // [["ask", "dog", "two", "win"], ["as", "beer", "data", "my"]]
```
