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

                new () { Id = 1, Title="������ 1", Description="�������� ������ 1", CreationDaate =DateTime.Now },
                new () { Id = 2, Title="������ 2", Description="�������� ������ 2", CreationDaate=DateTime.Now },
                new () { Id = 3, Title="������ 3", Description="�������� ������ 3", CreationDaate=DateTime.Now },
                new () { Id = 4, Title="������ 4", Description="�������� ������ 4", CreationDaate=DateTime.Now },
            ]);
        }

    }
}

