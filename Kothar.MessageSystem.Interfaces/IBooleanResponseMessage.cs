using Kothar.Server.Interfaces.Marshalling;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IBooleanResponseMessage : IResponseMessage, IMarshallable
    {
        long SerialVersionUId { get; }

        bool ResponseValue { get; set; }

        string ToString();
    }
}