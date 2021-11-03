using System;
using User_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace User_Management_System.Database
{
    public class UMSContext : DbContext
    {
        public UMSContext(DbContextOptions options) : base(options)
        {
        }

        //entities
        public DbSet<Users> Users { get; set; }
    }
}
