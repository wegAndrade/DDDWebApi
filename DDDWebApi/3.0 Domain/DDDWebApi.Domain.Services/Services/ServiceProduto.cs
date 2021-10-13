using DDDWebApi.Domain.Core.Interfaces.Repositories;
using DDDWebApi.Domain.Core.Interfaces.Services;
using DDDWebApi.Domain.Models;


namespace DDDWebApi.Domain.Services.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        public ServiceProduto(IRepositoryProduto RepositoryProduto) : base(RepositoryProduto)
        {
        }
    }
}
