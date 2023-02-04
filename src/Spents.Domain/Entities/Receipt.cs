using Spents.Domain.ValueObjects;

namespace Spents.Domain.Entities
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public string ReceiptName { get; set; } = null!;
        public DateTime ReceiptDate { get; set; }
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = new List<ReceiptItem>();
    }
}
