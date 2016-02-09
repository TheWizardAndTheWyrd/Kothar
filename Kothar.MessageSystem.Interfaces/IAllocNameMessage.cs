namespace Kothar.MessageSystem.Interfaces
{
    public interface IAllocNameMessage : IMessage
    {
        string MessageType { get; set; }

        string AgentName { get; set; }

        long SerialVersionUId { get; set; }
    }
}