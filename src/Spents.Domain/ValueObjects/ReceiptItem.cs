namespace Spents.Domain.ValueObjects
{
    public abstract class ReceiptItem
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; } = null!;
        public virtual short Quantity { get; set; }
        public virtual decimal ItemPrice { get; set; }
        public virtual string Observation { get; set; } = null!;
        public virtual decimal TotalPrice { get { return ItemPrice * Quantity; } }

        public virtual decimal CalculateTotalPrice(decimal itemPrice, short quantity)
        {
            return itemPrice * quantity;
        }
    }
}
