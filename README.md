# Learning C# from scratch
By Rafael Xolio

## Introduction
This repository contains examples for learning how to coding in C# from scratch.

## Prerequisites
- To have installed Visual Studio 2019 at least or Visual Studio Code.


## Visual Studio Code

### Install Visual Studio Code

1. Download from [code.visualstudio.com](https://code.visualstudio.com/)
2. To install follow instructions from any of next links
   - https://code.visualstudio.com/docs/setup/windows
   - https://learn.microsoft.com/en-us/training/modules/install-configure-visual-studio-code/2-exercise-download-install-visual-studio-code

### Visual Studio Interface
![image](https://github.com/user-attachments/assets/01ebd1e4-c625-44e4-bb6b-da377fc4b17d)

### The .NET SDK and .NET Runtime
.NET is a cross-platform, open-source developer platform that's used to develop different types of applications. 

**.NET Runtime**
- The .NET runtime is the code library that's required to run your C# applications.
- .NET runtime referred to as the Common Language Runtime, or CLR.
- The .NET runtime isn't required to write your C# code, but it's required to actually run your C# applications.

**.NET SDK**
- Visual Studio Code uses the .NET SDK and C# extensions to provide a development environment for writing, running, and debugging C# applications.

### Extensions
- Extensions are add-ons that provide additional functionality to Visual Studio Code.
- There are language extensions, theme extensions, and extensions that add new features to Visual Studio Code.
- Visual Studio Code supports the development of C# applications using C# language extensions and the .NET Software Development Kit (SDK).

#### Install C# Extension
To install the C# Dev Kit extension for Visual Studio Code, complete the following steps:

1. On the Activity bar, select Extensions.
2. In the Search Extensions in Marketplace textbox, enter C#. Entering "C#" filters the list of extensions to show only the extensions that have something to do with C# coding.
3. In the filtered list of available extensions, select the extension labeled "C# Dev Kit - Official C# extension from Microsoft" published by Microsoft.
   
   ![image](https://github.com/user-attachments/assets/faca9844-285c-4a45-a127-7960277d32d7)

5. Select Install.
6. Notice that installing the C# Dev Kit installs the following extensions:
   - .NET Install Tool. This extension installs and manages different versions of the .NET SDK and Runtime.
   - C# - Base language support for C#.
   - C# Dev Kit - Official C# extension from Microsof

### Install IntelliCode for C#

1. On the Activity bar, select Extensions.
2. In the Search Extensions in Marketplace textbox, enter IntelliCode for C#
3. In the filtered list of available extensions, select the extension labeled IntelliCode for C# Dev Kit - AI-assisted development for C# Dev Kit published by Microsoft.
   
![image](https://github.com/user-attachments/assets/2d562b95-23ac-44a2-b751-6ebee8f98dd9)

5. Select Install.
### Verify Dotnet version

1. Open a new Terminal
2. Run command dotnet --version

## Create your first console application

1. Run command ```dotnet new console -o path/projectname```
![image](https://github.com/user-attachments/assets/aa991c31-70e5-4d9a-8eef-2631cc2db8aa)

2. Implemente changes and save.
3. Build project ```$dotnet build```
4. Run the project ```$dotnet run```

## .NET Class Library
- Which of the following tools is required to run command line interface commands such as dotnet run?
- C# data types (such as string and int) are actually made available through classes in the .NET Class Library.

## Stateful versus stateless methods
- Stateless methods are implemented so that they can work without referencing or changing any values already stored in memory. Stateless methods are also known as static methods.
- Stateful (instance) methods keep track of their state in fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.
- However, when you need to call stateful methods, you must first create an instance of the class so that the method can access state.

## Methods
- Methods might accept no parameters or multiple parameters, depending on how they were designed and implemented. When passing in multiple parameters, separate them with a , symbol.
- Method parameters are variables used inside the method. The method definition specifies the names and types of any parameters that are required. When a caller invokes the method, the calling statement provides concrete values, called arguments, for each parameter.
- Methods might return a value when they complete their task, or they might return nothing (void).
- Overloaded methods support several implementations of the method, each with a unique method signature (the number of parameters and the data type of each parameter).
- IntelliSense can help write code more quickly. It provides a quick reference to methods, their return values, their overloaded versions, and the types of their parameters.
- learn.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work.

## Array
- C# arrays allow you to store sequences of values in a single data structure.
- Arrays can be used to store multiple values of the same type in a single variable.
- In other words, imagine a single variable that can hold many values. Once you have a single variable that stores all the values, you can sort the values, reverse the order of the values, loop through each value and inspect it individually, and so on.
- An array is a sequence of individual data elements accessible through a single variable name.
- You use a zero-based numeric index to access each element of an array.

### Declaring arrays

```cs
   string[] orderIDs = new string[3];

   orderIDs[0] = "A123";
   orderIDs[1] = "B456";
   orderIDs[2] = "C789";
   // orderIDs[3] = "D000";

   Console.WriteLine($"First: {orderIDs[0]}");
   Console.WriteLine($"Second: {orderIDs[1]}");
   Console.WriteLine($"Third: {orderIDs[2]}");

   orderIDs[0] = "F000";

   Console.WriteLine($"Reassign First: {orderIDs[0]}");
```
### Initialize an array

```c
   string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
```
### Lenght of an array
```cs
   string[] orderIDs = { "A001", "B002", "C003" };

   Console.WriteLine($"Lenght: {orderIDs.Length}");
```

### Looping arrays

- Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
- The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
- Use the ++ increment operator to add 1 to the current value of a variable.

```cs
   int[] inventory = { 200, 450, 700, 175, 250 };
   int sum = 0;
   int bin = 0;
   foreach (int items in inventory)
   {
       sum += items;
       bin++;
       Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
   }
   Console.WriteLine($"We have {sum} items in inventory.");
```
## Variables

### Variable name rules
There are some variable naming rules that are enforced by the C# compiler.

- Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
- Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields.
- Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
- Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

### Variable name conventions

- Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example: string thisIsCamelCase;.
- Variable names should be descriptive and meaningful in your application. 
- Variable names should be one or more entire words appended together. 
- Variable names shouldn't include the data type of the variable.

## Comments

- Use code comments to leave meaningful notes to yourself about the problem your code solves.
- Don't use code comments that explain how C# or the .NET Class Library works.
- Use code comments when temporarily trying alternative solutions until you're ready to commit to the new code solution, at which point you can delete the old code.
- Never trust comments. They may not reflect the current state of the code after many changes and updates.

```cs

// Loop through each blank orderID

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

```

## Decision Logic

Decision logic is used to establish alternative pathways through your code, where the decision about which path to follow is based on the evaluation of an expression.

### What is an expression?
An expression is any combination of values (literal or variable), operators, and methods that return a single value. A statement is a complete instruction in C#, and statements are comprised of one or more expressions.
```cs
if (myName == "Luiz")

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
```

### Evaluating equality and inequality
- When checking for equality, you'll locate the equality operator == between the two values being checked. If the values on either side of the equality operator are equivalent, then the expression will return true. Otherwise, it will return false.
- To check for inequality, you'll use the inequality operator != between the two values.

### Evaluating comparisons
When working with numeric data types, you might want to determine if a value is larger or smaller than another value. Use the following operators to perform these types of comparisons:

- Equal ==
- Inequal !=
- Greater than >
- Less than <
- Greater than or equal to >=
- Less than or equal to <=

### What is logical negation?
- The term "Logical Negation" refers to the unary negation operator !.
- Some people call this operator the "not operator".
- When you place the ! operator before a conditional expression (or any code that's evaluated to either true or false), it forces your code to reverse its evaluation of the operand.
- When logical negation is applied, the evaluation produces true , if the operand evaluates to false , and false , if the operand evaluates to true.
- Use the logical negation operator ! to evaluate the opposite of a given expression.
- Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.

```cs
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
```

### What is the conditional operator?
- The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false.
- The conditional operator is commonly referred to as the **ternary conditional operator**.
- You can use the conditional operator to reduce the size of your code, but you should ensure that the resulting code is easily readable.
- You can use the conditional operator when you need to return a value that's based on a binary condition. Your code will return the first option when the condition evaluates to true, and it will return the second option when the condition evaluates to false.

```cs
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
```

## Code blocks and variable scope
- When you declare a variable inside a code block, its visibility is local to that code block and that variable cannot be accessed outside of the code block.
- To ensure that a variable is visible both inside and outside of a code block, you must declare the variable prior to the code block (outside and above the code block).
- Ensure that variables are initialized before your code attempts to access them (for all potential code execution paths).

### Code Block
- A code block is one or more C# statements that define an execution path.
- The statements outside of a code block affect when, if, and how often that block of code is executed at run time.
- The boundaries of a code block are typically defined by squiggly braces, {}.

### Variable scope 
- Refers to a variable's visibility to the other code in your application.
- A locally scoped variable is only accessible inside of the code block in which it's defined.
- If you attempt to access the variable outside of the code block, you'll get a compiler error.

```cs
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");
```

## Readability of single-line form if statements
When implementing an if statement that includes a single-statement code block, Microsoft recommends that you consider these conventions:
- Never use single-line form (for example: if (flag) Console.WriteLine(flag);
- Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single statement body spans multiple lines.
- Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.
- If you realize you have only one line of code listed within the code blocks of an if-elseif-else statement, you can remove the curly braces of the code block and white space.
- Microsoft recommends that curly braces be used consistently for all of the code blocks of an if-elseif-else statement (either present or removed consistently).
- Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable to include curly braces.
- Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more readable when each statement is placed on its own code line.

## Switch statement
- A switch statement is a C# selection statement that provides an alternative to an if-elseif-else branching construct.
- The switch statement provides advantages over an if-elseif-else construct when evaluating a single value against a list of known matching values.
- The selected switch section is chosen based on a pattern match with the statement's match expression.
- Use the switch statement when you have one value with many possible matches, each match requiring a branch in your code logic.
- A single switch section containing code logic can be matched using one or more labels defined by the case keyword.
- Use the optional default keyword to create a label and a switch section that will be used when no other case labels match.

```cs
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
```

## for iteration loops

- The for statement iterates through a code block a specific number of times.
- This level of control makes the for statement unique among the other iteration statements.

The for statement includes the following six parts:

- The for keyword.
- A set of parentheses that defines the conditions of for iteration. The parentheses contain three distinct parts, separated by the end of statement operator, a semi-colon.
- The first part defines and initializes the iterator variable. In this example: int i = 0. This section is referred to as the initializer.
- The second part defines the completion condition. In this example: i < 10. In other words, the runtime will continue to iterate over the code in the code block below the for statement while i is less than 10. When i becomes equal to 10, the runtime stops executing the for statement's code block. The docs refer to this section as the condition.
- The third part defines the action to take after each iteration. In this case, after each iteration, i++ will increment the value of i by 1. The docs refer to this section as the iterator.
- Finally, the code block. The code block contains the code that will be executed for each iteration. Notice that the value of i is referenced inside of the code block. The docs refer to this section as the body.
- The for iteration statement allows you to iterate through a block of code a specific number of times.
- The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parentheses: the initializer, condition, and iterator.
- It's common to use the for statement when you need to control how you want to iterate through each item in an array.
- If your code block has only one line of code, you can eliminate the curly braces and white space if you wish.

```cs
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

