using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Color = Entities.Concrete.Color;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color,CarRentalContext>, IColorDal
    {
        
    }
}
