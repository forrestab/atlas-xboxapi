using System.Threading.Tasks;

namespace Atlas.Integration.Xbox
{
    public interface IXboxClient
    {
        Task<long> GetXuid(string gamertag);
    }
}
