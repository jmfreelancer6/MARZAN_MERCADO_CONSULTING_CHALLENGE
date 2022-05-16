using Infraestructure.Data.AccessData;
using Infraestructure.Data.Repository;

namespace Infraestructure.Data.Persistent
{
    public class RepositoryOrdenes : RepositoryBase<Tbl_Ordenes>
    {
        public RepositoryOrdenes():base(new DataContext()) { }
    }
}
