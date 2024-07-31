using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Xml;

namespace NET.CSharp.Learning.Basics
{
    internal class Samples
    {
        bool IsPalindrome(string word)
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (word[start] != word[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }



    }


    /// <summary>
    /// You're developing an application for the Contoso Petting Zoo that coordinates school visits. 
    /// The Contoso Petting Zoo is home to 18 different species of animals. At the zoo, visiting students are assigned to groups, and each group has a set of animals assigned to it. 
    /// After visiting their set of animals, 
    /// the students will rotate groups until they've seen all the animals at the petting zoo.
    ///    By default, the students are divided into 6 groups.However, there are some classes that have a small or large number of students,
    ///    so the number of groups must be adjusted accordingly.The animals should also be randomly assigned to each group, so as to keep the experience unique.
    ///    The design specification for the Contoso Petting Zoo application is as follows:

    //There are currently three visiting schools
    //School A has six visiting groups(the default number)
    //School B has three visiting groups
    //School C has two visiting groups
    //For each visiting school, perform the following tasks
    //    Randomize the animals
    //Assign the animals to the correct number of groups
    //    Print the school name
    //    Print the animal groups
    /// </summary>
    internal class PettingZooSample()
    {
        //using System;

        string[] pettingZoo =
        {
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
        void main()
        {
            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);
        }
        void PlanSchoolVisit(string schoolName, int groups = 6)
        {
            RandomizeAnimals();
            string[,] group1 = AssignGroup(groups);
            Console.WriteLine(schoolName);
            PrintGroup(group1);
        }

        void RandomizeAnimals()
        {
            Random random = new Random();

            for (int i = 0; i < pettingZoo.Length; i++)
            {
                int r = random.Next(i, pettingZoo.Length);

                string temp = pettingZoo[r];
                pettingZoo[r] = pettingZoo[i];
                pettingZoo[i] = temp;
            }
        }

        string[,] AssignGroup(int groups = 6)
        {
            string[,] result = new string[groups, pettingZoo.Length / groups];
            int start = 0;

            for (int i = 0; i < groups; i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = pettingZoo[start++];
                }
            }

            return result;
        }

