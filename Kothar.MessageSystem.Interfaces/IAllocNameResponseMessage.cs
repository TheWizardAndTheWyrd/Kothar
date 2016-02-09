namespace Kothar.MessageSystem.Interfaces
{
    public interface IAllocNameResponseMessage : IResponseMessage
    {
        string Name { get; set;  }

        long SerialVersionUId { get; }

        string ToString();
    }
}