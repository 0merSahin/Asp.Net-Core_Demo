using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=sql;User ID=SA;Password=reallyStrongPwd123");
		}

		public DbSet<About> Abouts { get; set; }

		public DbSet<Blog> Blogs { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Comment> Comments { get; set; }

		public DbSet<Contact> Contacts { get; set; }

		public DbSet<Writer> Writers { get; set; }

	}
}
