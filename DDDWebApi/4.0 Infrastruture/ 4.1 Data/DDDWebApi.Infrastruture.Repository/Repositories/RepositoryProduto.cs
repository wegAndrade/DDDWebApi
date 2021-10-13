using DDDWebApi.Domain.Core.Interfaces.Repositories;
using DDDWebApi.Domain.Models;
using DDDWebApi.Infrastruture.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebApi.Infrastruture.Repository.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {

        private readonly SqlContext _context;
        public RepositoryProduto(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
