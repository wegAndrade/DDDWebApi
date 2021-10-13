using DDDWebApi.Application.DTO.DTO;
using DDDWebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebApi.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion

    }
}
