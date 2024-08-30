# Exam preparation

### 1. What is a code block? 
Lines of code that should be treated as a single unit.

### 2. What is a Boolean statement or expression? 
Code that returns either true or false.

### 3. Given that int x = 5, which of the following Boolean expressions is valid and evaluates to true? 

a) x < 5

b) x > 5

c) **``` x == 5 ```**

### 4. Which of the choices below is not a valid operator in C#? 

a) **```%%```**

b) &&

c) ||

### 5. The following answer choices describe if statement syntax. Which of the descriptions is correct? 

a) The Boolean expression evaluated by an if statement is optional.

b) **``` An else statement can't be placed before an else if statement. ```**

c) The else statement is required when an if statement includes an else if.

### 6. What is an array? 

a) A string variable.

b) **``` A sequence of individual data elements accessible through a single variable name. ```**

c) A .NET Class Library.

### 7. Which of these is a correct example of creating an array and initializing it? 

a) string[] myarray = new string[3]; myarray = "test1"; myarray = "test2"; myarray = "test3";.

b) string[] myarray = string[3]; myarray[0] = test1; myarray[1] = test2; myarray[2] = test3;.

c) **``` int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3; ```**


### 8. Which of the following can be used to access the third element in an array? 

a) myArray[3]

b) **``` myArray[2] ```**

c) myArray{3}

### 9. Which of the following choices describes the correct way to create a new integer array with three elements? 

a) **```int[] myArray = new int[3]; ```**

b) int[] myArray = new int[2];.

c) int myArray = new int[3];.


### 10. Which of the following foreach statements is syntactically correct? 

a) **``` foreach (int value in values) ```**

b) foreach (int value of values).

c) foreach (int value with values).


### 11. Which of the following demonstrates recommended guidelines for naming a variable? 

a) my-string.

b) initialMessage$.

c) **``` initialMessage ```**


### 12. Which of the following is a bad reason to use a code comment? 

a) To describe the high-level intent of the code.

b) **``` To explain how a new C# keyword works. ```**

c) To temporarily comment out a line of code while evaluating a feature in a different way.


### 13. Which of the following statements about using whitespace in code is true? 

a) Reducing the amount of whitespace will improve code performance (execution speed).

b) Whitespace should be used every two or three lines to separate code lines.

c) **``` Whitespace should be used judiciously to improve the readability of your code. ```**


### 14. A developer writes an application that uses a foreach loop to iterate through an array containing 20 elements. After the application is complete, the developer learns that the array must be updated to include 40 elements. The application needs to examine all 40 array elements. Which of the following items describes the required code update? 

a) Create a second foreach loop that iterates through the additional items.

b) **```No changes are required to the foreach loop.```**
_Correct! A foreach loop will iterate through all of the elements in an array._

c) Place the original foreach loop inside the code block of a second foreach loop that iterates twice.


### 15. A developer is working on a nested foreach structure that iterates through all of an application's data arrays. The first array contains the names of locations where water samples were collected. The remaining arrays contain the test results for the samples collected from each named location. Which of the following statements about how the arrays should be processed is correct? 

a) Each of the arrays containing samples can be processed by the outer loop, the inner loop will be used to verify the location.

b) The order in which the arrays are processed doesn't matter since the application has to process all of the data.

c) **```The outer loop must process the array containing locations, the inner loop must process the arrays containing samples.```**

_Correct! The outer loop will iterate through the locations. The code block of the outer loop will be used to select the samples array for each location, and then process the sample in the inner foreach loop._


### 16. A developer is working on a nested foreach structure that iterates through the application's array data. The first array contains the names of 10 geographic regions. The remaining arrays are based on the 10 regions. Each regional array contains the population of cities that have a population over one million. The population values in the regional arrays go from largest to smallest. The application sums the 25 most populated cities in each region. How should the developer ensure that only the 25 largest populations are added to the sum? 

a) The developer should insert a "marker value" into the population arrays. The "marker value" should be added at index position 25. When the marker value is detected, the application should stop adding values to the sum.

b) The developer should check the index number of the current array element inside the foreach code block. The application should stop adding values to the sum when the index number reaches 25.

c) **```The developer should increment a counter inside the foreach code block. The application should stop adding values to the sum when the counter reaches 25.```**

_Correct! The developer should use a counter that increments inside the foreach loop._

### 17. A developer is working with two other developers to update a collection of applications. The developers will use code comments during the update process. Which of the following describes an appropriate use of code comments? 

a) When updates are made, the developers use line and block comments to identify each individual code update.
Code comments should not be used to describe individual code lines. In this case, it would be better to summarize changes in a single block comment at the top of the files that contain updates.

b) When updates are made, the developers leave all existing code comments intact. New comments are added to indicate when old comments no longer apply.

c) **```When updates are made, the developers summarize changes using block comments.```**

_Correct! Using a block comment to summarize the changes implemented during an update is a good use of code comments. A single block comment at the top of the files that contain updates is often sufficient._

### 17. Which of the following is a list of valid comparison operators? 

==, ~=, >, <, >=, and <=.

==, <>, >, <, >=, and <=.

**```==, !=, >, <, >=, and <=```**

That's correct. ==, !=, >, <, >=, and <= are all valid comparison operators.

### 18. Which of the following code lines uses logical negation? 

Console.WriteLine(myValue!= true);.

**```Console.WriteLine(!myValue);```**
Correct! Adding the ! operator before a conditional expression is the correct way to implement logical negation.

