using Newtonsoft.Json;
using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class GamerActivity
    {
        [JsonProperty("numItems")]
        public int TotalActivityItems { get; set; }
        public List<ActivityItem> ActivityItems { get; set; }
        public long PollingToken { get; set; }
        [JsonProperty("pollingIntervalSeconds")]
        public int PollingIntervalInSeconds { get; set; }
        [JsonProperty("contToken")]
        public long ContinuationToken { get; set; }
    }
}
