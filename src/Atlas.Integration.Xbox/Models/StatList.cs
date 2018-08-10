using System.Collections.Generic;

namespace Atlas.Integration.Xbox.Models
{
    public class StatList
    {
        public string ArrangeByField { get; set; }
        public long ArrangeByFieldId { get; set; }
        public List<Stat> Stats { get; set; }
    }
}
