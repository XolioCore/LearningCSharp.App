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
