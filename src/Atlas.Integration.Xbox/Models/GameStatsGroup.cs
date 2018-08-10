using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class GameStatsGroup
    {
        public string Name { get; set; }
        public long TitleId { get; set; }
        public List<StatList> StatListsCollection { get; set; }
    }
}
