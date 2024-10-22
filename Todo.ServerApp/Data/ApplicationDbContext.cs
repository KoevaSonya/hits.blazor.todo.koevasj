using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Todo.ServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TasksItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([

                new () { Id = 1, Title="Задача 1", Description="Описание задачи 1", CreationDaate =DateTime.Now },
                new () { Id = 2, Title="Задача 2", Description="Описание задачи 2", CreationDaate=DateTime.Now },
                new () { Id = 3, Title="Задача 3", Description="Описание задачи 3", CreationDaate=DateTime.Now },
                new () { Id = 4, Title="Задача 4", Description="Описание задачи 4", CreationDaate=DateTime.Now },
            ]);
        }

    }
}

