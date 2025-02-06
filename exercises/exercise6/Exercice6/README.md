# 🙇 Exercice 6 ~ 10 minutes

[🇬🇧 English version available here](./README-en.md)

## 💪 Challenge

Écrivez deux classes, `Person` et `Student`, pour modéliser les relations simples entre des personnes et leurs cours.

- La classe `Person` doit avoir deux attributs : `firstName` et `lastName`, et une méthode `GetFullName()` qui retourne le nom complet.
- La classe `Student` doit hériter de `Person` et ajouter un nouvel attribut `course`. La classe doit aussi implémenter une méthode `GetDetails()` qui retourne une chaîne de caractères contenant le nom complet de l'étudiant et le cours auquel il est inscrit.

### Exemple

```csharp
Student student = new Student("John", "Doe", "Math");
student.GetFullName(); // Retourne "John Doe"
student.GetDetails();  // Retourne "John Doe is enrolled in Math"
```

### Input

- Tout d'abord, implémentez la classe `Person`.
- Ensuite, implémentez la classe `Student` qui hérite de `Person`.

### Output

- Pour `Person`, la méthode `GetFullName()` doit retourner une chaîne de caractères avec le nom complet.
- Pour `Student`, la méthode `GetDetails()` doit retourner une chaîne de caractères avec le nom de l'étudiant et son cours.

### Contraintes

- Les prénoms et noms de famille seront toujours des chaînes non vides.
- Le cours sera toujours une chaîne valide.

```csharp
Student student = new Student("Jane", "Smith", "Science");
student.GetFullName(); // Retourne "Jane Smith"
student.GetDetails();  // Retourne "Jane Smith is enrolled in Science"
```
