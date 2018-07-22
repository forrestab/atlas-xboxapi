using Atlas.Integration.Xbox.Models;
using System.Threading.Tasks;

namespace Atlas.Integration.Xbox
{
    public interface IXboxClient
    {
        Task<long> GetXuid(string gamertag);
        Task<string> GetGamertag(long xuid);
        Task<Profile> GetProfile(long xuid);
        Task<Gamercard> GetGamercard(long xuid);
        Task<Presence> GetPresence(long xuid);
        Task<GamerActivity> GetActivity(long xuid, long? continuationToken = null);
    }
}
