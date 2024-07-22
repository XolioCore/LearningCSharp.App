# Exam preparation

### 1. What is a code block? 
Lines of code that should be treated as a single unit.

### 2. What is a Boolean statement or expression? 
Code that returns either true or false.

3. Given that int x = 5, which of the following Boolean expressions is valid and evaluates to true? 

x < 5.

x > 5.

x == 5.

4. Which of the choices below is not a valid operator in C#? 

%%.

&&.

||.

5. The following answer choices describe if statement syntax. Which of the descriptions is correct? 

The Boolean expression evaluated by an if statement is optional.

An else statement can't be placed before an else if statement.

The else statement is required when an if statement includes an else if.

1. What is an array? 

A string variable.

A sequence of individual data elements accessible through a single variable name.

A .NET Class Library.
2. Which of these is a correct example of creating an array and initializing it? 

string[] myarray = new string[3]; myarray = "test1"; myarray = "test2"; myarray = "test3";.

string[] myarray = string[3]; myarray[0] = test1; myarray[1] = test2; myarray[2] = test3;.

int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3;.


1. Which of the following can be used to access the third element in an array? 

myArray[3].

myArray[2].

myArray{3}.
2. Which of the following choices describes the correct way to create a new integer array with three elements? 

int[] myArray = new int[3];.

int[] myArray = new int[2];.

int myArray = new int[3];.
3. Which of the following foreach statements is syntactically correct? 

foreach (int value in values).

foreach (int value of values).

foreach (int value with values).


1. Which of the following demonstrates recommended guidelines for naming a variable? 

my-string.

initialMessage$.

initialMessage.
2. Which of the following is a bad reason to use a code comment? 

To describe the high-level intent of the code.

To explain how a new C# keyword works.

To temporarily comment out a line of code while evaluating a feature in a different way.
3. Which of the following statements about using whitespace in code is true? 

Reducing the amount of whitespace will improve code performance (execution speed).

Whitespace should be used every two or three lines to separate code lines.

Whitespace should be used judiciously to improve the readability of your code.

1. A developer writes an application that uses a foreach loop to iterate through an array containing 20 elements. After the application is complete, the developer learns that the array must be updated to include 40 elements. The application needs to examine all 40 array elements. Which of the following items describes the required code update? 

Create a second foreach loop that iterates through the additional items.

No changes are required to the foreach loop.
Correct! A foreach loop will iterate through all of the elements in an array.


Place the original foreach loop inside the code block of a second foreach loop that iterates twice.
2. A developer is working on a nested foreach structure that iterates through all of an application's data arrays. The first array contains the names of locations where water samples were collected. The remaining arrays contain the test results for the samples collected from each named location. Which of the following statements about how the arrays should be processed is correct? 

Each of the arrays containing samples can be processed by the outer loop, the inner loop will be used to verify the location.

The order in which the arrays are processed doesn't matter since the application has to process all of the data.

The outer loop must process the array containing locations, the inner loop must process the arrays containing samples.
Correct! The outer loop will iterate through the locations. The code block of the outer loop will be used to select the samples array for each location, and then process the sample in the inner foreach loop.


1. A developer is working on a nested foreach structure that iterates through the application's array data. The first array contains the names of 10 geographic regions. The remaining arrays are based on the 10 regions. Each regional array contains the population of cities that have a population over one million. The population values in the regional arrays go from largest to smallest. The application sums the 25 most populated cities in each region. How should the developer ensure that only the 25 largest populations are added to the sum? 

The developer should insert a "marker value" into the population arrays. The "marker value" should be added at index position 25. When the marker value is detected, the application should stop adding values to the sum.

The developer should check the index number of the current array element inside the foreach code block. The application should stop adding values to the sum when the index number reaches 25.

The developer should increment a counter inside the foreach code block. The application should stop adding values to the sum when the counter reaches 25.
Correct! The developer should use a counter that increments inside the foreach loop.

2. A developer is working with two other developers to update a collection of applications. The developers will use code comments during the update process. Which of the following describes an appropriate use of code comments? 

When updates are made, the developers use line and block comments to identify each individual code update.
Code comments should not be used to describe individual code lines. In this case, it would be better to summarize changes in a single block comment at the top of the files that contain updates.

When updates are made, the developers leave all existing code comments intact. New comments are added to indicate when old comments no longer apply.

When updates are made, the developers summarize changes using block comments.
Correct! Using a block comment to summarize the changes implemented during an update is a good use of code comments. A single block comment at the top of the files that contain updates is often sufficient.

1. Which of the following is a list of valid comparison operators? 

==, ~=, >, <, >=, and <=.

==, <>, >, <, >=, and <=.

==, !=, >, <, >=, and <=.
That's correct. ==, !=, >, <, >=, and <= are all valid comparison operators.

2. Which of the following code lines uses logical negation? 

Console.WriteLine(myValue!= true);.

Console.WriteLine(!myValue);.
Correct! Adding the ! operator before a conditional expression is the correct way to implement logical negation.


Console.WriteLine(myValue == false);.
3. An application contains two string variables named myValue1 and myValue2. The user enters the following two values for these variables: "Y " and " y". Which of the following expressions return false? 

(myValue1!= myValue2).

(myValue1.Trim().ToLower() != myValue2.Trim().ToLower()).
Correct! This expression returns false since the two values are equal and the inequality operator is being used.


(myValue1.Trim().ToLower() == myValue2.Trim().ToLower()).

