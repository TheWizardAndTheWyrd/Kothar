namespace Kothar.MessageSystem.Interfaces
{
    public interface IAllocNameMessage : IMessage, IAgentHandle
    {
        string MessageType { get; set; }        

        long SerialVersionUId { get; set; }
    }
}