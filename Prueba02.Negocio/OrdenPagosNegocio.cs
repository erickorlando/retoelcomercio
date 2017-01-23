using System.Collections.Generic;
using Prueba02.Datos;
using Prueba02.Entidades.Models;

namespace Prueba02.Negocio
{
    public class OrdenPagosNegocio : INegocio<OrdenPago>
    {
        private readonly IRepository<OrdenPago> _repository;

        public OrdenPagosNegocio()
        {
            _repository = new OrdenPagoRepository();
        }

        public void Add(OrdenPago entidad)
        {
            _repository.Add(entidad);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public OrdenPago GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<OrdenPago> Listar()
        {
            return _repository.ListarTodos();
        }

        public void Update(OrdenPago entidad)
        {
            _repository.Update(entidad);
        }
    }
}