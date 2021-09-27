using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleTransfer.Business.Abstract
{
    public interface ISabitService
    {
        DataTable GetAll(string databasePath);
    }
}
