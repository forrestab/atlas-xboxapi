using Newtonsoft.Json;
using System;

namespace Atlas.Integration.Xbox.Models
{
    public class Activity
    {
        [JsonProperty("numShares")]
        public int NumberOfShares { get; set; }
        [JsonProperty("numLikes")]
        public int NumberOfLikes { get; set; }
        [JsonProperty("numComments")]
        public int NumberOfComments { get; set; }
        public string UgcCaption { get; set; }
        public string AuthorType { get; set; }
        public Guid AchievementScid { get; set; }
        public int AchievementId { get; set; }
        public string AchievementItemType { get; set; }
        public string AchievementType { get; set; }
        public long UserXuid { get; set; }
        public Uri AchievementIcon { get; set; }
        public DateTime Date { get; set; }
        public int Gamerscore { get; set; }
        public string ContentType { get; set; }
        public string AchievementName { get; set; }
        public long TitleId { get; set; }
        public string AchievementDescription { get; set; }
        public string Platform { get; set; }
        public bool IsSecret { get; set; }
        public string SandboxId { get; set; }
        public int SharedSourceUser { get; set; }
        public string UserKey { get; set; }
        public string RarityCategory { get; set; }
        public Guid Scid { get; set; }
        public int RarityPercentage { get; set; }
    }
}
