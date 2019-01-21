using ControleFinanceiro.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ControleFinanceiro
{
    public class ContrFinDBContext : DbContext
    {

        public ContrFinDBContext(DbContextOptions<ContrFinDBContext> options)
            : base(options)
        {
        }
        public DbSet<Entradas> Entradas { get; set; }

    }


}