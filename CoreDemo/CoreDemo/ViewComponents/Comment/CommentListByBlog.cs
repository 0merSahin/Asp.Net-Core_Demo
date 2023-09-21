﻿using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetList(3);
            return View(values);
        }
    }
}