Console.WriteLine(myValue == false);.

### 19. An application contains two string variables named myValue1 and myValue2. The user enters the following two values for these variables: "Y " and " y". Which of the following expressions return false? 

(myValue1!= myValue2).

**```(myValue1.Trim().ToLower() != myValue2.Trim().ToLower()).```**
Correct! This expression returns false since the two values are equal and the inequality operator is being used.

(myValue1.Trim().ToLower() == myValue2.Trim().ToLower()).

### 20. Which of the following lines of code is a valid use of the conditional operator? 

int bonus = amount >= 100? 10: 5;.
Correct! This code line shows the correct syntax for a conditional operator ?:.

### 21. Which line of code uses logical negation? 

**```Console.WriteLine(!value);```**
Correct! Adding the ! operator (the "not-operator") before a conditional expression forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces true if the operand evaluates to false and false if the operand evaluates to true.

Console.WriteLine(value != false);

Console.WriteLine(a != b);

### 22. Which of the following lines of code is a valid use of the conditional operator? 

**```int value = amount >= 10? 10: 20;```**
Correct! The syntax for a conditional operator is "? (value 1) : (value 2)".

int value = amount >= 10: 10? 20;.

int value = amount >= 10? 10| 20;.

int bonus = amount >= 100: 10? 5;.

int bonus = amount >= 100? 10, 5;.

### 23. A developer writes some code that includes an if statement code block. They initialize one integer variable to a value of 5 above (outside) of the code block. They initialize a second integer variable to a value of 6 on the first line inside of the code block. The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. On the second line inside the code block, they assign the sum of the two values to the first variable. On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed? 

**```No error is generated and the integer value is displayed. The value displayed is the sum of the first and second integer.```**
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.

No error is generated and the integer value is displayed. The value displayed is the initialized value from above the code block.

An error is generated because the first variable isn't in-scope after the code block.

### 24. Which of the following statements is true about showing/removing the curly braces for code blocks associated with an if statement? 

The curly braces can't be removed from the code block for else if and else statements.

If the curly braces are removed from the code blocks of an if-elseif-else, the white space must also be removed.

**```Always choose a style that improves readability.```**

Correct! Code readability should always be a consideration when deciding whether to remove the curly braces from the code blocks associated with an if statement.

### 25. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 1 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 8. The second code line inside the code block is used to assign the sum of the two integer values to the first variable. The first code line after the code block is used to display the value of the first integer variable. What is the result when the code is executed? 

**```No error is generated and the integer value 9 is displayed.```**
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.

No error is generated and the integer value 1 is displayed.

An error is generated because the first variable is not in-scope after the code block.


### 26. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 5 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 6. The first code line after the code block is used to add the second integer value to the value of the first integer. The second code line after the code block is used to display the value of the first integer. What is the result when they run the code? 

No error is generated and the integer value 11 is displayed.

### 27. A developer writes the code to implement a switch-case construct. What is the purpose of the break keyword? 

The break keyword tells the runtime to continue evaluating other cases in the switch construct.

**```The break keyword tells the runtime to stop evaluating case patterns and prevents execution of other cases in the switch construct.```**
Correct! The break keyword redirects code execution and prevents one switch section continuing into the next section.

The break keyword tells the runtime to exit the application.

### 28. A developer writes the code to implement a switch-case construct that evaluates a variable against many possible matching values. They include the default keyword as part of their switch-case construct. What is the purpose of the default keyword? 

The default keyword supplies the default value for the variable if the variable hasn't been initialized.

**```The default keyword acts as the matching value when none of the supplied case values is a match.```**
Correct. If there's no matching case value labels, the optional default label is used as the matching value.

The default keyword supplies a default actions code block that is always executed regardless of the matching case value


### 29. Which of the following statements about the switch-case construct is true? 

**```A single switch section can have multiple case labels.```**
Correct!

A switch construct must include a default switch section.

The colon at the end of the case label is optional.


### 30. What is the purpose of a default case in a switch statement? 

a) It's used to specify the condition for the switch statement.

b) It's used to end the switch statement.

c) **```It's used to execute a block of code if no case matches the expression.```**
Correct! The default case executes when no other case matches the switch expression.

### 31. What happens if a break statement (or alternative keyword that prevents "fall-through") is omitted in a switch case? 

a) The default case will execute.

b) The impacted case sections will be removed by the compiler.

c) **```The compiler will generate an error.```**
Correct! Only one switch section is allowed to be executed. If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error.

### 32. Which of the following for statements is correct? 

a) for (int x = 20: x < 80: x++)

b) for (int j = 0; j < 80; j + 1)

c) **```for (int counter = 20; counter < 80; counter++)```**
Correct!

### 33. Which of the following statements should be used to exit out of a for loop before the iteration has completed? 

exit;

break;
Correct! The break keyword can be used to jump out of a for loop when a desired condition is met.

return;


### 34. Which of the following correctly describes a behavior of either a do-while or while iterative statement? 

A do-while statement executes a code block zero or more times.

A while statement executes a code block at least once.

A do-while statement executes a code block at least once.
Correct! The do-while iterates through a code block at least one time. Code execution exits the iteration loop once the while expression at the end of the code block evaluates to true.

### 35. A developer needs to capture user input inside a loop. The user enters the keyboard combination ctrl + Esc to exit the iteration when they're done entering information. Which is the best iteration statement for this purpose? 

