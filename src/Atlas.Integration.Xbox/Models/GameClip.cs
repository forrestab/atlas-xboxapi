using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class GameClip
    {
        public Guid GameClipId { get; set; }
        public string State { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DateRecorded { get; set; }
        public DateTime LastModified { get; set; }
        public string UserCaption { get; set; }
        [JsonProperty("type")]
        public string GameClipType { get; set; }
        public int DurationInSeconds { get; set; }
        public Guid Scid { get; set; }
        public long TitleId { get; set; }
        public int Rating { get; set; }
        public int RatingCount { get; set; }
        public int Views { get; set; }
        public string TitleData { get; set; }
        public Guid SystemProperties { get; set; }
        public bool SavedByUser { get; set; }
        public string AchievementId { get; set; }
        public string GreatestMomentId { get; set; }
        public List<Thumbnail> Thumbnails { get; set; }
        public List<GameClipUri> GameClipUris { get; set; }
        public long Xuid { get; set; }
        public string ClipName { get; set; }
        public string TitleName { get; set; }
        public string GameClipLocale { get; set; }
        public string ClipContentAttribute { get; set; }
        public string DeviceType { get; set; }
        public int CommentCount { get; set; }
        public int LikeCount { get; set; }
        public int ShareCount { get; set; }
        public int PartialViews { get; set; }
        public Uri GameClipDetails { get; set; }
    }
}
