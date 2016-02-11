namespace Kothar.Server.Interfaces.Commons
{
    public interface IConnect
    {
        void Connect();

        void Connect(params object[] parameters);
    }
}