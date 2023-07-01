namespace InventoryManagement
{
    class Item
    {
        private string _barcode = string.Empty;
        private string _name = string.Empty;
        private int _quantity; 

        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
            // checking for unique barcode from inside inventory as I don't have access to the specific instance of inventory here.
            // other option would be to keep track of the barcodes inside Program.cs but I think it's better if it's part of the
            // Inventory functionality to make sure each item in the specific inventory instance has unique barcode
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                {
                    _quantity = value;
                }
                else
                {
                    Console.WriteLine("Quantity must be more than 0.");
                }
            }
        }
        public Item(string barcode, string name, int quantity)
        {
            Barcode = barcode;
            Name = name;
            Quantity = quantity;
        }

        public void IncreaseQuantity(int amount)
        {
            _quantity += amount;
        }
        public void DecreaseQuantity(int amount)
        {
            if ((_quantity -= amount) > 0)
            {
                _quantity -= amount;
            }
            else
            {
                Console.WriteLine("Quantity must be more than 0.");
            }
        }
        
        ~Item()
        {
            Console.WriteLine("Finalizer called; destroying Instance.");
        }
    }
}
