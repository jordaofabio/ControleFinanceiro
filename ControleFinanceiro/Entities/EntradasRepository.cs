using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.Entities
{
    public class EntradasRepository : IEntradasRepository
    {
        private readonly ContrFinDBContext _ContrFinDBContext;

        public EntradasRepository(ContrFinDBContext contrFinDBContext)
        {
            _ContrFinDBContext = contrFinDBContext;
        }

        public List<Entradas> ListaEntradas()
        {
            return _ContrFinDBContext.Entradas.ToList();
        }
    }
}
