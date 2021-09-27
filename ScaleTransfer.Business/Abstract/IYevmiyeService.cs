using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.Entities.Concrete;

namespace ScaleTransfer.Business.Abstract
{
    public interface IYevmiyeService
    {
        DataTable GetAll(string excelPath);
        void Update(Yevmiye yevmiye, string databasePath);
    }
}
