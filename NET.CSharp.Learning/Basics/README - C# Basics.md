# Learning C# - Basics
By Rafael Xolio

## Introduction
This section contains topics to learn the basics of C#, I hope this can help others for starting learning.

## Data Types
There are many data types, but for starting level we'll focus on just a few for now:

| Type |  Description  | Example |
|:-----|:--------|------|
| **char**   |used for a single alphanumeric character | 'b' |
| **string**   |  used for words, phrases, or any alphanumeric data for presentation, not calculation  | "Hello" |
| **int**   | used for a whole number | 1 |
| **decimal**   | used for a number with a fractional component | 2.625, 12.3981m |
| **bool**   | used for a true/false value | true |


## Variables
A variable is a container for storing a type of value. Variables are temporary values you store in the computer's memory

```cs
string name;
int count;
```
**Considerations about variable names**

- Can contain alphanumeric characters and the underscore character.
- Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
- Must begin with an alphabetical letter or an underscore, not a number.
- They are case-sensitive, meaning that string Value; and string value; are two different variables.
- Must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.

**Coding recomendations**
- Use camel case convention. For example: ```string myVariable```
- Avoid to use underscore at the beginning.
- Use descriptive names. Avoid contractions or abbreviations.
- Don't include the data type on the name of the variable.

## Implicitly type
An implicitly typed local variable is created by using the var keyword followed by a variable initialization.
The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.

```cs
var message = "Hello world!";
```

## Formatting strings

### Escape character sequences
Use character escape sequences when you need to insert a special character into a literal string.

- \n sequence will add a new line
- \t sequence will add a tab
- \\" for double quotation mark
- \\ when you need to use a backslash in all other scenarios
- @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
- \u plus a four-character code to represent Unicode characters (UTF-16) in a string

```cs
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\test");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```
### Concatenate strings
To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.

```cs
string firstName = "Bob";
string message = "Hello " + firstName;
```
### String interpolation
String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions. 
An interpolation expression is indicated by an opening and closing curly brace symbol { }. You can put any C# expression that returns a value inside the braces. 
The literal string becomes a template when it's prefixed by the $ character.
```cs
string message = $"{greeting} {firstName}!";
```
**Using Verbatim literals**
```cs
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

## Math operations

### BAsic Operations
- **Addition** + is the addition operator
- **Subtraction** - is the subtraction operator
- **Multiplication** * is the multiplication operator
- **Division** / is the division operator

```cs
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
```
### Casting numbers

Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.
To cast you add the cast operator before the value. 

```cs
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
```
### Determine the remainder after integer division
The modulus operator % tells you the remainder of int division. 
What you really learn from this is whether one number is divisible by another. 

```cs
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
```

### Order of operations
You can use the () symbols as the order of operations operators.

In math, PEMDAS is an acronym that helps to remember the order of operations. The order is:

- Parentheses (whatever is inside the parenthesis is performed first)
- Exponents (No operator on C#)
- Multiplication and Division (from left to right)
- Addition and Subtraction (from left to right)

### Increment and Decrement

To increment and/or decrement values, especially when you're writing looping logic or code that interacts with a data structure.

The += operator adds and assigns the value on the right of the operator to the value on the left of the operator
```cs
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
```
The ++ operator increments the value of the variable by 1. So, lines two and three in the following code snippet are the same:
```cs
int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.
```

If you use the operator before the value as in ++value, then the increment will happen before the value is retrieved. Likewise, value++ will increment the value after the value has been retrieved.
```cs
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
```

## Decision Logic
Developers refer to the code that implements different execution paths as code branches.

### If Statement

- The most widely used code branching statement is the if statement.
- The if statement relies on a Boolean expression that is enclosed in a set of parentheses.
- If the expression is true, the code after the if statement is executed. If not, the .NET runtime ignores the code and doesn't execute it.

```cs
if (total > 14)
{
    Console.WriteLine("You win!");
}
```

### What is a Boolean expression?
A Boolean expression is any code that returns a Boolean value, either true or false. 
Other simple Boolean expressions can be created by using operators to compare two values. Operators include:

- ==, the "equals" operator, to test for equality
- >, the "greater than" operator, to test that the value on the left is greater than the value on the right
- <, the "less than" operator, to test that the value on the left is less than the value on the right
- >=, the "greater than or equal to" operator
- <=, the "less than or equal to" operator

### What is a code block?
A code block is a collection of one or more lines of code that are defined by an opening and closing curly brace symbol { }.
