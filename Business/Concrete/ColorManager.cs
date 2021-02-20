using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;                     //Bağımlılığı azaltmak için.

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            //İş kodlarını yaz.
            return _colorDal.GetAll();
        }

        public Color GetById(string colorId)
        {
            return _colorDal.Get(c=>c.ColorId == colorId);                 //neye göre get yapacağını yazıyor.
        }
    }
}
