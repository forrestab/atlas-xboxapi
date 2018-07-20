using System;

namespace Atlas.Integration.Xbox.Models
{
    public class TitlePresence
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Placement { get; set; }
        public string State { get; set; }
        public DateTime LastModified { get; set; }
    }
}
