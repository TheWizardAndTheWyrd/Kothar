using Kothar.Server.Interfaces.Networking;

namespace Kothar.Server.Interfaces.Marshalling
{
    public interface IMarshallable
    {
        void MarshalObject(IKotharByteBuffer buffer);

        object UnmarshalObject(IKotharByteBuffer buffer);
    }
}