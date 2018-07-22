using Newtonsoft.Json;
using System;

namespace Atlas.Integration.Xbox.Models
{
    public class ActivityItem
    {
        public Guid AchievementScid { get; set; }
        public int AchievementId { get; set; }
        public string AchievementType { get; set; }
        public Uri AchievementIcon { get; set; }
        public int Gamerscore { get; set; }
        public string AchievementName { get; set; }
        public string AchievementDescription { get; set; }
        public bool IsSecret { get; set; }
        public bool HasAppAward { get; set; }
        public bool HasArtAward { get; set; }
        public Uri ContentImageUri { get; set; }
        public Guid BingId { get; set; }
        public string ContentTitle { get; set; }
        public string Platform { get; set; }
        public long TitleId { get; set; }
        public Activity Activity { get; set; }
        [JsonProperty("userImageUriMd")]
        public Uri UserImageUriMedium { get; set; }
        [JsonProperty("userImageUriXs")]
        public Uri UserImageUriExtraSmall { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool HasUgc { get; set; }
        public string ActivityItemType { get; set; }
        public string ContentType { get; set; }
        public string ShortDescription { get; set; }
        public string ItemText { get; set; }
        public Uri ItemImage { get; set; }
        public string ShareRoot { get; set; }
        public string FeedItemId { get; set; }
        public string ItemRoot { get; set; }
        public bool HasLiked { get; set; }
        public Author AuthorInfo { get; set; }
        public string Gamertag { get; set; }
        public string RealName { get; set; }
        public string DisplayName { get; set; }
        public Uri UserImageUri { get; set; }
        public long UserXuid { get; set; }
    }
}
