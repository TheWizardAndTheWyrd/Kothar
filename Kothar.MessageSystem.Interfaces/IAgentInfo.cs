using Kothar.Server.Interfaces.Networking;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IAgentInfo : IAgentHandle
    {
        int AgentId { get; set; }

        int Flags { get; set; }

        /// <summary>
        /// TODO: Define the ISocketChannel interface and wrap the actor system; possibly with Web Sockets.
        /// </summary>
        object SocketChannel { get; set; }

        new string AgentName { get; set; }

        string AgentIp { get; set; }

        int AgentPort { get; set; }

        IKotharByteBuffer OutputBuffer { get; set; }

        IKotharByteBuffer InputBuffer { get; set; }

        object Association { get; set; }
    }
}