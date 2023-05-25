﻿using System;
using FullStack.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
	public class FullStackDbContext: DbContext
	{
		public FullStackDbContext(DbContextOptions options) : base(options)
		{

		}
			
		public DbSet<Employee> Employees { get; set; }
	}
}

