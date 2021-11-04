using System;
using ConsoleApp.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
					using (AppDbContext db = new AppDbContext())
					{
						Blog blog = new Blog
						{
							Name = "My Blog",
							Description = "My Description"
						};

						db.Blogs.Add(blog);
						db.SaveChanges();
					}
        }
    }
}
