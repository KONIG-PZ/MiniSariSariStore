using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class Program
    {
        // TODO Add price? (Just for fun or realism)
        // TODO improve Cashier()
        // TODO Add the Items to Json
        static Items Soda;
        static Items Chips1;
        static Items Chips2;
        static Items Candy1;
        static Items Candy2;

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
            // DISPLAY MENU
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Header();
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+----+--------++----------+");
            Console.WriteLine("| ID | Item   || Price    |");
            Console.WriteLine("+----+--------++----------+");
            Console.WriteLine("| 1  | Soda   || 20.00php |");
            Console.WriteLine("| 2  | Chips1 || 15.00php |");
            Console.WriteLine("| 3  | Chips2 || 14.99php |");
            Console.WriteLine("| 4  | Candy1 || 02.99php |");
            Console.WriteLine("| 5  | Candy2 || 01.00php |");
            Console.WriteLine("+----+--------++--------+");
            Console.ResetColor();
        }
        static void ChooseItemFromMenu(Items item)
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Choice: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string choice = Console.ReadLine();
            Console.ResetColor();




            if (int.TryParse(choice, out int num))
            {
                 switch (num)
                {
                    case 1: Console.WriteLine("{0} | {1} | {2}PHP", Soda.ID, Soda.Item, Soda.Price); break;
                    case 2: Console.WriteLine("{0} | {1} | {2}PHP", Chips1.ID, Chips1.Item, Chips1.Price); break;
                    case 3: Console.WriteLine("{0} | {1} | {2}PHP", Chips2.ID, Chips2.Item, Chips2.Price); break;
                    case 4: Console.WriteLine("{0} | {1} | {2}PHP", Candy1.ID, Candy1.Item, Candy1.Price); break;
                    case 5: Console.WriteLine("{0} | {1} | {2}PHP", Candy2.ID, Candy2.Item, Candy2.Price); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID INPUT: Choice out of range.");
                        Console.ResetColor();
                        break;
                }

            }

        }
        static void ItemList()
        {
            Soda = new Items { ID = 1, Item = "Soda", Price = 20.00m };
            Chips1 = new Items { ID = 2, Item = "Chips1", Price = 15.00m };
            Chips2 = new Items { ID = 3, Item = "Chips2", Price = 14.99m };
            Candy1 = new Items { ID = 4, Item = "Candy1", Price = 2.99m };
            Candy2 = new Items { ID = 5, Item = "Candy2", Price = 1.00m };
        }
        class Items()
        { 
            public int ID { get; set; }
            public string Item { get; set; }
            public decimal Price { get; set; }
        }
        static void Cashier()
        {
            Console.WriteLine("");
        }
        static void RepeatChoice()
        {
            // REPEAT CHOICES
            string again;
            do
            {
                ChooseItemFromMenu(null);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Would you like to choose another item? press enter key to continue: ");
                again = Console.ReadLine();
                Console.ResetColor();

                if (again == "n")
                {ExitProgram();break;}
                else if (again == "")
                {RepeatChoice();}
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT! PRESS ENTER TO PICK ANOTHER ITEM");
                    Console.Clear();
                    Console.WriteLine("");
                    Main(new string[] { });
                    Console.ResetColor();
                }


            } while (true);
        }
        static void ExitProgram()
        {
            // EXIT
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Thank you and come again!!");
            Console.WriteLine("Press any key to exit...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("");
            Main(new string[] { });
        }

    }
}

//SHADOW REALM
/*{
    int rows = 7;
    int cols = 50;
    string message = "MENU!";
    int messageRow = rows / 2;
    int messageStartCol = (cols - message.Length) / 2;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
            { Console.Write("*"); }
            else if (i == messageRow && j >= messageStartCol && j < messageStartCol + message.Length)
            {
                Console.Write(message[j - messageStartCol]);
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
*/
/*static void ChooseItemFromMenuOld()
    {
        // CHOOSE AN ITEM
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter Choice: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string choice = Console.ReadLine();
        Console.ResetColor();

        if (int.TryParse(choice, out int num))
        {
            switch (num)
            {
                case 1: Console.WriteLine("    1 - Soda"); break;
                case 2: Console.WriteLine("    2 - Chips1"); break;
                case 3: Console.WriteLine("    3 - Chips2"); break;
                case 4: Console.WriteLine("    4 - Candy1"); break;
                case 5: Console.WriteLine("    5 - Candy2"); break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT: Choice out of range.");
                    Console.ResetColor();
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: Please enter a valid number.");
            Console.ResetColor();
        }
    }*/


