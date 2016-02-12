using Kothar.Server.Interfaces.Marshalling;
using Kothar.Server.Interfaces.Networking;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IAwaitPluginDependentsMessage : IMessage, IMarshallable
    {
        string PluginType { get; }

        string PluginName { get; }

        long SerialVersionUId { get; }
    }
}