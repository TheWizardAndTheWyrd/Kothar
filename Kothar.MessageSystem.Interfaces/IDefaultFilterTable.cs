using System.Collections;
using System.Collections.Generic;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IDefaultFilterTable : IFilterTable
    {
        IDictionary<IMessageType, IDictionary<object, IEnumerable<ISubscription>>> MessageTypes { get; set; }

        void AddFilter(ISubscription subscription, object filterObject);

        void RemoveFilter(ISubscription subscription, object filterObject);

        int Match(IMessage message, IEnumerable<object> matches, IEnumerable<ISubscription> triggers);
    }
}