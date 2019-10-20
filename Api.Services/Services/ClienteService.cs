using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Clientes;

namespace Api.Services.Services {
    public class ClienteService : IClienteServices {
        private IRepository<Cliente> _repository;
        public ClienteService (IRepository<Cliente> repository) {
            _repository = repository;
        }

        public async Task<bool> Delete (Guid id) {
            return await _repository.DeleteAsync (id);
        }

        public async Task<Cliente> Get (Guid id) {
            return await _repository.SelectAsync (id);
        }

        public async Task<IEnumerable<Cliente>> GetAll () {
            return await _repository.SelectAsync ();
        }

        public async Task<Cliente> Post (Cliente cliente) {
            return await _repository.InsertAsync (cliente);
        }

        public async Task<Cliente> Put (Cliente cliente) {
            return await _repository.UpdateAsync (cliente);
        }
    }
}
