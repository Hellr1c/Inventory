using System;

namespace Inventory
{
    public class AddItem
    {
        public static void AddItemsToList(ref Item[,] inventory)
        {
            bool addingItems = true;
            while (addingItems)
            {
                Console.Write("Enter name of item: ");
                string name = Console.ReadLine();

                Console.Write("Enter price: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.WriteLine("Invalid price. Please enter a numeric value.");
                    continue;
                }

                Console.Write("Enter quantity: ");
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Invalid quantity. Please enter a numeric value.");
                    continue;
                }


                for (int i = 0; i < inventory.GetLength(0); i++)
                {
                    if (inventory[i, 0] == null)
                    {
                        inventory[i, 0] = new Item { Name = name, Price = price, Quantity = quantity };
                        break;
                    }
                }

                Console.Write("Do you want to add more items? (Y/N): ");
                String response = Console.ReadLine().ToUpper();
                if (response != "Y")
                {
                    addingItems = false;
                }
            }
        }
    }
}
