using System;
using System.Reflection.Metadata;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddCategory(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteCategory(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllCategory()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateCategory(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}

