# Data Types and Variables

[Codecademy lesson content](https://www.codecademy.com/courses/learn-c-sharp/lessons/csharp-data-types-variables/exercises/introduction-to-data-types-and-variables-csharp)

When coding we’re telling the computer how to process pieces of information.

Csharp is strongly-type and *statically-typed*, meaning it will check the correct types are used *before* the program runs.

These two features allow for scalable code with fewer bugs.

Data types tell us:
- How to store data
- What operations can be performed
- Different methods it can used with

## Data types

- `int` integer
- `long` larger whole numbers (more range)
- `float`
- `double` double precision (more accurate) FP numbers -- used more often than `float`
- `decimal` Monetary values

- `string`
- `char` single character

- `bool`
- `DateTime`

## Functions

`capitalize`: turn lower case characters to upper case

`square`: square a number

`evaluate`: determine if an input is true or false

## Creating Variables with Types

Everytime a variable is defined its data type of the data it holds must also be defined.

There are two methods.

**On two lines:**
```csharp
// Declare and integer
int mAge;
myAge = 25
```
Or a more concise **one line:**

```csharp
// Declare a string
string countryName = "Scotland";
```

For example:

```csharp
int evenNumber = 22;
int oddNumber = 45;
Console.WriteLine(evenNumber + oddNumber); // Prints 67
Console.WriteLine(oddNumber - evenNumber); // Prints 23
```

## Handling Errors

If you forget to define the data type when declaring a variable, Csharp will raise an error. For example:
```csharp
"The name 'randomData' does not exist in the current context [CS0103:] "
```

Using the wrong type, raises and error:
```csharp
"Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)"
```

It's good pratise to use **camelCase** styling when defining variables, and shold only contain:
- underscores
- letters
- digits
```csharp
string iAmAVariable;
string i'mnot; // this will cause errors
```
Reserved keywords cannot be used, because they already have specific definitions.

Don't forge to end each statement with a semicolon `;`.
