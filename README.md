1. Make a new Console app
	> mkdir SomeApp
	> cd SomeApp
	> dotnet new console -f net5.0 // where -f net5.0 is necessary if you want to use that version and it's not the default
2. Add the packages
	> dotnet add package Microsoft.EntityFrameworkCore.Design
 	> dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet
 	> dotnet add package Microsoft.NETCore.App
  > dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
 	> dotnet add package Microsoft.EntityFrameworkCore.Design
3. Scaffold from the existing PostreSQL database
	> dotnet ef dbcontext scaffold "[connection string]" Npgsql.EntityFrameworkCore.PostgreSQL -o Models -f -c AppDbContext
4. Test it out by updating Program.cs
	> Add: using TestApp.Models;

	```
	static void Main(string[] args)
	{
		using (AppDbContext db = new AppDbContext())
		{
			Blog blog = new Blog
			{
				Name = "My Blog 2",
				Description = "My Description 2"
			};

			db.Blogs.Add(blog);
			db.SaveChanges();
		}
	}
	```

5. Run it: dotnet run