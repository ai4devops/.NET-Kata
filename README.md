# .NET Katas Enhanced by Your Assistant :robot:

[🇫🇷 Version française disponible ici](./README-fr.md)

Welcome to the .NET Katas repository! This project includes several Katas to help you practice algorithmic skills in .NET. Each Kata is stored in a dedicated folder [`Exercice1`](./Exercice1/), [`Exercice2`](./Exercice2/), etc.
Your task is to write the algorithm for a function that solves the tests present in the `.Tests` folders.

Don't forget, your generative AI assistant is here to help you solve these challenges.

## 🖊️ How to Use This Repository

### 🐾 Step-by-Step Guide

1. **Clone the Repository:**  
Clone this repository to your local machine:
```bash
git clone <final-repository-url>
cd <repository-name>
```

2. **Install Dependencies:**  
The exercises use `dotnet`. Run the following command to ensure the tool is installed:
```bash
dotnet --version
```

3. **Solve the Kata:**  
Open the corresponding file (e.g., [`Exercice1.cs`](./Exercice1/Exercice1.cs) for the folder [`Exercice1`](./Exercice1/)) and implement the requested function based on the instructions outlined in the [`README`](./Exercice1/README.md) file.

4. **Run the Tests:**  
Once you've written your solution, run the test suite to verify that your code works. The tests will guide you step by step. As you progress, more and more tests will pass. Use the following command to run the tests for the desired exercise. Here, for example, for Exercise 1:
```bash
dotnet test ./Exercice1.Tests   
```

5. **Debug and Refine:**  
If the tests fail, examine the test output and adjust your code until all tests pass. Focus on one exercise at a time and work until all tests succeed.

### 👀 Overview of the Katas
Each Kata focuses on a different aspect of .NET. Here are the details for each:

#### **1️⃣ BeerSong (Folder: [`Exercice1`](./Exercice1/))**
Write a program that displays the lyrics of the song "99 Bottles of Beer," starting from a given number of bottles.
- **File to Update:** [`Exercice1.cs`](./Exercice1/Exercice1.cs)
- **Tests:** [`Exercice1Tests.cs`](./Exercice1.Tests/Exercice1Tests.cs)
- **Skills:** Loops, string manipulation

#### **2️⃣ SumRange (Folder: [`Exercice2`](./Exercice2/))**
Write a method that calculates the sum of integers between a minimum and a maximum value (inclusive) using recursion. If the minimum value is greater than the maximum, the method should return -1.
- **File to Update:** [`Exercice2.cs`](./Exercice2/Exercice2.cs)
- **Tests:** [`Exercice2Tests.cs`](./Exercice2.Tests/Exercice2Tests.cs)
- **Skills:** Recursion, integer manipulation, logical conditions

#### **3️⃣ SizeSplitter (Folder: [`Exercice3`](./Exercice3/))**
Implement a method `SizeSplitter` that takes an array of words and an integer representing a size. The method should split the array into two groups: the first containing words of the given size and the second containing all other words. Both groups should be sorted alphabetically.
- **File to Update:** [`Exercice3.cs`](./Exercice3/Exercice3.cs)
- **Tests:** [`Exercice3Tests.cs`](./Exercice3.Tests/Exercice3Tests.cs)
- **Skills:** Array manipulation, sorting, filtering functions

#### **4️⃣ DaysUntil (Folder: [`Exercice4`](./Exercice4/))**
Write a function that calculates the number of days remaining until a given future date. If the date has passed, return `0`.
- **File to Update:** [`Exercice4.cs`](./Exercice4/Exercice4.cs)
- **Tests:** [`Exercice4Tests.cs`](./Exercice4.Tests/Exercice4Tests.cs)
- **Skills:** Date and time manipulation

#### **5️⃣ FindSumPair (Folder: [`Exercice5`](./Exercice5/))**
Write a function that returns the first pair of numbers in an array whose sum equals a target value. Return an empty array if no pair is found.
- **File to Update:** [`Exercice5.cs`](./Exercice5/Exercice5.cs)
- **Tests:** [`Exercice5Tests.cs`](./Exercice5.Tests/Exercice5Tests.cs)
- **Skills:** Array manipulation, algorithmic thinking

#### **6️⃣ Class-Based Person Formatter (Folder: [`Exercice6`](./Exercice6/))**
Write a `Person` class with a `GetFullName` method which returns the person's full name. Write a `Student` class that inherits from `Person` and adds a course and return the student's details with a `GetDetails` method. 
- **File to Update:** [`Exercice6.cs`](./Exercice6/Exercice6.cs)
- **Tests:** [`Exercice6Tests.cs`](./Exercice6.Tests/Exercice6Tests.cs)
- **Skills:** Object-oriented programming, classes, inheritance

### ⚗️ Running Tests
Each folder contains its own set of tests. After completing all exercises, you can verify them all at once with the command:
```bash
dotnet test 
```
The tests will provide feedback showing which tests pass and which fail. Continue refining your solutions until all tests pass.

### 👁️ Quick Example: Beer Song Kata
Here's how you would approach the first exercise, **BeerSong**:

1. Open the file [`Exercice1.cs`](./Exercice1/Exercice1.cs) and write your solution.

2. Run the tests for the exercise:
```bash
dotnet test ./Exercice1.Tests   
```

3. Modify your solution based on test feedback until all tests pass.
