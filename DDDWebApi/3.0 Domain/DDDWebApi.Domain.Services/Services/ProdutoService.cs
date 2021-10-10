using DDDWebApi.Domain.Core.Interfaces.Repositories;
using DDDWebApi.Domain.Models;


namespace DDDWebApi.Domain.Services.Services
{
    public class ProdutoService : ServiceBase<Produto>
    {
        public ProdutoService(IRepositoryProduto RepositoryProduto) : base(RepositoryProduto)
        {
        }
    }
}
