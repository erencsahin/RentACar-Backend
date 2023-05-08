﻿using Core.DataAccess.EntityFramework.EfEntityRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,DbCarContext>,ICarImageDal
    {
    }
}
