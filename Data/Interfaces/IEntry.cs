
namespace Data.Interfaces
{
    public interface IEntry
    {
        Guid ID { get; set; }
        string Name { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
