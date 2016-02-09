namespace Kothar.MessageSystem.Interfaces
{
    public interface IAwaitPluginDependentsMessage : IMessage
    {
        string PluginType { get; }

        string PluginName { get; }

        long SerialVersionUId { get; }
    }
}