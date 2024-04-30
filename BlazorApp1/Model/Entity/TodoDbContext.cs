using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Model.Entity
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<TodoItem> Items { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>().HasData(new List<TodoItem>
    {
        new TodoItem{ Description = "Complete all Coded Assignments", IsCompleted = false, Id = 1, DueDate = new DateTime(2024,04,30)},
        new TodoItem{ Description = "Appartment Rent", IsCompleted = true, Id = 2, StarsCount = 3 },
        new TodoItem{ Description = "Clean My Room", IsCompleted = false, Id = 3, StarsCount = 1 }
    });
    }}
    
}
