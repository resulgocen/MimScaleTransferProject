using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleTransfer.DataAccess.Abstract
{
    public interface ISabitDal
    {
        DataTable GetAll(string databasePath);
        void ConnectionCheck(string databasePath);
    }
}
