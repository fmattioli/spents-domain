namespace Spents.Domain.ValueObjects
{
    public interface IReceiptItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; }
        public decimal TotalPrice { get { return ItemPrice * Quantity; } }

        public decimal CalculateTotalPrice(decimal itemPrice, short quantity);
    }
}
