using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Clientes {
    public interface IClienteServices {
        Task<Cliente> Get (Guid id);
        Task<IEnumerable<Cliente>> GetAll ();
        Task<Cliente> Post (Cliente cliente);
        Task<Cliente> Put (Cliente cliente);
        Task<bool> Delete (Guid id);
    }
}
