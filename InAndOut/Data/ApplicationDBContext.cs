using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using InAndOut.Models;


namespace InAndOut.Data
{
	public class ApplicationDBContext :DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
			: base(options)
		{
		}


		public DbSet<Item> Items { get; set; }


	}
}
