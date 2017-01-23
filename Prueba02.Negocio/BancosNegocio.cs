using System.Collections.Generic;
using Prueba02.Datos;
using Prueba02.Entidades.Models;

namespace Prueba02.Negocio
{
    public class BancosNegocio : INegocio<Banco>
    {
        private readonly BancosRepository _repository;

        public BancosNegocio()
        {
            _repository = new BancosRepository();
        }

        public void Add(Banco entidad)
        {
            _repository.Add(entidad);
        }

        public void Update(Banco entidad)
        {
            _repository.Update(entidad);
        }

        public Banco GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Banco> Listar()
        {
            return _repository.ListarTodos();
        }
    }
}
