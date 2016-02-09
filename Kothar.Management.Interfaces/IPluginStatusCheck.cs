using System.Collections.Generic;
using System.Runtime.Serialization;
using Kothar.MessageSystem.Interfaces;

namespace Kothar.Management.Interfaces
{
    public interface IPluginStatusCheck
    {
        void Connect();

        IEnumerable<string> GetPluginStatus();

        void HandleResponse(IResponseMessage responseMessage);

        void RollupValue(string key, ISerializable value);

        int MissingResponders { get; }

        int ExpectedResponders { get; }

        IDictionary<string, ISerializable> Rollup { get; }

        // Transform into a .ctor() and helper methods.
        void Main(string[] args);
    }
}