using Kothar.Server.Interfaces.Networking;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IAgentInfo : IAgent
    {
        new string AgentName { get; }

        /// <summary>
        /// TODO: Define the ISocketChannel interface and wrap the actor system; possibly with Web Sockets.
        /// </summary>
        object SocketChannel { get; set; }

        IKotharByteBuffer OutputBuffer { get; set; }

        IKotharByteBuffer InputBuffer { get; set; }

        object Association { get; set; }
    }
}