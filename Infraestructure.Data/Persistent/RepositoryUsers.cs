using Infraestructure.Data.AccessData;
using Infraestructure.Data.Repository;

namespace Infraestructure.Data.Persistent
{
    public class RepositoryUsers : Get<tbl_Users>
    {
        public RepositoryUsers() : base(new DataContext()) { }
    }
}
