using Data.Interfaces;

namespace Data.Models
{
    public class IncomeType : IEntity
    {
        public Guid ID { get; set; } 
        public string Name { get; set; } = String.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
