using MongoDB.Bson.Serialization.Attributes;
using Spents.Domain.ValueObjects;
using System.Runtime.Serialization;

namespace Spents.Domain.Entities
{
    [DataContract]
    public class Receipt
    {
        [DataMember]
        [BsonIgnore]
        public virtual Guid Id { get; set; }
        [DataMember]
        public virtual string EstablishmentName { get; set; } = null!;
        [DataMember]
        public virtual DateTime ReceiptDate { get; set; }
        [DataMember]
        public virtual IEnumerable<ReceiptItem> ReceiptItems { get; set; } = new List<ReceiptItem>();
    }
}
