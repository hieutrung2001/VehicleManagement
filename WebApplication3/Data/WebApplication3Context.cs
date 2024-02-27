using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarManagement.Models;

namespace WebApplication3.Data
{
    public class WebApplication3Context : DbContext
    {
        public WebApplication3Context (DbContextOptions<WebApplication3Context> options)
            : base(options)
        {
        }

        public DbSet<CarManagement.Models.Category> Category { get; set; } = default!;
        public DbSet<CarManagement.Models.Car> Car { get; set; } = default!;
    }
}
