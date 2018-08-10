using Newtonsoft.Json;
using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class Stat
    {
        public StatGroupProperties GroupProperties { get; set; }
        public long Xuid { get; set; }
        public string Scid { get; set; }
        public long? TitleId { get; set; }
        public string Name { get; set; }
        [JsonProperty("type")]
        public string StatType { get; set; }
        public int Value { get; set; }
        public StatProperty Properties { get; set; }
    }
}
