using Budget.Domain.Interfaces;

namespace Budget.Domain.Entities
{
    public class IncomeType : IEntity
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } = String.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