while

for

do-while
Correct! The do-while allows the developer to check each entry by the user until they enter the special keyboard combination to exit.



1. A developer needs to iterate through an array of items. The number of items in the array is unknown. The code inside the iteration code block examines each item sequentially to select an item that matches specified criteria. The index number of the selected array element isn't important. The selected item is referenced multiple times within the code block. Which type of iteration statement is best suited for this scenario? 

foreach
Correct! It's possible to use any of these iteration types for the conditions described, but a foreach is best suited for this scenario. The foreach is easy to implement when the number of array elements is unknown. The foreach is a good choice when the index number of the selected array element isn't important. The foreach might run faster when the selected item is used multiple times within the code block.


for

while
2. A developer needs to capture a list of items from the user. The user will enter the keyboard combination ctrl + Esc to exit. Which is the best iteration statement for this purpose? 

foreach

do-while
Correct! The do-while will allow the code to check each entry by the user until they enter the special keyboard combination to exit.

while


1. When is it appropriate to use a switch-case construct rather than a if-elseif-else construct? 

A switch-case construct is appropriate when more than 2-3 else if code blocks are required.
Correct! When more than 2-3 else if code blocks are required, the code can become difficult to read, and the switch-case construct is preferable


A switch-case construct is appropriate when the number of case patterns is small.

A switch-case construct is appropriate when the selection statement is inside a loop.
2. Why should a developer choose a for statement rather than a foreach statement when processing the contents of a multidimensional array? 

for statements do a better job of examining each array item separately.

foreach statements do a better job of examining each array item separately.

for statements enable a developer to treat array dimensions separately.
Correct! When their code is processing the contents of a multidimensional array, a developer often wants to iterate through the array dimensions separately. The for statement provides better support for processing array dimensions separately.

3. Why is it important to scope a variable at its lowest necessary level? 

It ensures that a variable that's declared outside of a code block, can be accessed inside the code block before it's been assigned a value.

It ensures that application resources and the security footprint are kept small.


Correct. Keeping variables scoped at the lowest necessary level enables better resource management and helps to minimize the attack profile of the application.


It ensures that a variable can be accessed within the lowest level code branches of an application.



1. A developer is writing an application in Visual Studio Code. They save changes to their Program.cs file, and then run the dotnet build command in the Terminal panel. What information can they find in reported Error and Warning messages? 

One or more suggestions for how to fix any syntax issues detected.

The line number and information about what caused the error.
Correct. Error and Warning messages include a description of the issue and the line number where it occurs.


Links to help documentation.
2. A developer needs to create an iteration statement. Under what condition is a while statement a better choice than a do statement? 

When the expression values evaluated by the iteration statement are unknown prior to the iteration code block.

When the expression values evaluated by the iteration statement are known prior to the iteration code block.
Correct. When the code is able to evaluate the loop expression prior to the loop, a while statement allows the code to implement zero iterations.


When the developer creates nested do or while loops.


1. Which choice best represents how bits represent on and off? 

Bits are represented using "x" or "o" character.

Bits are represented using "+bit" or "-bit" notation.

Bits are binary and represented using "1" or "0" digit.
Correct. Bits are represented using the "1" or "0" digit.


1. Which data type has a range of whole numbers between 0 and 65535 in C# code? 

Sbyte

Ushort
Correct, ushort represents values 0 to 65535.


byte

1. Which is the best data type to use to process banking deposits? 

Decimal
Correct. Decimal, with ~28-29 digits of precision, has the precision required for many financial applications.


Float

Double


1. In C#, when the new keyword is used to create an instance of a class, where is the memory allocated? 

Stack

Heap
Correct. Instances of classes are allocated on the heap when created with the new keyword.


Variable


1. A piece of code must store whole numeric values between negative and positive 1,000,000. Which is the best data type to be used? 

float

double

int
Correct. While float or double would work, their extra precision after the decimal doesn't fit the exact requirement of this scenario.

2. The code for a game needs to store lots of fractional values representing x, y, and z positions in a large 3D space. It will likely need to perform physics calculations for trajectories and so on. Absolute precision isn't required, but it's important that the program runs as efficiently as possible. Which data type is best? 

float
Correct. Unlike int, float can store fractional numbers, and unlike decimal, float doesn't require extra memory to store extra precision that isn't needed in this scenario.


decimal
Incorrect. While decimal can store large fractional numbers, they require more memory to store all the precision. Furthermore, they're less efficient than float or double. Finally, they can return precise calculated values, but the question says that's not a priority in this situation.


int
3. Which of the following statements is true? 

Reference types are stored in the stack.

Value types can only store numbers.

Use the new operator to create a new instance of a reference type and return its address to the variable.
Correct. Use the new operator to create a new instance of a reference type and return its address to the variable.

1. Which is the best technique to convert a decimal type to an int type in C#? 

Cast
Correct. decimal to int is a narrowing conversion so cast is the best answer.


Narrowing

Implicit conversion
2. Which of the following conversion rounds the value (versus truncate)? 

int cost = (int)3.75m;

int cost = Convert.ToInt32(3.75m);
Correct. Convert.ToInt32() rounds values with fractional precision.


uint cost = (uint)3.75m;

1. Which technique should be used to change myInput, a string value "2.71828", into a decimal variable myInputDecimal? 

decimal myInputDecimal = (decimal)(myInput);

decimal myInputDecimal = myInput + 0;

