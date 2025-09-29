using Data.Interfaces;

namespace Data.Models
{
    public class Account : IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime CreatedDate { get; set; }

        // Navigational Properties
        public Guid AccountTypeId { get; set; }
        public AccountType AccountType { get; set; } = default!; 
    }
}
