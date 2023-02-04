using Spents.Domain.ValueObjects;

namespace Spents.Domain.Entities
{
    public abstract class Receipt
    {
        public virtual Guid Id { get; set; }
        public virtual string ReceiptName { get; set; } = null!;
        public virtual DateTime ReceiptDate { get; set; }
        public virtual IEnumerable<ReceiptItem> ReceiptItems { get; set; } = new List<ReceiptItem>();
    }
}
