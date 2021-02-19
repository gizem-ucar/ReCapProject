using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = Entities.Concrete.Color;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository <Color>
    {

    }
}
