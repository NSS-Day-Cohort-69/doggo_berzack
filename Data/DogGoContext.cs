using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogGo.Models;

    public class DogGoContext : DbContext
    {
        public DogGoContext (DbContextOptions<DogGoContext> options)
            : base(options)
        {
        }

        public DbSet<DogGo.Models.Owner> Owner { get; set; } = default!;

public DbSet<DogGo.Models.Dog> Dog { get; set; } = default!;
    }
