using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppModels;

namespace CollegeRepository
{
    public class CollegeDBContext : DbContext
    {
        public CollegeDBContext (DbContextOptions<CollegeDBContext> options)
            : base(options)
        {
        }

        public DbSet<AppModels.Lecturer> Lecturer { get; set; } = default!;

        public DbSet<AppModels.Department> Department { get; set; } = default!;
    }
}