decimal.TryParse(myInput, out myInputDecimal);
Correct. Using TryParse (or Parse()) is a valid technique.

2. Consider the C# code bool success = decimal.TryParse(input, out decimal number);. Which best describes the return type of decimal.TryParse()? 

decimal

bool
Correct. TryParse() returns a bool.

out

1. Which technique results in an error when used to convert a string value 4.123456789 into a decimal? 

Convert.ToDecimal()

decimal.TryParse()

(decimal)
Correct. It isn't possible to directly cast a string into a decimal and results in an error.

2. What type of action is being performed when changing a float into an int? 

A narrowing conversion.
Correct. Changing a float into an int is a narrowing conversion, because float can store more precision data compared to int.


A widening conversion.

An illegal conversion.

1. Which best describes the code Array.Sort(pallets); where pallets is a string array? 

Sort represents a cast operation

Sort is an Array method.
Correct. Sort is an Array method.


Sort is used to sort array amount of precision.


1. What best describes the code Array.Clear(pallets, 0, 2); where pallets is a string array? 

Array.Clear(pallets, 0, 2); removes the data from 2 array elements starting from item 0.
Correct. Clear is a method of arrays that removes (replaces with Null) specific elements in an array.


Array.Clear(pallets, 0, 2); removes the data from array element locations pallets[0] and pallets[2].

Array.Clear(pallets, 0, 2); removes array elements that are equal to 0 or 2.

1. String.Join("-", myArray); is an example of a Join. Which explanation best fits this example? 

Constructs a character array from items in myArray connected with , (commas).

Constructs a string from items in myArray connected with - (dashes).
Correct. String.Join constructs strings from the elements of myArray).

Constructs a string named myArray connected with - (dashes).


1. Which method changes the order of items in an string array? 

myArray.Resize()

myArray.Clear()

Array.Sort()
Correct. Array.Sort() places string array items in ascending order.

2. What is null? 

The same as an empty string.

The same as the value zero.

A value that indicates a variable points to nothing in memory.
Correct. Null isn't the same as an empty string or the value zero.

1. Which is the output of Console.WriteLine($"Tax rate: {tax:P1}");, where tax is defined by decimal tax =.12051 m;? 

Tax rate: 12.05%

Tax rate: 12.10%

Tax rate: 12.1%
Correct. tax: P1 rounds the percentage to a single decimal place.

1. Given string myWords = "Learning C#", what is the best output description for Console.WriteLine(myWords.PadLeft(12));? 

One space is added to the start of the string.
Correct. myWords is 11 characters long, adding on space completes the padding to 12.


Four spaces are added to the start of the string.

12 spaces are added to the start of the string.
Incorrect. myWords is 11 characters long, with 12 spaces added the padding goes to 23.


1. For the C# code Console.WriteLine("C110".PadLeft(6, '0'));, which is the expected output? 

C11000

C110000000

00C110
Correct. .PadLeft(6, '0') appends zeros to the left side of a string until the string is six characters long.

2. Which format specifier presents a decimal value with the following format to an en-US audience: 12,345.67 

0:C

0:H

0:N2
Correct. N2 is the correct format specifier.

3. Which character must be used as a directive to perform string interpolation? 

$
Correct. The $ directive is used to perform string interpolation.


@

%


1. What is the return value of myString.IndexOf('C'); where string myString = "C# Time";? 

0
Correct. "C" is the first item in myString and matches at position 0.


1

-1

1. What method should be used to search for the first occurrence of a search term in a long string? 

IndexOfAny()
Correct. IndexOfAny() returns the first position of an array of char that occurs inside of another string.


1. If the code message = message.Replace("B", "D"); is run, where string message = "Big Dog";, what is the new value of message? 

"Big Dog"

"Big Bog"

"Dig Dog"
Correct. "B" is replaced with "D".

////
1. Which method finds the next index of either the - char, the = char, or the _ char? 

IndexOfAny()
Correct. Use IndexOfAny() to retrieve the next index for any of several chars in a string.


Remove()

IndexOf()
2. What is a constant variable? 

A magic string or number.

A variable whose name must match its value.

A value that once initialized can never be changed.
Correct. A constant variable can never be changed, once initialized.

////
1. Which choice best describes the purpose of TryParse()? 

To split sentences into words stored in an array.

To safely test a cast operation.

To find a substring in a larger string.
2. For the code decimal.TryParse(numberString, out myConvert)) when the type of numberString is a String. Which best describes the value type for myConvert when the TryParse() is successful? 

A string representing numeric digits.

A Boolean value.

A decimal

////
1. Suppose there's a method named ConvertCurrency. Which of the following lines of code is a valid method signature? 

ConvertCurrency();

ConvertCurrency() { }
This answer is incorrect. A return type must be declared before the method name.


void ConvertCurrency(){};
This line is correct. A method signature is created by declaring the return type, followed by the method name, and parentheses containing any input parameters.

2. Suppose there's a method named Update. Which of the following correctly calls the method? 

var update;

Update();
This answer is correct! A method is called using its name followed by parentheses.


void Update();

////
1. Which of the following correctly declares a method? 

DisplayNumbers();

void DisplayNumbers{};

void DisplayNumbers() { }
Correct. A method is declared using the return type, followed by parentheses () containing any parameters, and brackets {} to contain the method body.

2. Which of the following correctly calls a method? 

