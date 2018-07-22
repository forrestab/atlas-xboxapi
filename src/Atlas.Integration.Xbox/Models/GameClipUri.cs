using System;

namespace Atlas.Integration.Xbox.Models
{
    public class GameClipUri
    {
        public Uri Uri { get; set; }
        public long FileSize { get; set; }
        public string UriType { get; set; }
        public DateTime Expiration { get; set; }
    }
}
