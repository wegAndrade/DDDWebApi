using DDDWebApi.Application.Interfaces;
using DDDWebApi.Application.Service;
using DDDWebApi.Domain.Core.Interfaces.Repositories;
using DDDWebApi.Domain.Core.Interfaces.Services;
using DDDWebApi.Domain.Services.Services;
using DDDWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;
using DDDWebApi.Infrastruture.CrossCutting.Adapter.Map;
using DDDWebApi.Infrastruture.Repository.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DDDWebApi.Infrastruture.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            #region Mappers
            services.AddScoped<IMapperCliente, MapperCliente>();
            services.AddScoped<IMapperProduto, MapperProduto>();
            #endregion
            #region Repositories
            services.AddScoped<IRepositoryCliente, RepositoryCliente>();
            services.AddScoped<IRepositoryProduto, RepositoryProduto>();
            #endregion
            #region Services
            services.AddScoped<IServiceCliente, ServiceCliente>();
            services.AddScoped<IServiceProduto, ServiceProduto>();
            #endregion
            #region AppServices
            services.AddScoped<IApplicationServiceCliente, ApplicationServiceCliente>();
            services.AddScoped<IApplicationServiceProduto, ApplicationServiceProduto>();
            #endregion
        }
    }
}
