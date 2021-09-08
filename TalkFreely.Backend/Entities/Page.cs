using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalkFreely.Backend.Entities
{
    public class Page
    {
        public Guid Id { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
