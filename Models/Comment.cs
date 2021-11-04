using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }
        public string Body { get; set; }
        public string ModeratedBody { get; set; }
        public int ModerationType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Moderated { get; set; }
        public DateTime? Deleted { get; set; }

        public virtual AspNetUser Author { get; set; }
        public virtual AspNetUser Moderator { get; set; }
        public virtual Post Post { get; set; }
    }
}
