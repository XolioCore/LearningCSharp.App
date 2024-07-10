using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.CSharp.Learning.Basics
{
    internal class Basics
    {
        /// <summary>
        /// Basic example to use the increment operator
        /// </summary>
        void increment()
        {
            int value1 = 0;     // value is now 0.
            value1 = value1 + 5; // value is now 5.
            value1 += 5;        // value is now 10.


            int value2 = 0;     // value is now 0.
            value2 = value2 + 1; // value is now 1.
            value2++;           // value is now 2.


            int value3 = 1;
            value3++;
            Console.WriteLine("First: " + value3);
            Console.WriteLine($"Second: {value3++}");
            Console.WriteLine("Third: " + value3);
            Console.WriteLine("Fourth: " + (++value3));
        }

        void convertFarenheitToCelsius()
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }


        /*
         You're developing a Student Grading application that automates the calculation of current grades for each student in a class. The parameters for your application are:

        You're given a short list of four students and their five assignment grades.
        Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
        Final scores are calculated as an average of the five assignment scores.
        Your application needs to perform basic math operations to calculate the final grades for each student.
        Your application needs to output/display each student’s name and final score.
         */
        void calculateGradeAverages()
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            Console.WriteLine("Student\t\tGrade\n");
            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int sumSophia = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            Console.WriteLine($"Sophia:\t\t {(decimal)sumSophia / (decimal)currentAssignments} \tA");

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int sumNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            Console.WriteLine($"Nicolas:\t {(decimal)sumNicolas / (decimal)currentAssignments} \tB");

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int sumZahirah = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            Console.WriteLine($"Zahirah:\t {(decimal)sumZahirah / (decimal)currentAssignments} \tB");

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sumJeong = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
            Console.WriteLine($"Jeong:\t\t {(decimal)sumJeong / (decimal)currentAssignments} \tA");
        }

        /*
         You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

        You're given the student's name and class information.
        Each class has a name, the student's grade, and the number of credit hours for that class.
        Your application needs to perform basic math operations to calculate the GPA for the given student.
        Your application needs to output/display the student’s name, class information, and GPA.
        To calculate the GPA:

        Multiply the grade value for a course by the number of credit hours for that course.
        Do this for each course, then add these results together.
        Divide the resulting sum by the total number of credit hours.
         */
        void calculateGPA() {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = 0;

            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;

            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
            int leadingDigit = (int)gradePointAverage;

            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");





        }
    }
}
