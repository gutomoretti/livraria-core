using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria_Core.Models
{
    public partial class LivrariaDbContext : DbContext
    {
        public LivrariaDbContext(DbContextOptions<LivrariaDbContext> options) : base(options)
        {
        }

        public DbSet<Livro> livros { get; set; }
        public DbSet<Genero> generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=123456;Database=livraria");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
