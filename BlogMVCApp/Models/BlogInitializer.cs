using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class BlogInitializer: DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="C#"},
                new Category(){CategoryName="Asp.Net MVC"},
                new Category(){CategoryName="Asp.Net Web Form"},
                new Category(){CategoryName="Windows Form"},
                new Category(){CategoryName="SQL"}
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=true,Content="C# delegates hakkında",Image="1.jpg",CategoryId=1},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-30), HomePage=true,Confirm=false,Content="C# delegates hakkında",Image="1.jpg",CategoryId=1},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=true,Content="C# delegates hakkında",Image="2.jpg",CategoryId=1},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-20), HomePage=false,Confirm=true,Content="C# delegates hakkında",Image="2.jpg",CategoryId=2},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-5), HomePage=true,Confirm=false,Content="C# delegates hakkında",Image="1.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=true,Content="C# Generic List hakkında",Image="2.jpg",CategoryId=2},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=true,Content="C# delegates hakkında",Image="1.jpg",CategoryId=3},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-15), HomePage=false,Confirm=true,Content="C# delegates hakkında",Image="2.jpg",CategoryId=3},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=true,Content="C# delegates hakkında",Image="1.jpg",CategoryId=3},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-17), HomePage=true,Confirm=true,Content="C# delegates hakkında",Image="2.jpg",CategoryId=4},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=true,Content="C# delegates hakkında",Image="1.jpg",CategoryId=4},
                new Blog(){Title="C# Delegates hakkında", DateAdded=DateTime.Now.AddDays(-10), HomePage=true,Confirm=false,Content="C# delegates hakkında",Image="2.jpg",CategoryId=4},
            };

            foreach (var blog in blogs)
            {
                context.Blogs.Add(blog);
            }
            context.SaveChanges();



            base.Seed(context);
        }
    }
}