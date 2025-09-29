
namespace Budget.Domain.Entities
{
    public class RecurringTransaction
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Frequency { get; set; } // Daily, Weekly, Monthly, Yearly
        public int FrequencyInterval { get; set; } // Every X days/weeks/months
        public DateTime? LastGeneratedDate { get; set; }
        public DateTime? NextDueDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CurrencyCode { get; set; }
    }
}