GenerateID();
Correct! Methods are called using the name, followed by parentheses () and a semicolon.


void GenerateID() {}

GenerateID;

### 3. Which of the following is true about the return keyword? 

It's identical to the break keyword.

``It terminates the execution of a method.```

**Correct!** The return statement terminates execution of its method and returns control to the caller.

It must always be used with a value or expression.

### 1. Which of the following method signatures correctly defines 3 integer parameters? 

void Multiply(int a, b, c)

void Multiply(int a, int b, int c)
Correct! The data type for each parameter is included and parameters are comma separated.


void Multiply(int a; int b; int c)
### 2. Given the method signature, void Print(string name, string number = "", bool member = false), which of the following options correctly uses named and optional arguments? 

Print("Tony", member: true);
Correct! The optional argument is included using the parameter name followed by a :


Print(number: "555", member: false)

Print("Tony", false)
### 3. Given the following method signature, void SetHealth(string health), why don't operations inside the method affect the original input string health? 

The string data type is pass by value.

The method code must be incorrect.

```Strings can't be altered once assigned. They can only be overwritten with a new value.```
Correct! Strings are pass by reference, but they're immutable and can't be altered once assigned.

### 1. What data type is returned from the following statement: return 100 * 0.5; 

An int type

A decimal type

A double type
double is correct. Since an integer literal is being multiplied by a double, this line of code returns a double.

### 2. Which type of method doesn't need to include a return statement? 

string methods

void methods
void is correct! void methods don't need to use a return statement.

array methods


### 1. Which of the following options correctly returns a string value? 

return "";
Correct! An empty string is a valid string result.


return 'a';

return 5;
### 2. Which of the following statements is true about the return keyword? 

It starts a new iteration of a method.

It terminates the execution of a method.
Correct! The return statement terminates execution of its method and returns control to the caller.

It must always be used with a value or expression.

### 3. Which of the following options is a valid return statement? 

return void;

return 5 % 2;
Correct! This statement would return the value of the expression 5 % 2


return Console.WriteLine();

### 1. What is the purpose of defining an optional parameter in a method? 

To cause a method to perform a different task.

To overload a method.

To simplify the required parameters when a parameter isn't significant to the result.
Correct! Optional parameters enable you to pass fewer arguments and accomplish the method task.

### 2. What is the purpose of pseudo-code? 

To provide a design template for the intended code.
Correct! Pseudo-code helps to bridge the gap between concept and code.


To safely cast operations performed in methods.

To develop syntactically correct code.


### 1. A developer wants to create a method that compares two values. Which of the following options is the best data type for the method to return? 

A double value.

Nothing, the method should be void.

A bool value.
Correct! A comparison expression should return true or false.

### 2. A developer wants to create a method that returns a value in an array. Which of the following options would be a good choice for a method signature? 

string GetValueAtIndex(string[] array, int index)
Correct! This method accepts a string array and an index value and returns a string value.


bool GetValueAtIndex(string[] array, int index)

int GetValueAtIndex(int index)

### 1. What is code debugging? 

A process to identify code syntax errors during the build process.

A process to isolate and fix issues in code logic.
Correct. Code debugging involves isolating and fixing logic issues in code.


A process to verify that code builds and runs without errors.
### 2. Who is responsible for software testing? 

Software developers.
Incorrect. Although software developers have some responsibility for code testing, they share the responsibility with testers.


Software testers.

Both developers and testers.
Correct. Software developers and testers share the responsibility for code testing.

### 3. What happens if an exception isn't managed in code? 

The code continues to run without any issue.

The application generates an error message and closes.
Correct. If an exception isn't managed in code, the runtime will display an error message and the application may be terminated.


The code syntax errors are displayed to the user.

### 1. What is a debugger? 

A software tool used to observe and control the execution flow of a program.
Correct. A debugger is a software tool uses an analytical approach to observe and control the execution flow of a program.


A program that generates code automatically based on user input.

A tool that helps developers write their code faster.
### 2. What is the primary benefit of using a debugger? 

A debugger helps developers to write code faster.

A debugger enables developers to watch their application running and follow program execution one line of code at a time.
Correct. The primary benefit of using a debugger is watching application code run and following program execution one line of code at a time.


A debugger helps developers to add new features to their application.
### 3. What is one of the most important features of a debugger? 

Code generation.

Observation of your program's state.
Correct. Observation of your program's state is one of the most important features that come with almost all debuggers.


Automatic bug fixing.
### 4. What is the best way to find the root cause of a bug? 

Running your app with different data.

Breadcrumbing a few Console.WriteLine("here") messages in your code.

Using a debugger.
Correct. Using a debugger is the best way to find the root cause of a bug.

### 1. What is the purpose of catching an exception in C#? 

To ignore errors that occur in a program.

To take corrective action when an error occurs in a program.
Correct. The purpose of catching an exception is to take corrective action when an error occurs.


To generate additional errors in a program.
### 2. Can a developer access the contents of an exception at runtime? 

No, exceptions can never be accessed.

Yes, exceptions can be accessed and used to take corrective action.
Correct. Exceptions are objects that can be accessed. The properties of an exception can be used to help determine corrective action.


Exceptions can be accessed, but not during the application runtime.
### 3. What happens when execution of a C# application results in a system error? 

The program crashes and closes.

An exception is created and thrown by the .NET runtime.
Correct. The .NET runtime throws an exception when a C# application generates a system error.


