
using Kothar.Server.Interfaces.Networking;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IDomainServer : ITcpAcceptCallBack

    {
        int DefaultPort { get; }

        
    }
}