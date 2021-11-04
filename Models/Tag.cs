using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp.Models
{
    public partial class Tag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string BlogUserId { get; set; }
        public string Text { get; set; }

        public virtual AspNetUser BlogUser { get; set; }
        public virtual Post Post { get; set; }
    }
}
