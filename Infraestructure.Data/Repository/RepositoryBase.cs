using Domain.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infraestructure.Data.Repository
{
    public class RepositoryBase<T> : IBaseRepository<T> where T : class
    {
        protected DbContext _Model;
        public RepositoryBase(DbContext Model)
        {
            _Model = Model;
        }
        public void Agregar(T entidad)
        {
            _Model.Set<T>().Add(entidad);
            _Model.SaveChanges();
        }

        public void Editar(T entidad)
        {
            _Model.Entry(entidad).State = EntityState.Modified;
            _Model.SaveChanges();
        }

        public void Eliminar(T entidad)
        {
            _Model.Set<T>().Remove(entidad);
            _Model.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _Model.Set<T>();
        }

        public T Obtener(int id)
        {
            return _Model.Set<T>().Find(id);
        }
    }
}
