using RealEstateAuction.Data.EntityModels;
using System.Linq.Expressions;

namespace RealEstateAuction.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        public Task<User?> GetUserWithPredicate(Expression<Func<User, bool>> predicate);
    }
}
