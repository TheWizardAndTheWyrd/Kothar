using System.Collections.Generic;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IAgentStateMessage : IMessage, IAgent
    {
        IEnumerable<IMessageType> Advertisement { get; set; }
    }
}