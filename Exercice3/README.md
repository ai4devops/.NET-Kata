## 🍕 Exercice3 ~ 10 minutes

[🇬🇧 English version available here](./README-en.md)

Implémentez une première méthode `SizeSplitter` qui prend deux paramètres : un tableau (array), et un entier (integer) (la taille).
Nous supposerons que le tableau ne contient que des mots de type String, et que la règle arbitraire est de former deux groupes : le premier avec les mots de la taille donnée (deuxième paramètre de la méthode), et l'autre groupe avec tous les autres mots.

La méthode `SizeSplitter` doit renvoyer un tableau de deux tableaux – les deux groupes définis ci-dessus – avec le contenu trié par ordre alphabétique.

Exemple:

```csharp
SizeSplitter(["dog", "data", "ask", "my", "win", "two", "beer", "as"], 3); // [["ask", "dog", "two", "win"], ["as", "beer", "data", "my"]]
```
