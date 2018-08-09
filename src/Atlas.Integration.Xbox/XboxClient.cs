using Atlas.Integration.Xbox.Models;
using Atlas.Integration.Xbox.Net.Http;
using Atlas.Integration.Xbox.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Atlas.Integration.Xbox
{
    public class XboxClient : IXboxClient
    {
        private readonly HttpClient client;

        public XboxClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://xboxapi.com/v2/");
            client.DefaultRequestHeaders.Add("X-Auth", "");

            this.client = client;
        }

        public async Task<long> GetXuid(string gamertag)
        {
            Guard.AgainstNullArgument<string>(nameof(gamertag), gamertag);

            return await this.client.GetAsync<long>($"xuid/{gamertag}");
        }

        public async Task<string> GetGamertag(long xuid)
        {
            return await this.client.GetAsync<string>($"gamertag/{xuid}");
        }

        public async Task<Profile> GetProfile(long xuid)
        {
            return await this.client.GetAsync<Profile>($"{xuid}/profile");
        }

        public async Task<Gamercard> GetGamercard(long xuid)
        {
            return await this.client.GetAsync<Gamercard>($"{xuid}/gamercard");
        }

        public async Task<Presence> GetPresence(long xuid)
        {
            return await this.client.GetAsync<Presence>($"{xuid}/presence");
        }

        public async Task<GamerActivity> GetActivity(long xuid, long? continuationToken = null)
        {
            string Uri = $"{xuid}/activity";

            if (continuationToken.HasValue)
            {
                Uri += $"?contToken={continuationToken.Value}";
            }

            return await this.client.GetAsync<GamerActivity>(Uri);
        }

        // TODO, revisit returned type
        public async Task<List<ActivityItem>> GetRecentActivity(long xuid)
        {
            return await this.client.GetAsync<List<ActivityItem>>($"{xuid}/activity/recent");
        }

        public async Task<List<Friend>> GetFriends(long xuid)
        {
            return await this.client.GetAsync<List<Friend>>($"{xuid}/friends");
        }

        public async Task<List<Friend>> GetFollowers(long xuid)
        {
            return await this.client.GetAsync<List<Friend>>($"{xuid}/followers");
        }

        public async Task<List<GameClip>> GetGameClips(long xuid, long? titleId = null)
        {
            string Uri = $"{xuid}/game-clips";

            if (titleId.HasValue)
            {
                Uri += $"/{titleId.Value}";
            }

            return await this.client.GetAsync<List<GameClip>>(Uri);
        }

        public async Task<List<GameClip>> GetSavedGameClips(long xuid)
        {
            return await this.client.GetAsync<List<GameClip>>($"{xuid}/game-clips/saved");
        }

        public async Task<List<Screenshot>> GetScreenshots(long xuid, long? titleId = null)
        {
            string Uri = $"{xuid}/screenshots";

            if (titleId.HasValue)
            {
                Uri += $"/{titleId.Value}";
            }

            return await this.client.GetAsync<List<Screenshot>>(Uri);
        }
    }
}
