using System;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName = "Ömer"
				},
				new UserComment
				{
					ID = 2,
					UserName = "Yusuf"
				},
				new UserComment
				{
					ID = 3,
					UserName = "Gülcan"
				}
			};
			return View(commentValues);
		}
	}
}

