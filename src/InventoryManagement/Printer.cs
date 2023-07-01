using System.Text;

namespace InventoryManagement
{
    class Printer
    {
        public static void PrintItem(Item item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Barcode: {item.Barcode}\n");
            sb.Append($"Name: {item.Name}\n");
            sb.Append($"Quantity: {item.Quantity}");
            Console.WriteLine(sb);
        }
        public static void PrintInventory(Inventory inventory)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Total Items: {inventory.GetTotalQuantity()}\n");
            sb.Append($"Unique Items: {inventory.Items.Count}");
            Console.WriteLine(sb);
        }
    }
}