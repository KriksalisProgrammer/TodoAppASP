﻿using Microsoft.EntityFrameworkCore;
using TaskManager.Model;

namespace TaskManager.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>()
                .HasKey(t => t.Id);
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}