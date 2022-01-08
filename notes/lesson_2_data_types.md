# Data Types and Variables

[Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/)
[Cheatsheet](https://content.codecademy.com/courses/learn-c-sharp/data-types-variables/C%23%20Data%20Types%20Cheat%20Sheet.pdf)

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

## Converting Data Types

Convert double to int the following won't work!
```csharp
double myDouble = 3.2;
 
// Round myDouble to the nearest whole number
int myInt = myDouble;
```
But you can do the opposite:
```csharp
int myInt = 3;
// Turn it into a decimal
double MyDouble = myInt;
```
**REASON:**  
C# checks to make sure that when we convert data types from one to another that we’re not losing any data, because that could cause problems in our code.

### Implict Conversions
- automatic if no data is lost
- can convert int to double

### Explict Conversion
- cast operator required
- double to int would used `(int)`

To fix the code above:
```csharp
double myDouble = 3.2;
 
// Round myDouble to the nearest whole number
int myInt = (int)myDouble;
```

It is not possible to explicitly convert a `string` into an `int`, or vice versa.

[More info](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number).

### Built-in Methods
It’s also possible to convert data types using built-in methods. For most data types, there is a `Convert.ToX()` method, like `Convert.ToString()` and `Convert.ToDouble()`. For a full list of Convert class built-in methods, check out the [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.7.2).

- `Convert.ToString()`
- `Convert.ToX()`
- `Convert.ToDouble()`
- `Convert.ToInt32()`
