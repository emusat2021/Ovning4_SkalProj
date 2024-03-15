using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            List<string> theList = new List<string>();
            bool notToMainMenu = true;

            while (notToMainMenu)
            {
                //sub menu
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please navigate through the menu below:"
                    + "\n+<Name>.   Add name in List (example: +Adam will add Adam to the List)"
                    + "\n-<Name>.   Remove name in List (example: -Adam will remove Adam from the List)"
                    + "\nq.         Go back to Main Menu");

                string input = Console.ReadLine().ToLower();
                char nav = input[0];
                string value = input.Substring(1);

                // Add name on the List respective remove as the user will have the posibility to choose
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        //feedback to the user after adding an item on the list
                        PrintListInfo(theList);
                        continue;
                    case '-':
                        theList.Remove(value);
                        //feedback to the user after removing an item from the list
                        PrintListInfo(theList);
                        continue;
                    case 'q':
                        notToMainMenu = false;
                        break;
                    default:
                        Console.WriteLine("Choose only + or only -");
                        continue;
                }

            }
            //the final feedback to the user after the user will go out from the sub menu
            PrintListInfo(theList);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }
        public static void PrintListInfo(List<string> theList)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The List includes the below names:");
            foreach (string str in theList)
            {
                Console.WriteLine($"Name: {str}");
            }
            Console.WriteLine($"Number of items in the List: {theList.Count}");
            Console.WriteLine($"Capacity of the List: {theList.Capacity}");
            Console.ResetColor();
        }

    }
}

