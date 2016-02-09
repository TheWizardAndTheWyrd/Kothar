using System.Collections.Generic;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IAdvertiseMessage : IMessage
    {
        IEnumerable<IMessageType> Advertisements { get; set; }

        long SerialVersionUId { get; set; }
    }
}