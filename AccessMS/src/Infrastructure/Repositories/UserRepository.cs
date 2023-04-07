using AccessMS.Entities;
using AccessMS.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace AccessMS.Infrastructure.Repositories;

public class UserRepository: IRepository {

    private readonly AccessDbContext dbContext;

    public UserRepository(AccessDbContext _dbContext) =>
    (dbContext) = (_dbContext);

    public async Task<UserEntity?> GetUser(string userName) => 
        await dbContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);

}