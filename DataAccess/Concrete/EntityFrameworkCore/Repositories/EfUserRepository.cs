using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User> ,  IUserDal
    {
        
    }
}
