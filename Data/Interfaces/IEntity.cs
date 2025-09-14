
namespace Data.Interfaces
{
    public interface IEntity
    {
        Guid ID { get; set; }
        string Name { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
