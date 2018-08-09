using Atlas.Integration.Xbox.Models;
using System.Collections.Generic;
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
        Task<List<ActivityItem>> GetRecentActivity(long xuid);
        Task<List<Friend>> GetFriends(long xuid);
        Task<List<Friend>> GetFollowers(long xuid);
        Task<List<GameClip>> GetGameClips(long xuid, long? titleId = null);
        Task<List<GameClip>> GetSavedGameClips(long xuid);
        Task<List<Screenshot>> GetScreenshots(long xuid);
    }
}
