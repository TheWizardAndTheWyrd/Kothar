using System.Collections.Generic;

namespace Kothar.MessageSystem.Interfaces
{
    public interface IDomainCommand
    {
        string[] AllocName { get; set; }

        string WorldName { get; set; }

        string HostName { get; set; }

        IEnumerable<object> Properties { get; set; }

        IMessageAgent Agent { get; set; }

        string DomainHost { get; set; }

        string PortString { get; set; }

        int DomainPort { get; set; }

        string DetermineHostName();

        string ReverseLocalHostLookup();
    }
}