The error is silently ignored and the program continues to run.
### 4. What is the relationship between the type of exception and the information it contains? 

The type of exception and the information it contains are unrelated.

The type of exception determines the information it contains.
Correct. The type of exception determines the information it contains.


The information contained in an exception determines the type of exception.
Incorrect. The exception type determines what information the exception contains, not the other way around.

### 1. What is code debugging? 

A process to identify code syntax errors during the build process.

A process to isolate and fix issues in code logic.
Correct. Code debugging involves isolating and fixing logic issues in code.


A process to verify that code builds and runs without errors.
### 2. What is a debugger? 

A software tool used to observe and control the execution flow of a program.
Correct. A debugger is a software tool uses an analytical approach to observe and control the execution flow of a program.


A program that generates code automatically based on user input.

A tool that helps developers write their code faster.
### 3. What happens when execution of a C# application results in a system error? 

The program crashes and closes.

The .NET runtime creates and throws an exception.
Correct. The .NET runtime throws an exception when a C# application generates a system error.


The error is silently ignored and the program continues to run.
### 4. What is the purpose of catching an exception in C#? 

To ignore the errors that occur in a program.

To generate other exceptions in a program.

To take corrective action when an error occurs in a program.
Correct. The purpose of catching an exception is to take corrective action when an error occurs.

### 5. What is the relationship between the type of exception and the information it contains? 

The type of exception determines the information it contains.
Correct. The type of exception determines the information it contains.


The type of exception and the information it contains are unrelated.

The information contained in an exception determines the type of exception.

### 1. Which section of the Run menu enables a developer to edit or add launch configurations? 

The start and stop applications section.

The launch configurations section.
Correct. The configurations section of the Run menu provides access to edit or add launch configurations in Visual Studio Code.


The install debuggers section.
### 2. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

VARIABLES section.

CALL STACK section.
Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application.


WATCH section.
### 3. Which button on the Debug toolbar can be used resume normal code execution? 

The Pause/Continue button.
Correct. The Pause/Continue button on the Debug toolbar can be used to pause execution when the code is running and continue when code execution has been paused.


The Step Over button.

The Restart button.
### 4. Which section of the Run menu enables the developer to set breakpoints on code lines? 

The Manage Breakpoints section.

The Start and stop applications section.

The Set Breakpoints section.
Correct. The Set Breakpoints section of the Run menu enables the developer to set breakpoints on code lines.

### 5. What capability does the "More" dropdown on the right side of the Debug toolbar provide? 

An option to disconnect the debugger.
Correct. The "More" dropdown on the right side of the Debug toolbar enables a developer to disconnect the debugger from the current process


An option to edit launch configurations.

An option to manage breakpoints.
### 6. Which of the following can be used to configure and start a debug session? 

The Debug toolbar.

The VARIABLES section of the RUN AND DEBUG view.

The Run and Debug controls panel.
Correct. The Run and Debug controls panel is used to configure and start a debug session from the RUN AND DEBUG view in Visual Studio Code.

### 1. Which of the following options can be used set a breakpoint in Visual Studio Code? 

Left-click in the column to the left of a line number in the code editor.
Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking.


Select Toggle Breakpoint on the Edit menu.

Right-click in the middle of a line of code, and then select Toggle Breakpoint.
### 2. How can a developer disable a breakpoint in Visual Studio Code? 

Click Remove Breakpoint on the Run menu.

Right-click the red dot to the left of the line number and select Disable Breakpoint.
Correct. A breakpoint can be disabled by right-clicking the red dot that represents a breakpoint and then selecting Disable Breakpoint.


Left-click the red dot to the left of the line number.
### 3. What happens when a developer disables a breakpoint in Visual Studio Code? 

The breakpoint is removed from the code entirely.

The breakpoint is skipped over during debugging.
Correct. When a breakpoint is disabled, it is skipped over during debugging. In the user interface, the red dot representing the breakpoint is changed to a grey dot.


The breakpoint will only be triggered if dot to the left of the line number is changed to a grey dot.
### 4. What is a conditional breakpoint in Visual Studio Code? 

A breakpoint that only triggers when a specified condition is met.
Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met.


A breakpoint that is triggered every time the code is run.

A breakpoint that is only visible in the editor and doesn't affect debugging.
### 5. How can a developer create a conditional breakpoint in Visual Studio Code? 

Left-click in the column to the left of a line number in the code editor.

Select Toggle Conditional Breakpoint on the Run menu.

Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.
Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint.

### 1. A developer updates a launch configuration. What is the name attribute used for? 

To specify the type of debugger used in a launch configuration.

To specify the request type of a launch configuration.

To specify the display name for a configuration.
Correct. The name attribute specifies the display name for the configuration. The value assigned to name appears in the controls panel at the top of the RUN AND DEBUG view.

### 2. A developer is working on a launch configuration. What is the preLaunchTask attribute used for? 

To specify the path of the application dll or .NET Core host executable to launch.

To specify a task to run before debugging your program.
Correct. The preLaunchTask attribute specifies a task to run before debugging the program. The task itself can be found in the tasks.json file, which is in the .vscode folder along with the launch.json file. Specifying a prelaunch task of build runs a dotnet build command before launching the application.


To specify the type of console that's used when the application is launched.
### 3. What is the console attribute of a launch configuration used for? 

Specifies the working directory of the target process.

Specifies the type of debugger to use for this launch configuration.

Specifies the type of console that's used when the application is launched.
Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole.

