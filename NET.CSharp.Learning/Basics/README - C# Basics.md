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
