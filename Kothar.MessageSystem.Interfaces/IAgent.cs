namespace Kothar.MessageSystem.Interfaces
{
    public interface IAgent : IAgentHandle
    {
        int AgentId { get; set; }        

        string AgentIp { get; set; }

        int AgentPort { get; set; }

        int Flags { get; set; }

        long SerialVersionUId { get; }
    }
}