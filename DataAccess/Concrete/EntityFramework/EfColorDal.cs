using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using Entity.Concrete;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal :EfEntityRepositoryBase<Color, CarProjectContext> , IColorDal
    {
       
    }
}
