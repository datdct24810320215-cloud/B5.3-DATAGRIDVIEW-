namespace B5._3_DATAGRIDVIEW_
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public decimal TotalValue => UnitPrice * Quantity;
    }
}
