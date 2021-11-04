using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public int BlogId { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int ReadyStatus { get; set; }
        public string Slug { get; set; }
        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }

        public virtual AspNetUser Author { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
