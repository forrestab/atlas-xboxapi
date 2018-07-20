using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class DevicePresence
    {
        public string Type { get; set; }
        public List<TitlePresence> Titles { get; set; }
    }
}
