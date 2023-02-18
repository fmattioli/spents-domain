namespace Spents.Domain.ValueObjects
{
    public record ReceiptItem
    {
        public ReceiptItem(string itemName, short quantity, decimal itemPrice, decimal totalPrice, string observation)
        {
            ItemName = itemName;
            Quantity = quantity;
            ItemPrice = itemPrice;
            TotalPrice = totalPrice;
            Observation = observation;
        }

        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
