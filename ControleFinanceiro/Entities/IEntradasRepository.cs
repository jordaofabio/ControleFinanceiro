using System.Collections.Generic;

namespace ControleFinanceiro.Entities
{
    public interface IEntradasRepository
    {
        List<Entradas> ListaEntradas();
    }
}