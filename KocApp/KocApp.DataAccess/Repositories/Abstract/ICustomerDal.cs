using KocApp.Core.DataAccess;
using KocApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocApp.DataAccess.Repositories.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    { 
    }
}
