using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Database_FirstEntities();
            var post = new Post()
            {
                Title = "title",
                Body = "Body",
                Date = DateTime.Now
            };
            context.Posts.Add(post); // in memory
            context.SaveChanges(); //commit to db
        }
    }
}
