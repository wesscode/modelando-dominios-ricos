using NerdStore.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace NerdStore.Pagamentos.Data
{
    public class PagamentoContext : DbContext, IUnitOfWork
    {
        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
