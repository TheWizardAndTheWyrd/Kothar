using Kothar.MessageSystem.Interfaces;
using Kothar.Server.Interfaces.Engine;

namespace Kothar.Management.Interfaces
{
    public interface ITransientAgent
    {
        string AgentName { get; }

        string DomainServer { get; }

        int DomainPort { get; }

        IMessageAgent Agent { get; }

        IScriptManager ScriptManager { get; }

        void Connect();

        bool RunScript(string fileName);

        // Transform into a .ctor()
        void Main(string[] args);
    }
}