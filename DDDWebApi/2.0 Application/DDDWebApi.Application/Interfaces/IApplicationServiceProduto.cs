﻿using DDDWebApi.Application.DTO.DTO;
using System.Collections.Generic;

namespace DDDWebApi.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO obj);

        ProdutoDTO GetById(int id);

        IEnumerable<ProdutoDTO> GetAll();

        void Update(ProdutoDTO obj);

        void Remove(ProdutoDTO obj);

        void Dispose();

    }
}
