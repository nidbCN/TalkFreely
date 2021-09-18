using System;
using System.Collections.Generic;

namespace TalkFreely.Backend.Entities
{
    public class Site
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Page> Pages { get; set; }
    }
}
