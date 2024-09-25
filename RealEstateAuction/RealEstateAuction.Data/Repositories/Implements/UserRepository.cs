using Microsoft.EntityFrameworkCore;
using RealEstateAuction.Data.EntityModels;
using RealEstateAuction.Data.Repositories.Interface;
using System.Linq.Expressions;

namespace RealEstateAuction.Data.Repositories.Implements
{
    public class UserRepository : IUserRepository
    {
        private readonly RealEstateContext _context;
        private readonly DbSet<User> _dbSet;

        public UserRepository(RealEstateContext context)
        {
            _context = context;
            _dbSet = context.Set<User>();
        }

        public async Task<User?> GetUserWithPredicate(Expression<Func<User, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }
    }
}
