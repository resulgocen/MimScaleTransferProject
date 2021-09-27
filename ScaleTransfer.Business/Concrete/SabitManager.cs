using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.Business.Abstract;
using ScaleTransfer.DataAccess.Abstract;

namespace ScaleTransfer.Business.Concrete
{
    public class SabitManager : ISabitService
    {
        private ISabitDal _sabitDal;

        public SabitManager(ISabitDal sabitDal)
        {
            _sabitDal = sabitDal;
        }

        public DataTable GetAll(string databasePath)
        {
            return _sabitDal.GetAll(databasePath);
        }
    }
}
