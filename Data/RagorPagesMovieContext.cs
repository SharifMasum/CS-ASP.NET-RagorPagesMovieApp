using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RagorPagesMovie.Models;

namespace RagorPagesMovie.Data
{
    public class RagorPagesMovieContext : DbContext
    {
        public RagorPagesMovieContext (DbContextOptions<RagorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RagorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
