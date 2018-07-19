using Newtonsoft.Json;

namespace Atlas.Integration.Xbox.Models
{
    public class Profile
    {
        public long Id { get; set; }
        public long? HostId { get; set; }
        public string Gamertag { get; set; }
        public string GameDisplayName { get; set; }
        public string AppDisplayName { get; set; }
        public long Gamescore { get; set; }
        [JsonProperty("GameDisplayPicRaw")]
        public string GameDisplayPictureRaw { get; set; }
        [JsonProperty("AppDisplayPicRaw")]
        public string AppDisplayPictureRaw { get; set; }
        public string AccountTier { get; set; }
        [JsonProperty("XboxOneRep")]
        public string XboxOneReputation { get; set; }
        public string PreferredColor { get; set; }
        public int TenureLevel { get; set; }
        public bool IsSponsoredUser { get; set; }
    }
}
