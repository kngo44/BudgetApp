using Budget.Domain.Interfaces;

namespace Budget.Domain.Entities
{
    public class AccountType : IEntity
    {
        public Guid Id { get; set; } 
        public string TypeName { get; set; } // Bank, Credit, Savings, Investment
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
