
namespace Budget.Domain.Entities
{
    public class RecurringTransactionTag
    {
        public Guid RecurringTransactionId { get; set; }
        public Guid TagId { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public RecurringTransaction RecurringTransaction { get; set; }
        public Tag Tag { get; set; }
    }
}
