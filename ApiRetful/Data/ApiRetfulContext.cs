using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiRetful.Modelo;

namespace ApiRetful.Data
{
    public class ApiRetfulContext : DbContext
    {
        public ApiRetfulContext (DbContextOptions<ApiRetfulContext> options)
            : base(options)
        {
        }

        public DbSet<ApiRetful.Modelo.Article> Article { get; set; }

        public DbSet<ApiRetful.Modelo.Category> Category { get; set; }

        public DbSet<ApiRetful.Modelo.Person> Person { get; set; }

        public DbSet<ApiRetful.Modelo.Income> Income { get; set; }

        public DbSet<ApiRetful.Modelo.IncomeDetail> IncomeDetail { get; set; }

        public DbSet<ApiRetful.Modelo.Rol> Rol { get; set; }

        public DbSet<ApiRetful.Modelo.Sale> Sale { get; set; }
    }
}