### 1. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

The VARIABLES section.

The CALL STACK section.
Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application.


The WATCH section.
### 2. Which of the following options can be used to set a breakpoint in Visual Studio Code? 

Left-click in the column to the left of a line number in the code editor.
Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking.


Select Toggle Breakpoint on the Edit menu.

Right-click in the middle of a line of code, and then select Toggle Breakpoint.
### 3. How can a developer disable a breakpoint in Visual Studio Code? 

Click Remove Breakpoint on the Run menu.

Right-click the red dot to the left of the line number and select Disable Breakpoint.
Correct. A breakpoint can be disabled by right-clicking the red dot that represents a breakpoint and then selecting Disable Breakpoint.


Left-click the red dot to the left of the line number.
### 4. What is a conditional breakpoint in Visual Studio Code? 

A breakpoint that only triggers when a specified condition is met.
Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met.


A breakpoint that is triggered every time the code is run.

A breakpoint that is only visible in the editor and does not affect debugging.
### 5. How can a developer create a conditional breakpoint in Visual Studio Code? 

Left-click in the column to the left of a line number in the code editor.

Select Toggle Conditional Breakpoint on the Run menu.

Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.
Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint.

### 6. In a launch configuration file, what is the console attribute used for? 

Specifies the working directory of the target process.

Specifies the type of debugger to use for this launch configuration.

Specifies the type of console that's used when the application is launched.
Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole.

### 1. Which of the following answer choices lists the C# keywords used for exception handling? 

try, catch, and finally.
Incorrect. The try, catch, and finally keywords are used for exception handling in C#, but this isn't the complete list.


try, catch, finally, and throw.
Correct. The try, catch, finally, and throw keywords are used for exception handling in C#.


try, catch, and throw.
### 2. What does the try code block contain? 

The code that cleans up resources and is executed whether an exception occurs or not.

The code that throws an exception object.

The code that may cause an exception.
Correct. The try code block contains the guarded code that may cause an exception.

### 3. What is the purpose of the catch code block? 

To clean up any resources that are allocated in a try block.

To handle the exception, log it, or ignore it.
Correct. The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it.


To execute code that may cause an exception.
### 4. What is the purpose of the finally block? 

To execute code that may cause an exception.

To handle the exception, log it, or ignore it.

To clean up any resources that are allocated in a try block.
Correct. The finally block is often used to clean up any resources that are allocated in a try block. The finally code block contains code that executes whether an exception occurs or not.

### 1. When is an ArrayTypeMismatchException exception thrown? 

An ArrayTypeMismatchException exception is thrown when an attempt is made to divide an integral value by zero.

An ArrayTypeMismatchException exception is thrown when an attempt is made to index an array outside the bounds of the array.

An ArrayTypeMismatchException exception is thrown when an attempt is made to store a value of one type in an array of another type.
Correct. The ArrayTypeMismatchException exception is thrown when an attempt is made to store an element of the wrong type within an array.

### 2. When is a DivideByZeroException exception thrown? 

A DivideByZeroException exception is thrown when an attempt is made to divide an integral value by zero.
Correct. A DivideByZeroException is thrown when trying to divide an integer or Decimal number by zero.


A DivideByZeroException exception is thrown when an attempt is made to index an array outside the bounds of the array.

A DivideByZeroException exception is thrown when an attempt is made to store a value of one type in an array of another type.
### 3. When is an IndexOutOfRangeException exception thrown? 

An IndexOutOfRangeException exception is thrown when an attempt is made to divide an integral value by zero.

An IndexOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.
Correct. An IndexOutOfRangeException exception is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.


An IndexOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.
### 4. When is an InvalidCastException exception thrown? 

An InvalidCastException exception is thrown when an attempt is made to divide an integral value by zero.

An InvalidCastException exception is thrown when an attempt is made to store a value of one type in an array of another type.

An InvalidCastException exception is thrown when attempting an invalid casting or explicit conversion.
Correct. An InvalidCastException exception is thrown when attempting an invalid casting or explicit conversion.

### 5. When is a NullReferenceException exception thrown? 

A NullReferenceException exception is thrown when attempting an invalid casting or explicit conversion.

A NullReferenceException exception is thrown when an attempt is made to store a value of one type in an array of another type.

A NullReferenceException exception is thrown when attempting to access a member on a type whose value is null.
Correct. A NullReferenceException exception is thrown when attempting to access a member on a type whose value is null.

### 1. What does the try code block contain? 

The code that cleans up resources and is executed whether an exception occurs or not.

The code that throws an exception object.

The code that may cause an exception.
Correct. The try code block contains the guarded code that may cause an exception.

### 2. What is the purpose of the catch code block? 

To clean up any resources that are allocated in a try block.

To handle the exception, log it, or ignore it.
Correct. The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it.


To execute code that may cause an exception.
### 3. When is an IndexOutOfRangeException exception thrown? 

An IndexOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

An IndexOutOfRangeException exception is thrown when attempting an invalid casting or explicit conversion.

An IndexOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.
Correct. An IndexOutOfRangeException exception is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.

### 4. When is an ArrayTypeMismatchException exception thrown? 

An ArrayTypeMismatchException exception is thrown when an attempt is made to store a value of one type in an array of another type.
Correct. The ArrayTypeMismatchException exception is thrown when an attempt is made to store an element of the wrong type within an array.


An ArrayTypeMismatchException exception is thrown when attempting to access a member on a type whose value is null.

