using System.Collections.Generic;

namespace Kothar.Management.Interfaces
{
    /// <summary>
    /// TODO: Refactor according to Service Fabric best practices.
    /// Useful interface for Management classes that will run Main methods.
    /// </summary>
    public interface ICommandMain
    {
        /// <summary>
        /// This should be called from a Service Fabric service's public static Main method.
        /// </summary>
        /// <param name="args"></param>
        void Main(string[] args);

        /// <summary>
        /// This method should probably be in its own static method in a helper class. 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        string ReadFile(string fileName);

        /// <summary>
        /// Executes a script on this node's host.
        /// </summary>
        /// <param name="process"></param>
        /// <param name="script"></param>
        /// <returns></returns>
        bool ExecScript(string process, string script);

        /// <summary>
        /// Find a VM by Id.
        /// </summary>
        /// <param name="agentName"></param>
        /// <returns></returns>
        object FindVmId(string agentName);

        /// <summary>
        /// Retrieves the PIDs for a collection of processes.
        /// TODO: Transform into a .ctor()
        /// </summary>
        /// <param name="pidDir"></param>
        /// <param name="processes"></param>
        /// <returns></returns>
        IEnumerable<string> ResolveProcesses(string pidDir, IEnumerable<string> processes);
    }
}