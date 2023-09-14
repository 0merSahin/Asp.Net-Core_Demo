using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IBlogDal
	{
        List<Blog> ListAllCategory();

        void AddCategory(Blog blog);

        void DeleteCategory(Blog blog);

        void UpdateCategory(Blog blog);

        Blog GetByID(int id);
    }
}

