# Exercise 4 - Countdown Timer ⏳ ~ 10 Minutes

Write a program that calculates the number of days remaining until a specified future date.

Your program should accept a single input string representing a future date in the format `YYYY-MM-DD`.

- If the date is in the future, return the number of days remaining.
- If the date has already passed, return `0`.

You need to define the method `DaysUntil(String futureDate)`.

### Example

```csharp
DaysUntil("2030-12-25"); // Returns a positive number depending on the current date
DaysUntil("2023-01-01"); // Returns 0 (past date)
```
