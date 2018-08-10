using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class GameStats
    {
        public List<GameStatsGroup> Groups { get; set; }
        public List<StatList> StatListsCollection { get; set; }
    }
}
