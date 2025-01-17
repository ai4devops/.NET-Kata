namespace Exercice6.Tests;

public class PersonTests
{
    [Fact]
    public void PersonReturnsFullName()
    {
        var person = new Person("John", "Doe");
        Assert.Equal("John Doe", person.GetFullName());
    }
}

public class StudentTests
{
    [Fact]
    public void StudentReturnsFullDetails()
    {
        var student = new Student("John", "Doe", "Math");
        Assert.Equal("John Doe is enrolled in Math", student.GetDetails());
    }

    [Fact]
    public void StudentInheritsFromPerson()
    {
        var student = new Student("Jane", "Doe", "Science");
        Assert.Equal("Jane Doe", student.GetFullName());
    }
}