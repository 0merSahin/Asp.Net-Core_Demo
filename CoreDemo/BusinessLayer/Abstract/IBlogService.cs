using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
        void CategoryAdd(Blog blog);

        void CategoryDelete(Blog blog);

        void CategoryUpdate(Blog blog);

        List<Blog> GetList();

        Blog GetById(int id);

        List<Blog> GetBlogListWithCategory();
    }
}

