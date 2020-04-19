using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfWorkRepository : EfGenericRepository<Work> ,  IWorkDal
    {
        
    }
}
