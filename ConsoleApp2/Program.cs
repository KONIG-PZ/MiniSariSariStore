using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    //TODO Save purchase
    //TODO Save Multiple Purchases
    public class Items
    {
        public int ID { get; set; }
        public required string Item { get; set; }
        public decimal Price { get; set; }
    }
    public class Program
    {
        static Items? Soda;
        static Items? Chips1;
        static Items? Chips2;
        static Items? Candy1;
        static Items? Candy2;

        public static void Main(string[] args)
        {
            Header();
            DisplayMenu();
            Objects();
            Select();
            ExitProgram();
        }

        //HEADER
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

        //DISPLAY MENU
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

        //SELECT ITEM
        public static void Select()
        {
            Console.Write("INPUT HERE (1-5): ");
            string IDSelect = Console.ReadLine();
            string fileName = "ItemInStore.json";

            Items selectedItem = IDSelect switch
            {
                "1" => Soda,
                "2" => Chips1,
                "3" => Chips2,
                "4" => Candy1,
                "5" => Candy2,
                _ => null
            };

            if (selectedItem != null)
            {
                string jsonString = JsonSerializer.Serialize(selectedItem, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(fileName, jsonString);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Item saved to file.");
                Console.ResetColor();
                Display(); // Show the saved data
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid Input");
                Console.ResetColor();
            }
            RepeatChoice();
        }

        //Display Items
        public static void Display()
        {
            string json = File.ReadAllText("ItemInStore.json");
            Items item = JsonSerializer.Deserialize<Items>(json);

            Console.WriteLine("\n=== Displaying from JSON file ===");
            Console.WriteLine($"ID: {item.ID}");
            Console.WriteLine($"Item: {item.Item}");
            Console.WriteLine($"Price: {item.Price}Php");
        }

        // Repeat to Start
        public static void RepeatChoice()
        {
            string again;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Would you like to choose another item? enter 'n' key to exit: ");
                again = Console.ReadLine();
                Console.ResetColor();

                if (again == "n")
                { ExitProgram(); break; }
                else if (again == "")
                { RepeatChoice(); }
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

        // Objects
        public static void Objects()
        {
            Soda = new Items { ID = 1, Item = "Soda", Price = 20.00m };
            Chips1 = new Items { ID = 2, Item = "Chips1", Price = 15.00m };
            Chips2 = new Items { ID = 3, Item = "Chips2", Price = 14.99m };
            Candy1 = new Items { ID = 4, Item = "Candy1", Price = 2.99m };
            Candy2 = new Items { ID = 5, Item = "Candy2", Price = 1.00m };
        }

        // Exit 
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