An ArrayTypeMismatchException exception is thrown when an attempt is made to index an array outside the bounds of the array.
### 5. What is the name of the base class that all derived exception types inherit from? 

Object.

System.

Exception.
Correct. In C#, System.Exception is the base class that all derived exception types inherit from.

### 6. Which property of an exception object can be used to determine where an error occurred? 

InnerException.

StackTrace.
Correct. The StackTrace property contains a stack trace that can be used to determine where an error occurred.


TargetSite.
### 7. What is the recommended approach for catching exceptions in C#? 

Catch any type of exception without specifying an object argument.
Incorrect. Catching any type of exception without specifying an object argument isn't recommended.


Catch only the exceptions that your code knows how to recover from.
Correct. The recommended approach is to catch only the exceptions that your code knows how to recover from.


Catch only the exceptions that are not derived from System.Exception.
### 8. What is the name of the specific exception type that occurs when attempting to divide by zero in C#? 

ArithmeticException.

InvalidCastException.

DivideByZeroException.
Correct. In C#, the specific exception type that occurs when attempting to divide by zero is DivideByZeroException.

### 1. What is the purpose of the StackTrace property of an exception object? 

To track the origin of the exception.
Correct. The StackTrace property is often used to track the origin of the exception.


To configure the properties of the exception.

To throw the exception object.
### 2. Which of the following code lines provides an example of customizing an exception with contextual information? 

Code: throw new FormatException();.

Code: ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");.
Correct. This code sample demonstrates how to create an exception object with a custom Message property.


Code: ArgumentNullException argumentNullException = new ArgumentNullException();.

### 1. A developer needs to create and throw an exception in a C# application. Which of the following descriptions is correct? 

The exception type shouldn't match the intended purpose of the exception.

The exception type that they create depends on the coding issue.
Correct. The exception type created depends on the coding issue and should match the intended purpose of the exception as closely as possible.


The process for throwing an exception object involves using the catch keyword.
### 2. When should a method throw an exception? 

A method should throw an exception when the method can complete its intended purpose.
Incorrect. Methods should only throw an exception when an issue or error is detected that prevents them from completing their intended purpose.


A method should throw an exception when the method can't complete its intended purpose.
Correct. Methods should throw an exception whenever they can't complete their intended purpose.


A method should throw an exception when an exception type matches the intended purpose of the method.
### 3. A developer needs to create an exception object that includes a specific Message property. Which of the following statements is correct? 

The Message property of an exception is writable.

The Message property shouldn't explain the reason for the exception.

The Message property should explain the reason for the exception.
Correct. The Message property of an exception should explain the reason for the exception. Since Message is a read-only property, it must be assigned when instantiating the exception object.

### 1. What is the purpose of catching an exception in C#? 

To ignore the errors that occur in a program.

To generate other exceptions in a program.

To take corrective action when an error occurs in a program.
Correct. The purpose of catching an exception is to take corrective action when an error occurs.

### 2. What is the relationship between the type of exception and the information it contains? 

The type of exception and the information it contains are unrelated.

The type of exception determines the information it contains.
Correct. The type of exception determines the information it contains.


The information contained in an exception determines the type of exception.
### 3. What is a conditional breakpoint in Visual Studio Code? 

A breakpoint that only triggers when a specified condition is met.
Correct. A conditional breakpoint is a special type of breakpoint that only triggers when a specified condition is met.


A breakpoint that is triggered every time the code is run.

A breakpoint that is only visible in the editor and doesn't affect debugging.
### 4. When is an ArgumentOutOfRangeException exception thrown? 

An ArgumentOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.
Incorrect. This answer choice describes when an IndexOutOfRangeException exception is thrown.


An ArgumentOutOfRangeException exception is thrown when the value of an argument is outside the allowable range of values as defined by the method.
Correct. An ArgumentOutOfRangeException exception should only be thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.


An ArgumentOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.
### 5. What is the recommended approach for catching exceptions in C#? 

Catch any type of exception without specifying an object argument.

Catch only the exceptions that your code knows how to recover from.
Correct. The recommended approach is to catch only the exceptions that your code knows how to recover from.


Catch only the exceptions that aren't derived from System.Exception.


### 1. How can a developer create a conditional breakpoint in Visual Studio Code? 

Left-click in the column to the left of a line number in the code editor.

Select Toggle Conditional Breakpoint on the Run menu.

Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.
Correct. A developer can create a conditional breakpoint by right-clicking in the column to the left of a line number, and then selecting Add Conditional Breakpoint.

### 2. In a launch configuration file, what is the console attribute used for? 

Specifies the working directory of the target process.

Specifies the type of debugger to use for this launch configuration.

Specifies the type of console that's used when the application is launched.
Correct. The console attribute specifies the type of console that's used when the application is launched. The options are internalConsole, integratedTerminal, and externalTerminal. The default setting is internalConsole.

### 3. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

The VARIABLES section.

The CALL STACK section.
Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application.


The WATCH section.
Incorrect. The WATCH section is used to monitor variables or expressions.

### 4. Which of the following options can be used set a breakpoint in Visual Studio Code? 

Left-click in the column to the left of a line number in the code editor.
Correct. A breakpoint can be set by positioning the mouse pointer in the column to the left of a line number and then left-clicking.


Select Toggle Breakpoint on the Edit menu.

Right-click in the middle of a line of code, and then select Toggle Breakpoint.
