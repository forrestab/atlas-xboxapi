using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class Presence
    {
        public long Xuid { get; set; }
        public string State { get; set; }
        public List<DevicePresence> Devices { get; set; }
    }
}
