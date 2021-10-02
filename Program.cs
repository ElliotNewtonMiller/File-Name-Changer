/* get directory
 * erase everything after the dash (including the dash and space behind it)
 * 
 * get directory
 * search for filenames with "???" (ex: "bad singing")
 * replace with something else (nothing is also an option)
 * 
 * Get directory
 * Add something to the beginning*/

using System;
using System.IO;

namespace File_Name_Changer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            while (done == false)
            {
                string myDirectory;
                string myTool;

                Console.WriteLine("Enter \"Done\" or enter a directory:");
                myDirectory = Console.ReadLine();

                if (isDone(myDirectory))
                    break;

                if (!Directory.Exists(myDirectory))
                {
                    Console.WriteLine("That is not a valid directory");
                    continue;
                }

                Console.WriteLine("choose a tool:"+ "\n1 - Remove"
                                                  + "\n2 - Remove after"
                                                  + "\n3 - Remove before"
                                                  + "\n4 - Add at beginning"
                                                  + "\n5 - Add after"
                                                  + "\n6 - Add before"
                                                  + "\n7 - Numerate");
                myTool = Console.ReadLine().ToUpper();

                if (isDone(myTool))
                    break;

                ToolPicker.Pick(myDirectory, myTool);
            }
        }

        static bool isDone(string userInput)
        {
            return userInput.ToUpper() == "DONE";
        }
    }
}
