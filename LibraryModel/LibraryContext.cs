using LibraryModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Microsoft.EntityFrameworkCore;

namespace LibraryModel
{
    public sealed class LibraryContext  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=LibraryCore;Integrated Security=true;Trust Server Certificate=true;");
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }

        
      

    }
}
