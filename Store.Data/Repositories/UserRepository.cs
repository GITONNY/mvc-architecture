using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public class UserRepository : RepositoryBase<Users>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
    public interface IUserRepository : IRepository<Users>
    {
        //Category GetCategoryByName(string categoryName);

    }
}
