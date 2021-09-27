using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using ScaleTransfer.Business.Abstract;
using ScaleTransfer.Business.Concrete;
using ScaleTransfer.DataAccess.Abstract;
using ScaleTransfer.DataAccess.Concrete.AdoNet.Access;

namespace ScaleTransfer.Business.DependencyResolvers.Ninject
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IYevmiyeService>().To<YevmiyeManager>().InSingletonScope();
            Bind<IYevmiyeDal>().To<AnYevmiyeDal>().InSingletonScope();

            Bind<ISabitService>().To<SabitManager>().InSingletonScope();
            Bind<ISabitDal>().To<AnSabitDal>().InSingletonScope();
        }
    }
}
