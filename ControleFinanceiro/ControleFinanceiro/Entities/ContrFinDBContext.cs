using ControleFinanceiro.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ControleFinanceiro
{
    internal class ContrFinDBContext : DbContext
    {
        public DbSet<Entradas> Entradas { get; set; }
    }

    
}