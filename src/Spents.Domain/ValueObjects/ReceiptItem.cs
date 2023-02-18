namespace Spents.Domain.ValueObjects
{
    public record ReceiptItem
    {
        public ReceiptItem(Guid id, string itemName, short quantity, decimal itemPrice, decimal totalPrice, string observation)
        {
            Id = id;
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
