﻿using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        // IDataResult<Category> GetById(int categoryId);
        // IDataResult<List<Category>> GetListByCategory(int categoryId);
        // IResult Add(Category category);
        // IResult Delete(Category category);
        // IResult Update(Category category);
    }
}
