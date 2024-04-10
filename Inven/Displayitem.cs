using System;

namespace Inventory
{
    public class DisplayItem
    {
        public static void DisplayInventory(Item[,] inventory)
        {
            bool isEmpty = true;
            Console.WriteLine("Inventory:");
            for (int i = 0; i < inventory.GetLength(0); i++)
            {
                if (inventory[i, 0] != null)
                {
                    isEmpty = false;
                    Console.WriteLine($"Name: {inventory[i, 0].Name}, Price: php {inventory[i, 0].Price}, Quantity: {inventory[i, 0].Quantity}");
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("Inventory is empty.");
            }
        }
    }
}
