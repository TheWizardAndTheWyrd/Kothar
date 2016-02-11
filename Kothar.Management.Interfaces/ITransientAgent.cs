using Kothar.MessageSystem.Interfaces;
using Kothar.Server.Interfaces.Commons;
using Kothar.Server.Interfaces.Engine;

namespace Kothar.Management.Interfaces
{
    public interface ITransientAgent : IDomainHost, IAgentHandle, IMain, IConnect
    {        
        IMessageAgent Agent { get; }

        IScriptManager ScriptManager { get; }

        bool RunScript(string fileName);
    }
}