1. Which of the following lines of code is a valid use of the conditional operator? 

int bonus = amount >= 100? 10: 5;.
Correct! This code line shows the correct syntax for a conditional operator ?:.


1. Which line of code uses logical negation? 

Console.WriteLine(!value);.
Correct! Adding the ! operator (the "not-operator") before a conditional expression forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces true if the operand evaluates to false and false if the operand evaluates to true.


Console.WriteLine(value != false);.

Console.WriteLine(a != b);.
2. Which of the following lines of code is a valid use of the conditional operator? 

int value = amount >= 10? 10: 20;.
Correct! The syntax for a conditional operator is "? (value 1) : (value 2)".


int value = amount >= 10: 10? 20;.

int value = amount >= 10? 10| 20;.

int bonus = amount >= 100: 10? 5;.

int bonus = amount >= 100? 10, 5;.

1. A developer writes some code that includes an if statement code block. They initialize one integer variable to a value of 5 above (outside) of the code block. They initialize a second integer variable to a value of 6 on the first line inside of the code block. The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. On the second line inside the code block, they assign the sum of the two values to the first variable. On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed? 

No error is generated and the integer value is displayed. The value displayed is the sum of the first and second integer.
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.


No error is generated and the integer value is displayed. The value displayed is the initialized value from above the code block.

An error is generated because the first variable isn't in-scope after the code block.


1. Which of the following statements is true about showing/removing the curly braces for code blocks associated with an if statement? 

The curly braces can't be removed from the code block for else if and else statements.

If the curly braces are removed from the code blocks of an if-elseif-else, the white space must also be removed.

Always choose a style that improves readability.
Correct! Code readability should always be a consideration when deciding whether to remove the curly braces from the code blocks associated with an if statement.

2. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 1 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 8. The second code line inside the code block is used to assign the sum of the two integer values to the first variable. The first code line after the code block is used to display the value of the first integer variable. What is the result when the code is executed? 

No error is generated and the integer value 9 is displayed.
Correct! Since the first integer is initialized above the if statement code, it's still in-scope after the code block. Also, since both integers are in-scope and initialized with values inside the code block, the addition of the values executes correctly. Finally, even though the second integer doesn't exist outside of the code block, the first integer retains any changes to its value that occurred inside the code block.


No error is generated and the integer value 1 is displayed.

An error is generated because the first variable is not in-scope after the code block.
3. A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 5 above (outside) of the code block. The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. The first code line inside of the code block is used to initialize a second integer variable to a value of 6. The first code line after the code block is used to add the second integer value to the value of the first integer. The second code line after the code block is used to display the value of the first integer. What is the result when they run the code? 

No error is generated and the integer value 11 is displayed.



1. A developer writes the code to implement a switch-case construct. What is the purpose of the break keyword? 

The break keyword tells the runtime to continue evaluating other cases in the switch construct.

The break keyword tells the runtime to stop evaluating case patterns and prevents execution of other cases in the switch construct.
Correct! The break keyword redirects code execution and prevents one switch section continuing into the next section.


The break keyword tells the runtime to exit the application.
2. A developer writes the code to implement a switch-case construct that evaluates a variable against many possible matching values. They include the default keyword as part of their switch-case construct. What is the purpose of the default keyword? 

The default keyword supplies the default value for the variable if the variable hasn't been initialized.

The default keyword acts as the matching value when none of the supplied case values is a match.
Correct. If there's no matching case value labels, the optional default label is used as the matching value.


The default keyword supplies a default actions code block that is always executed regardless of the matching case value
3. Which of the following statements about the switch-case construct is true? 

A single switch section can have multiple case labels.
Correct!


A switch construct must include a default switch section.

The colon at the end of the case label is optional.


An error is generated by the code line used to display the integer value.

A build error is generated by the code line used to sum the two integers.
Correct! A build error is generated by the code that sums the two integers. The error tells you that the second variable does not exist in the current context. The second variable is not in-scope outside the code block.


1. What is the purpose of a default case in a switch statement? 

It's used to specify the condition for the switch statement.

It's used to end the switch statement.

It's used to execute a block of code if no case matches the expression.
Correct! The default case executes when no other case matches the switch expression.

2. What happens if a break statement (or alternative keyword that prevents "fall-through") is omitted in a switch case? 

The default case will execute.
Incorrect. The default case won't execute if a break statement is omitted.


The impacted case sections will be removed by the compiler.

The compiler will generate an error.
Correct! Only one switch section is allowed to be executed. If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error.

1. Which of the following for statements is correct? 

for (int x = 20: x < 80: x++)

for (int j = 0; j < 80; j + 1)

for (int counter = 20; counter < 80; counter++)
Correct!

2. Which of the following statements should be used to exit out of a for loop before the iteration has completed? 

exit;

break;
Correct! The break keyword can be used to jump out of a for loop when a desired condition is met.

return;


1. Which of the following correctly describes a behavior of either a do-while or while iterative statement? 

A do-while statement executes a code block zero or more times.

A while statement executes a code block at least once.

A do-while statement executes a code block at least once.
Correct! The do-while iterates through a code block at least one time. Code execution exits the iteration loop once the while expression at the end of the code block evaluates to true.

2. A developer needs to capture user input inside a loop. The user enters the keyboard combination ctrl + Esc to exit the iteration when they're done entering information. Which is the best iteration statement for this purpose? 

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
