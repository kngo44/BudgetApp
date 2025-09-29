
namespace Budget.Domain.Entities
{
    internal class TransactionTag
    {
        public Guid TransactionId { get; set; }
        public Guid TagId { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public Transaction Transaction { get; set; }
        public Tag Tag { get; set; }
    }
}
