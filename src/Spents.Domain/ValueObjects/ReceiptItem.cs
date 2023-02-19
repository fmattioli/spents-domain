namespace Spents.Domain.ValueObjects
{
    public record ReceiptItem
    {
        public virtual Guid Id { get; set; }
        public virtual string ItemName { get; set; } = null!;
        public virtual short Quantity { get; set; }
        public virtual decimal ItemPrice { get; set; }
        public virtual string Observation { get; set; } = null!;
        public virtual decimal TotalPrice { get; set; }
    }
}
