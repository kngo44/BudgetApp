
namespace Budget.Domain.Entities
{
    public class TransactionType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; } // Income, Spending
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
