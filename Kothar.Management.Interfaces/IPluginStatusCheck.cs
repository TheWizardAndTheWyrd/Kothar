using System.Collections.Generic;
using System.Runtime.Serialization;
using Kothar.MessageSystem.Interfaces;
using Kothar.Server.Interfaces.Commons;

namespace Kothar.Management.Interfaces
{
    public interface IPluginStatusCheck : IResponseCallBack, IConnect, IMain
    {
        IEnumerable<string> GetPluginStatus();

        void HandleResponse(IResponseMessage responseMessage);

        void RollupValue(string key, ISerializable value);

        int MissingResponders { get; }

        int ExpectedResponders { get; }

        IDictionary<string, ISerializable> Rollup { get; }
    }
}