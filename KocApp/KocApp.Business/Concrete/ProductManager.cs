using KocApp.Business.Abstract;
using KocApp.DataAccess.Repositories.Abstract;
using KocApp.DataAccess.Repositories.Concrete;
using KocApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public void Delete(int id)
        {
            var entity = _productDal.Get(c => c.Id == id);
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
