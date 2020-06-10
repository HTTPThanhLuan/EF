using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{

    class Post
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Title { get; set; }
       // public String Body { get; set; }

        public String newProperty { get; set; }
    }

    class CodeFirstContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CodeFirstContext();
            var post = new Post()
            {
                DateTime = DateTime.Now,
                Title = 1,
                newProperty = "newProperty"
            };

            context.Posts.Add(post);
            context.SaveChanges();

        }
    }
}
