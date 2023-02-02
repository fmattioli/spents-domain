using Spents.Domain.ValueObjects;

namespace Spents.Domain.Entities
{
    public interface IReceipt
    {
        public Guid Id { get; set; }
        public string ReceiptName { get; set; }
        public DateTime ReceiptDate { get; set; }
        public IEnumerable<IReceiptItem> ReceiptItems { get; set; }
    }
}
