using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Entities
{
    public class Entradas
    {
        [Key]
        public int id_entrada { get; set; }
        public string Titulo { get; set; }
        public decimal Valor { get; set; }
        public bool Mensal { get; set; }
        public DateTime Data { get; set; }
        public DateTime reg_date { get; }
    }
}
