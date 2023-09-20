using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
        void CommentAdd(Comment comment);

        //void CategoryDelete(Comment comment);
        //void CategoryUpdate(Comment comment);

        List<Comment> GetList(int id);

        //Comment GetById(int id);
    }
}

