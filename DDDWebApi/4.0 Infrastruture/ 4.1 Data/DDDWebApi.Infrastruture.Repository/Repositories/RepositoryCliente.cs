
using DDDWebApi.Domain.Core.Interfaces.Repositories;
using DDDWebApi.Domain.Models;
using DDDWebApi.Infrastruture.Data.Context;

namespace DDDWebApi.Infrastruture.Repository.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
