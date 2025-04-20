namespace ConsoleApp2
{
    internal class Program
    {
        // TODO Add default case to handle invalid input.
        // Add price? (Just for fun or realism)

        static void Main(string[] args)
        {
            DisplayMenu();
            RepeatChoice();
            ExitProgram();
        }
        static void Header()
        {
            //HEADER DESIGN
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*    ***     ***  *******  ***    **   **     **    *");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*    ** *   * **  **       ** *   **   **     **    *");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*    **  * *  **  ******   **  *  **   **     **    *");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*    **   *   **  **       **   * **   **     **    *");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*    **       **  *******  **    ***   *********    *");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*****************************************************");
            Console.ResetColor();
        }
        static void DisplayMenu()
        {
            // TODO: IMPROVE AESTETICS 
            // DISPLAY MENU
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Header();
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+----+--------+");
            Console.WriteLine("| ID | Item   |");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("| 1  | Soda   |");
            Console.WriteLine("| 2  | Chips1 |");
            Console.WriteLine("| 3  | Chips2 |");
            Console.WriteLine("| 4  | Candy1 |");
            Console.WriteLine("| 5  | Candy2 |");
            Console.WriteLine("+----+--------+");
            Console.ResetColor();
        }
        static void ChooseItemFromMenu()
        {
            // CHOOSE AN ITEM
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Choice: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string choice = Console.ReadLine();
            Console.ResetColor();

            switch (choice)
            {
                case "1": Console.WriteLine("    1 - Soda"); break;
                case "2": Console.WriteLine("    2 - Chips1"); break;
                case "3": Console.WriteLine("    3 - Chips2"); break;
                case "4": Console.WriteLine("    4 - Candy1"); break;
                case "5": Console.WriteLine("    5 - Candy2"); break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALIDE INPUT");
                    Console.ResetColor();
                    break;
            }

        }
        static void RepeatChoice()
        {
            // REPEAT CHOICES
            string again;
            do
            {
                ChooseItemFromMenu();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Would you like to choose another item? press enter key to continue: ");
                again = Console.ReadLine();
                Console.ResetColor();
            } while (again == "");
        }
        static void ExitProgram()
        {
            // EXIT
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Thank you and come again!!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

//SHADOW REALM
    //{
    //    int rows = 7;
    //    int cols = 50;
    //    string message = "MENU!";
    //    int messageRow = rows / 2;
    //    int messageStartCol = (cols - message.Length) / 2;
    //
    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < cols; j++)
    //        {
    //            if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
    //            { Console.Write("*"); }
    //            else if (i == messageRow && j >= messageStartCol && j < messageStartCol + message.Length)
    //            {
    //                Console.Write(message[j - messageStartCol]);
    //            }
    //            else
    //            {
    //                Console.Write(" ");
    //            }
    //        }
    //        Console.WriteLine();
    //    }