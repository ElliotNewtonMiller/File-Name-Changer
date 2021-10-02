using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_Name_Changer
{
    public static class ToolBox
    {
        static void SetTargetFiles(FileInfo[] files, List<FileInfo> targets, string userString)
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.Contains(userString))
                    targets.Add(files[i]);
            }
        }

        public static void Remove(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();
            List<FileInfo> targets = new List<FileInfo>();

            Console.WriteLine("What string do you want to remove?");
            var stringToRemove = Console.ReadLine();

            SetTargetFiles(files, targets, stringToRemove);

            for (int i = 0; i < targets.Count; i++)
            {
                int indexToErase = targets[i].Name.IndexOf(stringToRemove);
                string fileName = targets[i].Name;

                targets[i].MoveTo(myDirectory
                                    + "/"
                                    + fileName.Substring(0, indexToErase)
                                    + fileName.Substring(indexToErase + stringToRemove.Length));
            }
        }

        public static void RemoveAfter(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();
            List<FileInfo> targets = new List<FileInfo>();

            Console.WriteLine("What should trigger the erasing?");
            var erasingTrigger = Console.ReadLine();

            Console.WriteLine("Erase including that string or not? Y/N");
            string inclusive = Console.ReadLine().ToUpper();
            int x = inclusive == "Y" ? 0 : erasingTrigger.Length;

            SetTargetFiles(files, targets, erasingTrigger);

            for (int i = 0; i < targets.Count; i++)
            {
                int indexToErase = targets[i].Name.IndexOf(erasingTrigger) + x;
                string fileName = targets[i].Name;

                targets[i].MoveTo(myDirectory
                                    + "/"
                                    + fileName.Substring(0, indexToErase)
                                    + fileName.Substring(fileName.IndexOf('.')));
            }
        }

        public static void RemoveBefore(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();
            List<FileInfo> targets = new List<FileInfo>();

            Console.WriteLine("What should trigger the erasing?");
            var erasingTrigger = Console.ReadLine();

            Console.WriteLine("Erase including that string or not? Y/N");
            string inclusive = Console.ReadLine().ToUpper();
            int x = inclusive == "Y" ? erasingTrigger.Length : 0;

            SetTargetFiles(files, targets, erasingTrigger);

            for (int i = 0; i < targets.Count; i++)
            {
                int indexToErase = targets[i].Name.IndexOf(erasingTrigger) + x;
                string fileName = targets[i].Name;

                targets[i].MoveTo(myDirectory + "/" + fileName.Substring(indexToErase));
            }
        }

        public static void AddAtBeginning(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();

            Console.WriteLine("What would you like to add?");
            string stringToAdd = Console.ReadLine();

            for (int i = 0; i < files.Length; i++)
            {
                files[i].MoveTo(myDirectory + "/" + stringToAdd + files[i].Name);
            }
        }

        public static void AddAfter(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();
            List<FileInfo> targets = new List<FileInfo>();

            Console.WriteLine("What do you want to add?");
            string stringToAdd = Console.ReadLine();

            Console.WriteLine("After what do you want to add it?");
            string addingTrigger = Console.ReadLine();

            SetTargetFiles(files, targets, addingTrigger);

            for (int i = 0; i < targets.Count; i++)
            {
                string fileName = targets[i].Name;

                targets[i].MoveTo(myDirectory
                                    + "/" 
                                    + fileName.Substring(0, fileName.IndexOf(addingTrigger) + addingTrigger.Length)
                                    + stringToAdd
                                    + fileName.Substring(fileName.IndexOf(addingTrigger) + addingTrigger.Length));
            }
        }

        public static void AddBefore(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();
            List<FileInfo> targets = new List<FileInfo>();

            Console.WriteLine("What do you want to add?");
            string stringToAdd = Console.ReadLine();

            Console.WriteLine("After what do you want to add it?");
            string addingTrigger = Console.ReadLine();

            SetTargetFiles(files, targets, addingTrigger);

            for (int i = 0; i < targets.Count; i++)
            {
                string fileName = targets[i].Name;

                targets[i].MoveTo(myDirectory
                                    + "/"
                                    + fileName.Substring(0, fileName.IndexOf(addingTrigger))
                                    + stringToAdd
                                    + fileName.Substring(fileName.IndexOf(addingTrigger)));
            }
        }

        public static void Numerate(string myDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(myDirectory);
            FileInfo[] files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                files[i].MoveTo(myDirectory
                                    + "/"
                                    + (i + 1)
                                    + " "
                                    + files[i].Name);
            }
        }
    }
}