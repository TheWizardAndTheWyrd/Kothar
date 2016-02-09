using Kothar.MessageSystem.Interfaces;

namespace Kothar.Management.Interfaces
{
    public interface IManagement
    {
        IMessageType GetPluginStatus { get; }
    }
}