using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlogSampleApp.Models;

namespace HookIn
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BlogContext();

            Console.Write("Choose a name for your new blog: ");
            var name = Console.ReadLine();

            var blog = new Blog { BlogName = name };
            db.Blogs.Add(blog);
            db.SaveChanges();

            var query = from b in db.Blogs
                        orderby b.BlogName
                        select b;

            foreach (var item in query)
            {
                Console.WriteLine(item.BlogName);
            }
            Console.ReadKey();
        }
    }
}
