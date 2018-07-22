using Newtonsoft.Json;
using System;

namespace Atlas.Integration.Xbox.Models
{
    public class Friend
    {
        public long Id { get; set; }
        public long HostId { get; set; }
        public string Gamertag { get; set; }
        public string GameDisplayName { get; set; }
        public string AppDisplayName { get; set; }
        public int Gamerscore { get; set; }
        [JsonProperty("GamerDisplayPicRaw")]
        public Uri GamerDisplayPictureRaw { get; set; }
        [JsonProperty("AppDisplayPicRaw")]
        public Uri AppDisplayPictureRaw { get; set; }
        public string AccountTier { get; set; }
        [JsonProperty("XboxOneRep")]
        public string XboxOneReputation { get; set; }
        public Uri PreferredColor { get; set; }
        public int TenureLevel { get; set; }
        public bool IsSponsoredUser { get; set; }
    }
}
