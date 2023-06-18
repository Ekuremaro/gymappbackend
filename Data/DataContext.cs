using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gym_app_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace gym_app_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users =>  Set<User>();
    }
}