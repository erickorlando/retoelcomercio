using System.Collections.Generic;
using Prueba02.Datos;
using Prueba02.Entidades.Models;

namespace Prueba02.Negocio
{
    public class SucursalesNegocio : INegocio<Sucursal>
    {
        private readonly IRepository<Sucursal> _repository;

        public SucursalesNegocio()
        {
            _repository = new SucursalesRepository();
        }

        public void Add(Sucursal entidad)
        {
            _repository.Add(entidad);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Sucursal GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Sucursal> Listar()
        {
            return _repository.ListarTodos();
        }

        public void Update(Sucursal entidad)
        {
            _repository.Update(entidad);
        }
    }
}