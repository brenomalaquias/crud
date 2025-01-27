using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Models;
using Microsoft.EntityFrameworkCore;


namespace crud.Data
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
                
            }
            public DbSet<Student> Students{ get; set; }
        
    }
}