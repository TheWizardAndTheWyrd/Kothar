namespace Kothar.MessageSystem.Interfaces
{
    public interface IAgent
    {
        int AgentId { get; set; }

        string AgentName { get; set; }

        string AgentIp { get; set; }

        int AgentPort { get; set; }

        int Flags { get; set; }

        long SerialVersionUId { get; }
    }
}