        void PrintGroup(string[,] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                Console.Write($"Group {i + 1}: ");
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    Console.Write($"{groups[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }

    /*
     A C# console application that simulates daily purchase transactions.

The application calls the MakeChange method to manage the money till during transactions. MakeChange accepts cash payments and returns change.

The calling application independently verifies the till balance after each transaction.

A try-catch pattern is implemented to manage exceptions as follows:

Exceptions are used to report and handle any issue that prevents a transaction from completing successfully.
Exceptions are created and thrown in the MakeChange method.
Exceptions are caught and handled in the calling application.
An application that simulates transactions and calls the MakeChange method has already been developed. The Starter code project for this Guided project module includes a Program.cs file that includes the following code:

Simulate transactions: the top-level statements configure application data and simulate a series of transactions using either a small testData array or a larger number of randomly generated transactions.
Initialize the till: the LoadTillEachMorning method is used to configure the cash register till with a predefined number of bills in each denomination.
Process transactions: the MakeChange method is used to manage the cash till during purchase transactions.
Report till status: the LogTillStatus method is used to display the number of bills of each denomination currently in the till.
Report till balance: the TillAmountSummary method is used display a message showing the amount of cash in the till.
     */
    internal class MakeChanges
    {
        /*
    This application manages transactions at a store check-out line. The
    check-out line has a cash register, and the register has a cash till
    that is prepared with a number of bills each morning. The till includes
    bills of four denominations: $1, $5, $10, and $20. The till is used
    to provide the customer with change during the transaction. The item 
    cost is a randomly generated number between 2 and 49. The customer 
    offers payment based on an algorithm that determines a number of bills
    in each denomination. 

    Each day, the cash till is loaded at the start of the day. As transactions
    occur, the cash till is managed in a method named MakeChange (customer 
    payments go in and the change returned to the customer comes out). A 
    separate "safety check" calculation that's used to verify the amount of
    money in the till is performed in the "main program". This safety check
    is used to ensure that logic in the MakeChange method is working as 
    expected.
    */

        void main()
        {
            string? readResult = null;
            bool useTestData = false;

            Console.Clear();

            int[] cashTill = new int[] { 0, 0, 0, 0 };
            int registerCheckTillTotal = 0;

            // registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
            int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

            int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
            int testCounter = 0;

            LoadTillEachMorning(registerDailyStartingCash, cashTill);

            registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

            // display the number of bills of each denomination currently in the till
            LogTillStatus(cashTill);

            // display a message showing the amount of cash in the till
            Console.WriteLine(TillAmountSummary(cashTill));

            // display the expected registerDailyStartingCash total
            Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
            Console.WriteLine();

            var valueGenerator = new Random((int)DateTime.Now.Ticks);

            int transactions = 10;

            if (useTestData)
            {
                transactions = testData.Length;
            }

            while (transactions > 0)
            {
                transactions -= 1;
                int itemCost = valueGenerator.Next(2, 50);

                if (useTestData)
                {
                    itemCost = testData[testCounter];
                    testCounter += 1;
                }

                int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
                int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
                int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
                int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

                // display messages describing the current transaction
                Console.WriteLine($"Customer is making a ${itemCost} purchase");
                Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
                Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
                Console.WriteLine($"\t Using {paymentFives} five dollar bills");
                Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

                try
                {
                    // MakeChange manages the transaction and updates the till 
                    MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

                    // Backup Calculation - each transaction adds current "itemCost" to the till
                    registerCheckTillTotal += itemCost;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Could not make transaction: {e.Message}");
                }

                Console.WriteLine(TillAmountSummary(cashTill));
                Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to exit");
            do
            {
                readResult = Console.ReadLine();

            } while (readResult == null);

        }
        static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
        {
            cashTill[0] = registerDailyStartingCash[0, 1];
            cashTill[1] = registerDailyStartingCash[1, 1];
            cashTill[2] = registerDailyStartingCash[2, 1];
            cashTill[3] = registerDailyStartingCash[3, 1];
        }


        static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
        {
            cashTill[3] += twenties;
            cashTill[2] += tens;
            cashTill[1] += fives;
            cashTill[0] += ones;

            int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
            int changeNeeded = amountPaid - cost;

            if (changeNeeded < 0)
                throw new InvalidOperationException("Not enough money provided");

            Console.WriteLine("Cashier Returns:");

            while ((changeNeeded > 19) && (cashTill[3] > 0))
            {
                cashTill[3]--;
                changeNeeded -= 20;
                Console.WriteLine("\t A twenty");
            }

            while ((changeNeeded > 9) && (cashTill[2] > 0))
            {
                cashTill[2]--;
                changeNeeded -= 10;
                Console.WriteLine("\t A ten");
            }

            while ((changeNeeded > 4) && (cashTill[1] > 0))
            {
                cashTill[1]--;
                changeNeeded -= 5;
                Console.WriteLine("\t A five");
            }

            while ((changeNeeded > 0) && (cashTill[0] > 0))
            {
                cashTill[0]--;
                changeNeeded -= 1;
                Console.WriteLine("\t A one");
            }

            if (changeNeeded > 0)
                throw new InvalidOperationException("Can't make change. Do you have anything smaller?");

        }

        static void LogTillStatus(int[] cashTill)
        {
            Console.WriteLine("The till currently has:");
            Console.WriteLine($"{cashTill[3] * 20} in twenties");
            Console.WriteLine($"{cashTill[2] * 10} in tens");
            Console.WriteLine($"{cashTill[1] * 5} in fives");
            Console.WriteLine($"{cashTill[0]} in ones");
            Console.WriteLine();
        }

        static string TillAmountSummary(int[] cashTill)
        {
            return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

        }

    }
}
