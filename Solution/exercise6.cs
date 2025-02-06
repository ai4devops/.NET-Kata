namespace Exercice6;

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

public class Student : Person
{
    public string Course { get; }

    public Student(string firstName, string lastName, string course)
        : base(firstName, lastName)
    {
        Course = course;
    }

    public string GetDetails()
    {
        return $"{GetFullName()} is enrolled in {Course}";
    }
}
