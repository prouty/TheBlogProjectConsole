using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp.Models
{
    public partial class Blog
    {
        public Blog()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }

        public virtual AspNetUser Author { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
