using Microsoft.EntityFrameworkCore;
using System;
using Tabloid.Models;

namespace Tabloid.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserType> UserType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UserProfile>()
            //.HasOne(m => m.Mentor)
            //.WithMany(t => t.UserMentees)
            //.HasForeignKey(m => m.MentorId)
            //.HasPrincipalKey(u => u.Id)
            //.OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserType>().HasData(
                new UserType()
                {
                    Id = 1,
                    Name = "Admin"
                },
                new UserType()
                {
                    Id = 2,
                    Name = "Author"
                }
                );
            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile()
                {
                    Id = 1,
                    DisplayName = "gteanby6",
                    FirstName = "Giuseppe",
                    LastName = "Teanby",
                    Email = "gteanby6@craigslist.orgx",
                    CreateDateTime = new DateTime(2019, 08, 29),
                    ImageLocation = "placeholder1.jpeg",
                    UserTypeId = 1,
                    FirebaseUserId = "TBD",

                },
                 new UserProfile()
                 {
                     Id = 2,
                     DisplayName = "ecornfoot8",
                     FirstName = "Emmaline",
                     LastName = "Cornfoot",
                     Email = "ecornfoot8@cargocollective.comx",
                     CreateDateTime = new DateTime(2020, 02, 17),
                     ImageLocation = "placeholder2.jpeg",
                     UserTypeId = 2,
                     FirebaseUserId = "TBD",

                 }
                );
        }

        public DbSet<Tabloid.Models.Car> Car { get; set; }

    }
}
