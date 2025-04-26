using CSharpEgitimKampi.DataAccessLayer.Abstract;
using CSharpEgitimKampi.DataAccessLayer.Repositories;
using CSharpEgitimKampi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product> , IProductDal
    {
    }
}
