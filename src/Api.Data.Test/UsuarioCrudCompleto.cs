using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvide;
        public UsuarioCrudCompleto(DbTeste dbTeste)
        {
            _serviceProvide = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD de Usuário")]
        [Trait("CRUD", "UserEntity")]
        public async Task E_Possivel_Realizar_CRUD_Usuario()
        {
            using (var context = _serviceProvide.GetService<MyContext>())
            {
                UserImplementation _repositorio = new UserImplementation(context);
                UserEntity _entity = new UserEntity
                {
                    Email = "teste@mail.com",
                    Name = "teste"
                };
                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.Equal("teste@mail.com", _registroCriado.Email);
                Assert.Equal("teste", _registroCriado.Name);
                Assert.False(_registroCriado.Id == Guid.Empty);
            }
        }
    }
}
