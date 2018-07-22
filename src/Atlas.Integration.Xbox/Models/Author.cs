using System;

namespace Atlas.Integration.Xbox.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public Uri ImageUrl { get; set; }
        public string AuthorType { get; set; }
        public long Id { get; set; }
    }
}
