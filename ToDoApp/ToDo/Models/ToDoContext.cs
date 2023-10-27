using Microsoft.EntityFrameworkCore;

namespace ToDo.Models;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
    }

    public DbSet<ToDo> ToDos { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Status> Statuses { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = "word", Name = "Work" },
            new Category { CategoryId = "home", Name = "Home" },
            new Category { CategoryId = "exercise", Name = "Exercise" },
            new Category { CategoryId = "shopping", Name = "Shopping" },
            new Category { CategoryId = "contact", Name = "Contact" }
        );

        modelBuilder.Entity<Status>().HasData(
            new Status { StatusId = "open", Name = "Open" },
            new Status { StatusId = "closed", Name = "Closed" }
        );
    }
}