using DDDWebApi.Domain.Core.Interfaces.Repositories;
using DDDWebApi.Domain.Core.Interfaces.Services;
using DDDWebApi.Domain.Models;

namespace DDDWebApi.Domain.Services.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }

    }
}
