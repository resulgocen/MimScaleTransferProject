using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.DataAccess.Abstract;

namespace ScaleTransfer.DataAccess.Concrete.AdoNet.Access
{
    public class AnSabitDal : ISabitDal
    {
        private OleDbConnection _oleDbConnection = null;

        public void ConnectionCheck(string databasePath)
        {
            if (_oleDbConnection == null)
            {
                _oleDbConnection =
                    new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" + databasePath + "'");
            }
        }
        public DataTable GetAll(string databasePath)
        {
            ConnectionCheck(databasePath);

            _oleDbConnection.Open();
            DataTable dataTable = new DataTable();
            new OleDbDataAdapter("select Id, MaasAciklamasi from Sabit where Yil=2021 order by Ay desc", _oleDbConnection).Fill(dataTable);
            return dataTable;
        }
    }
}
