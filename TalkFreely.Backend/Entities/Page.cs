using System;
using System.Collections.Generic;

namespace TalkFreely.Backend.Entities
{
    public class Page
    {
        public Guid Id { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public Site Site { get; set; }
    }
}
