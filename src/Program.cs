using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = Inventory.GetInstance();
            Inventory inventory2 = Inventory.GetInstance();
            Console.WriteLine($"Is inventory the same instance as inventory2? {ReferenceEquals(inventory, inventory2)}");
            
            inventory.MaxCapacity = 10;

            Item apple = new Item("123456", "Apple", 5);
            Item banana = new Item("789012", "Banana", 3);
            Item orange = new Item("345678", "Orange", 2);
            Item mango = new Item("111222", "Mango", 6);
            Item appleDuplicate = new Item("123456", "Duplicate Apple", 4);

            inventory.AddItem(apple);
            inventory.AddItem(appleDuplicate);
            inventory.AddItem(banana);
            inventory.AddItem(orange);
            inventory.AddItem(mango);

            Printer.PrintItem(apple);
            Printer.PrintItem(banana);
            Printer.PrintItem(orange);

            inventory.ViewInventory();

            inventory.RemoveItem(apple.Barcode);
            inventory.ViewInventory();

            inventory.IncreaseQuantity(6, banana.Barcode);
            inventory.IncreaseQuantity(3, banana.Barcode);
            inventory.DecreaseQuantity(1, orange.Barcode);
            inventory.DecreaseQuantity(1, orange.Barcode);
            inventory.ViewInventory();
        }
    }
}
