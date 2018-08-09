using System;
using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class Screenshot
    {
        public Guid ScreenshotId { get; set; }
        public int ResolutionHeight { get; set; }
        public int ResolutionWidth { get; set; }
        public string State { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime DateTaken { get; set; }
        public DateTime LastModified { get; set; }
        public string UserCaption { get; set; }
        public string ScreenshotType { get; set; }
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
        public List<ScreenshotUri> ScreehshotUris { get; set; }
        public long Xuid { get; set; }
        public string ScreenshotName { get; set; }
        public string TitleName { get; set; }
        public string ScreenshotLocale { get; set; }
        public string ScreenshotContentAttributes { get; set; }
        public string DeviceType { get; set; }
        public Uri ScreenshotDetails { get; set; }
    }
}
