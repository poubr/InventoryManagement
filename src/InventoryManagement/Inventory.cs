namespace InventoryManagement
{
    class Inventory
    {
        private List<Item> _items = new List<Item>();
        private int _maxCapacity;
        private static Inventory? _instance;
        private Inventory()
        {

        }

        public static Inventory GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Inventory();
            }
            return _instance;                 
        }

        public int MaxCapacity
        {
            get { return _maxCapacity; }
            set
            {
                if (value >= 0)
                {
                    _maxCapacity = value;
                }
                else
                {
                    Console.WriteLine("Maximum capacity must be more than 0.");
                }
            }
        }
        public List<Item> Items
        {
            get { return _items;}
        }
        public bool IsBarcodeUnique(string barcode)
        {
            foreach (Item item in _items)
            {
                if (item.Barcode == barcode)
                {
                    return false;
                }
            }
            return true;
        }

        public int GetTotalQuantity()
        {
            int totalQuantity = 0;
            foreach (Item item in _items)
            {
                totalQuantity += item.Quantity;
            }
            return totalQuantity;
        }
        public void AddItem(Item item)
        {
            if (GetTotalQuantity() + item.Quantity <= _maxCapacity)
            {
                if (IsBarcodeUnique(item.Barcode))
                {
                    _items.Add(item);
                }
                else
                {
                    Console.WriteLine($"Barcode must be unique; cannot add {item.Name}");
                }
            }
            else
            {
                Console.WriteLine($"Maximum capacity reached; cannot add {item.Name}.");
            }
        }
        public bool RemoveItem(string itemBarcode)
        {
            Item? itemToRemove = _items.FirstOrDefault(item => item.Barcode == itemBarcode);
            if (itemToRemove != null)
            {
                _items.Remove(itemToRemove);
                Console.WriteLine($"{itemToRemove.Name} removed.");
                return true;
            }
            Console.WriteLine("No such item in inventory; cannot remove.");
            return false;
        }
        public void IncreaseQuantity(int amount, string itemBarcode)
        {
            Item? itemToIncrease = _items.FirstOrDefault(item => item.Barcode == itemBarcode);
            if (itemToIncrease != null)
            {
                if (GetTotalQuantity() + amount <= _maxCapacity)
                {
                    itemToIncrease.Quantity += amount;
                    Console.WriteLine($"Increasaed quantity of {itemToIncrease.Name} to {itemToIncrease.Quantity}");
                }
                else
                {
                    Console.WriteLine($"Cannot increase quantity of {itemToIncrease.Name} as it would exceed maximum capacity.");
                }
            }
            else
            {
                Console.WriteLine("Cannot increase quantity; no such item in the inventory.");
            }
        }
        public void DecreaseQuantity(int amount, string itemBarcode)
        {
            Item? itemToDecrease = _items.FirstOrDefault(item => item.Barcode == itemBarcode);
            if (itemToDecrease != null)
            {
                if ((itemToDecrease.Quantity - amount ) > 0 )
                {
                    itemToDecrease.Quantity -= amount;
                    Console.WriteLine($"Decreased quantity of {itemToDecrease.Name} to {itemToDecrease.Quantity}");
                }
                else
                {
                    Console.WriteLine($"Item's amount is less than 0. Removing {itemToDecrease.Name} from inventory.");
                    RemoveItem(itemBarcode);
                }
            }
            else
            {
                Console.WriteLine("Cannot decrease quantity; no such item in the inventory");
            }
        }
        public void ViewInventory()
        {
            Printer.PrintInventory(this);
        }
        ~Inventory()
        {
            Console.WriteLine("Finalizer called; destroying Instance.");
        }
    }
}