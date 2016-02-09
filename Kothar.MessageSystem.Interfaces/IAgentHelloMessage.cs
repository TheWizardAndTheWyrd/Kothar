namespace Kothar.MessageSystem.Interfaces
{
    public interface IAgentHelloMessage : IMessage
    {
        string AgentName { get; set; }

        string AgentIp { get; set; }

        int AgentPort { get; set; }

        int Flags { get; set; }

        long SerialVersionUId { get; }


    }
}