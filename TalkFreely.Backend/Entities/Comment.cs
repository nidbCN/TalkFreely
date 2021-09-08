using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalkFreely.Backend.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CommentTime { get; set; }
        public string AuthorBrower { get; set; }
        public string AuthorSystem { get; set; }
        public Uri AuthorAvatar { get; set; }
        public string AuthorMail { get; set; }
    }
}
