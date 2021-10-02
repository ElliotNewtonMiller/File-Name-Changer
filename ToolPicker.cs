namespace File_Name_Changer
{
    internal static class ToolPicker
    {
        internal static void Pick(string myDirectory, string myTool)
        {
            if (myTool == "1" ||
                myTool == "REMOVE")
            {
                ToolBox.Remove(myDirectory);
                return;
            }

            if (myTool == "2" ||
                myTool == "REMOVE AFTER")
            {
                ToolBox.RemoveAfter(myDirectory);
                return;
            }

            if (myTool == "3" ||
                myTool == "REMOVE BEFORE")
            {
                ToolBox.RemoveBefore(myDirectory);
                return;
            }

            if (myTool == "4" ||
                myTool == "ADD AT BEGINNING")
            {
                ToolBox.AddAtBeginning(myDirectory);
                return;
            }

            if (myTool == "5" ||
                myTool == "ADD AFTER")
            {
                ToolBox.AddAfter(myDirectory);
                return;
            }

            if (myTool == "6" ||
                myTool == "ADD BEFORE")
            {
                ToolBox.AddBefore(myDirectory);
                return;
            }

            if (myTool == "7" ||
                myTool == "NUMERATE")
            {
                ToolBox.Numerate(myDirectory);
                return;
            }

            System.Console.WriteLine("That is not a valid tool. Try writing exactly the number or tool name presented.");
        }
    }
}