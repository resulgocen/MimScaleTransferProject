using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.Business.Abstract;
using ScaleTransfer.DataAccess.Abstract;
using ScaleTransfer.Entities.Concrete;

namespace ScaleTransfer.Business.Concrete
{
    public class YevmiyeManager : IYevmiyeService
    {
        private IYevmiyeDal _yevmiyeDal;

        public YevmiyeManager(IYevmiyeDal yevmiyeDal)
        {
            _yevmiyeDal = yevmiyeDal;
        }

        public DataTable GetAll(string excelPath)
        {
            return _yevmiyeDal.GetAll(excelPath);
        }

        public void Update(Yevmiye yevmiye, string databasePath)
        {
            _yevmiyeDal.Update(yevmiye, databasePath);
        }
    }
}
