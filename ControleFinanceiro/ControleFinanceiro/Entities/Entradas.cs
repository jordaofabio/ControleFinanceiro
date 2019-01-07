using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Entities
{
    public class Entradas
    {
        public int id_entrada { get; set; }
        public string Titulo { get; set; }
        public string Valor { get; set; }
        public string Mensal { get; set; }
        public DateTime Data { get; set; }
        public DateTime reg_date { get; }
    }
}
