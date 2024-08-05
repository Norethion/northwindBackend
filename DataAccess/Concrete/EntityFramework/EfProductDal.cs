﻿using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NortwindContext>, IProductDal
    {
        // Ekstra metodlara ihtiyaç yok, temel CRUD işlemleri EfEntityRepositoryBase sınıfında zaten tanımlanmış.
    }
}
