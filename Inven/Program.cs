using System;

namespace Inventory
{
    class Program
    {
        static Item[,] inventory = new Item[100, 1]; // 2D array to hold items

        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.) Add Items to Inventory");
                Console.WriteLine("2.) Display Inventory");
                Console.WriteLine("3.) Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddItem.AddItemsToList(ref inventory);
                        break;
                    case 2:
                        DisplayItem.DisplayInventory(inventory);
                        break;
                    case 3:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

