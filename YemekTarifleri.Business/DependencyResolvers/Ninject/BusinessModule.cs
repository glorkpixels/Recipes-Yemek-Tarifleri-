﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Business.Concrete.Managers;
using YemekTarifleri.Core.DataAccess.NHibernate;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.DataAccess.Concrete.EntityFramework;
using YemekTarifleri.DataAccess.Concrete.NHibernate.Helpers;

namespace YemekTarifleri.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>();

            Bind<DbContext>().To<FoodContext>();

            Bind<NHibernateHelper>().To<SqlServerHelper>();

        }
    }
}