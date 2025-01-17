# Exercise 6 -  Person Formatter 👤 ~ 10 minutes

[🇫🇷 Version française disponible ici](./README.md)

Create two classes, `Person` and `Student`, to model basic relationships between individuals and their enrolled courses.

## Challenge

1. **Person Class**:
    - Attributes: `firstName` and `lastName`
    - Method: `GetFullName` that returns the person's full name as `"FirstName LastName"`

2. **Student Class**:
    - Inherits from `Person`
    - Additional Attribute: `course`
    - Method: `GetDetails` that returns a string in the format `"FirstName LastName is enrolled in CourseName"`

## Example Usage

```csharp
Student student = new Student("John", "Doe", "Math");
student.GetFullName(); // Output: "John Doe"
student.GetDetails();  // Output: "John Doe is enrolled in Math"
```

## 📝 Guidelines
1. Implement the Person class:

   - Define the `GetFullName` method to return a string containing the full name.
2. Implement the Student class:

   - Ensure it inherits from Person.
   - Define the `GetDetails` method to return the student's full name along with their course.
   
3. After implementing the classes, run tests to verify your code.
   
### Input
- First, implement the `Person` class.
- Then, implement the `Student` class that inherits from Person. 
### Output
- For `Person`, the method `GetFullName` should return a string with the full name.
- For `Student`, the method `GetDetails` should return a string with the student's name and their course.

### Constraints
- First and last names will always be non-empty strings.
- The course will always be a valid string.
