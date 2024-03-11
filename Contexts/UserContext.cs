using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yudashev.Models;

namespace Yudashev.Contexts
{
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Yuldashev;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
}
