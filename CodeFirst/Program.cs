using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            using (var db = new BloggingContext())
            {
                var model=new Blog(){
                    BlogId=1,
                    Url="www",
                };
                db.Blogs.Add(model);
                db.SaveChanges();
            }

            Console.ReadLine();

        }
    }
}
