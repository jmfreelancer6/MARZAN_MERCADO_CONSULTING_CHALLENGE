using Domain.Core.Agregados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Infraestructure.Data.Repository
{
    public class Get<T> : IGet<T> where T : class
    {
        protected DbContext _Model;
        public Get(DbContext Model)
        {
            _Model = Model;
        }

        public IQueryable<T> ObtenerListado(Expression<Func<T, object>> orderBy)
        {
            return _Model.Set<T>().OrderBy(orderBy);
        }

        public IQueryable<T> ObtenerListadoByExpression(Expression<Func<T, bool>> Expre)
        {
            return _Model.Set<T>().Where(Expre);
        }

        public T ObtenerOneByExpression(Expression<Func<T, bool>> Expre)
        {
            return _Model.Set<T>().Where(Expre).FirstOrDefault();
        }
    }
}
