using KocApp.Core.DataAccess;
using KocApp.Core.DataAccess.EntityFramework;
using KocApp.DataAccess.Repositories.Abstract;
using KocApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocApp.DataAccess.Repositories.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,ApplicationDbContext>, IProductDal
    {
    }
}
