# .NET Katas augmenté par votre assistant :robot:

[🇬🇧 English version available here](./README-en.md)

Bienvenue dans le dépôt .NET Katas ! Ce projet comprend plusieurs Katas qui vous aideront à pratiquer des compétences algorithmiques en .NET. Chaque Kata est stocké dans un dossier dédié [`Exercice1`](./Exercice1/), [`Exercice2`](./Exercice2/), etc..
Votre tâche est d'écrire l'algorithme d'une fonction résolvant les test présents dans les dossiers `.Tests`. 

N'oubliez pas votre assistant d'IA générative doit vous aider à résoudre ces challenges

## 🖊️ Comment utiliser ce dépôt

### 🐾 Guide étape par étape

1. **Cloner le dépôt :**
Clonez ce dépôt sur votre machine locale :
```bash
git clone <url-du-dépôt-final>
cd <nom-du-dépôt>
```

2. **Installer les dépendances :**
Les exercices utilisent `dotnet`. Exécutez la commande suivante pour vous assurer que l'outil est bien installé :
```bash
dotnet --version
```

3. **Résoudre le Kata :**
Ouvrez le fichier correspondant (par ex., [`Exercice1.cs`](./Exercice1/Exercice1.cs) pour le dossier [`Exercice1`](./Exercice1/)) et implémentez la fonction demandée en vous basant sur les consignes énoncées dans le fichier [`README`](./Exercice1/README.md).

4. **Exécuter les tests :**
Une fois que vous avez écrit votre solution, exécutez la suite de tests pour vérifier que votre code fonctionne. Les tests vous guideront étape par étape. À mesure que vous progressez, de plus en plus de tests réussiront. Utilisez la commande suivante pour exécuter les tests correspondant à l'exercice souhaité. Ici par exemple pour l'exercice 1 : 
```bash
dotnet test ./Exercice1.Tests   
```

5. **Déboguer et affiner :**
Si les tests ne passent pas, examinez la sortie des tests et ajustez votre code jusqu'à ce que tous les tests passent. Concentrez-vous sur un exercice à la fois, et travaillez jusqu'à ce que tous les tests soient réussis.

### 👀 Aperçu des Katas
Chaque Kata se concentre sur un aspect différent de JavaScript. Voici les détails de chacun :

#### **1️⃣ BeerSong (Dossier : [`Exercice1`](./Exercice1/)))**
Écrivez un programme qui affiche les paroles de la chanson "99 Bottles of Beer", en partant d'un nombre de bouteilles donné.
- **Fichier à mettre à jour :** [`Exercice1.cs`](./Exercice1/Exercice1.cs)
- **Tests :** [`Exercice1Tests.cs`](./Exercice1.Tests/Exercice1Tests.cs)
- **Compétences :** Boucles, manipulation de chaînes de caractères

#### **2️⃣ SumRange (Dossier : [`Exercice2`](./Exercice2/)))**
Écrivez une méthode TypeScript qui calcule la somme des entiers entre une valeur minimale et une valeur maximale (min et max inclus) en utilisant la récursion. Si la valeur minimale est supérieure à la valeur maximale, la méthode doit renvoyer -1.
- **Fichier à mettre à jour :** [`Exercice2.cs`](./Exercice2/Exercice2.cs)
- **Tests :** [`Exercice2Tests.cs`](./Exercice2.Tests/Exercice2Tests.cs)
- **Compétences :** Récursion, manipulation des entiers, conditions logiques.  

#### **3️⃣ SizeSplitter (Dossier : [`Exercice3`](./Exercice3/)))**
Implémentez une méthode size_splitter qui prend un tableau de mots et un entier représentant une taille. La méthode doit diviser le tableau en deux groupes : le premier contenant les mots de la taille donnée et le second contenant tous les autres mots. Les deux groupes doivent être triés par ordre alphabétique.
- **Fichier à mettre à jour :** [`Exercice3.cs`](./Exercice3/Exercice3.cs)
- **Tests :** [`Exercice3Tests.cs`](./Exercice3.Tests/Exercice3Tests.cs)
- **Compétences :** Manipulation des tableaux, tri, fonctions de filtrage 

#### **4️⃣ DaysUntil (Dossier : [`Exercice4`](./Exercice4/)))**
Écrivez une fonction qui calcule le nombre de jours restants jusqu'à une date future donnée. Si la date est passée, renvoyez `0`.
- **Fichier à mettre à jour :** [`Exercice4.cs`](./Exercice4/Exercice4.cs)
- **Tests :** [`Exercice4Tests.cs`](./Exercice4.Tests/Exercice4Tests.cs)
- **Compétences :** Manipulation des dates et du temps

#### **5️⃣ FindSumPair (Dossier : [`Exercice5`](./Exercice5/)))**
Écrivez une fonction qui renvoie la première paire de nombres dans un tableau dont la somme est égale à une valeur cible. Renvoyez un tableau vide si aucune paire n'est trouvée.
- **Fichier à mettre à jour :** [`Exercice5.cs`](./Exercice5/Exercice5.cs)
- **Tests :** [`Exercice5Tests.cs`](./Exercice5.Tests/Exercice5Tests.cs)
- **Compétences :** Manipulation des tableaux, réflexion algorithmique

#### **6️⃣ Person Formatter basé sur les classes (Dossier : [`Exercice6`](./Exercice6/)))**
Écrivez une classe `Person` qui renvoie un nom complet, et une classe `Student` qui hérite de `Person` pour ajouter un cours et renvoyer les détails de l'étudiant.
- **Fichier à mettre à jour :** [`Exercice6.cs`](./Exercice6/Exercice6.cs)
- **Tests :** [`Exercice6Tests.cs`](./Exercice6.Tests/Exercice6Tests.cs)
- **Compétences :** Programmation orientée objet, classes, héritage

### ⚗️ Exécution des tests
Chaque dossier contient son propre ensemble de tests. Après avoir terminé tous les exercices vous pouvez vérifier tous les exercices d'un coup avec la commande :
```bash
dotnet test 
```
Les tests vous donneront des retours, montrant quels tests passent et quels tests échouent. Continuez à affiner vos solutions jusqu'à ce que tous les tests passent.

### 👁️ Exemple rapide : Kata Beer Song
Voici comment vous aborderiez le premier exercice **BeerSong** :

1. Ouvrez le fichier [`Exercice1.cs`](./Exercice1/Exercice1.cs) et écrivez votre solution.

2. Exécutez les tests pour l'exercice :
```bash
dotnet test ./Exercice1.Tests   
```

3. Modifiez votre solution en fonction des retours des tests jusqu'à ce que tous les tests passent.
