namespace Kothar.MessageSystem.Interfaces
{
    public interface IBooleanResponseMessage : IResponseMessage
    {
        long SerialVersionUId { get; }

        bool ResponseValue { get; set; }

        string ToString();
    }
}