namespace Kothar.Server.Interfaces.Commons
{
    public interface IDomainHost
    {
        string DomainServer { get; }

        int DomainPort { get; }
    }
}