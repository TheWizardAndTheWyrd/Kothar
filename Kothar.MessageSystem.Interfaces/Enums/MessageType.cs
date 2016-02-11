namespace Kothar.MessageSystem.Interfaces.Enums
{
    /// <summary>
    /// TODO: Make a generic IMessage<T> that accepts a MessageType in the type param to replace various message types?
    /// </summary>
    public enum MessageType
    {
        AgentHello,
        AgentState,
        AllocName,
        AllocNameResponse,
    }
}