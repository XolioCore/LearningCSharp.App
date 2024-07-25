using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.CSharp.Learning.Basics
{
    internal class Arrays
    {

        void DeclaringArray()
        {
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
        }

        void InitilizeArray()
        {
            string[] orderIDs = { "A001", "B002", "C003" };

            Console.WriteLine($"First: {orderIDs[0]}");
            Console.WriteLine($"Second: {orderIDs[1]}");
            Console.WriteLine($"Third: {orderIDs[2]}");
        }

        void LengthOfArray()
        {
            string[] orderIDs = { "A001", "B002", "C003" };

            Console.WriteLine($"Lenght: {orderIDs.Length}");
        }

        void LoopingArray()
        {
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
        }

        void SortArray() {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }

        void ReverseArray() {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

        }

        void StringToCharArray()
        {
            string value = "ABC123";
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            Console.WriteLine(reversed);

        }

        void StringJoinString() {
            string value = "ABC123";
            char[] chars = value.ToCharArray();
            string joined = String.Join(",", chars);
            Console.WriteLine(joined);
        }

        void SplitString() {

            string value = "This is an example, using split, from and string, separated by commas";
            string[] arrayValues = value.Split(',');
            foreach (var arrayValue in arrayValues)
            {
                Console.WriteLine(arrayValue);
            }
        }

        void ReverseWordFromText() {

            string pangram = "The quick brown fox jumps over the lazy dog";

            // Step 1
            string[] message = pangram.Split(' ');

            //Step 2
            string[] newMessage = new string[message.Length];

            // Step 3
            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            //Step 4
            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
        }

        void SplitSortString() {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');
            Array.Sort(items);

            foreach (var item in items)
            {
                if (item.Length == 4)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(item + "\t- Error");
                }
            }

        }

        void DetectsValuesStartingWithB()
        {
            string[] names = { "Bob", "Maria", "Brenda"};
            foreach (string name in names)
            {
                if (name.StartsWith("B"))
                {
                    Console.WriteLine($"The name{name} starts with 'B'!");
                }
            }
        }

        void SampleStudentCredit()
        {
            // initialize variables - graded assignments
            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Write the Report Header to the console
            Console.WriteLine("Student\t\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                // initialize/reset the sum of scored assignments
                int sumAssignmentScores = 0;

                // initialize/reset the calculated average of exam + extra credit scores
                decimal currentStudentGrade = 0;

                // initialize/reset a counter for the number of assignment 
                int gradedAssignments = 0;

                // loop through the scores array and complete calculations for currentStudent
                foreach (int score in studentScores)
                {
                    // increment the assignment counter
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        // add the exam score to the sum
                        sumAssignmentScores += score;

                    else
                        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

            // required for running in VS Code (keeps the Output windows open to view results)
            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();
        }
    }
}
