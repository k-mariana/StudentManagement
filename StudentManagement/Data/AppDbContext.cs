using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

        public DbSet<Student> Students => Set<Student>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.UserLogin)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(x => x.UserPassword)
                      .IsRequired()
                      .HasMaxLength(255);

                entity.HasIndex(x => x.UserLogin)
                      .IsUnique();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Students");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.StudentFirstName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.StudentLastName)
                      .IsRequired()
                      .HasMaxLength(100);
            });



            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                UserLogin = "admin",
                UserPassword = "AQAAAAIAAYagAAAAEJy80kguewONZOfDnVVVRH3r9bk9t9WXeuRMNVndPcd1gMrtdlcpMtvK+C7KRlas5w=="
            });

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, StudentFirstName = "John", StudentLastName = "Smith" },
                new Student { Id = 2, StudentFirstName = "Anna", StudentLastName = "Brown" },
                new Student { Id = 3, StudentFirstName = "Michael", StudentLastName = "Johnson" },
                new Student { Id = 4, StudentFirstName = "Emily", StudentLastName = "Davis" },
                new Student { Id = 5, StudentFirstName = "David", StudentLastName = "Wilson" },
                new Student { Id = 6, StudentFirstName = "Sophia", StudentLastName = "Miller" },
                new Student { Id = 7, StudentFirstName = "Daniel", StudentLastName = "Moore" },
                new Student { Id = 8, StudentFirstName = "Olivia", StudentLastName = "Taylor" },
                new Student { Id = 9, StudentFirstName = "James", StudentLastName = "Anderson" },
                new Student { Id = 10, StudentFirstName = "Emma", StudentLastName = "Thomas" }
            );
        }
    }
}
