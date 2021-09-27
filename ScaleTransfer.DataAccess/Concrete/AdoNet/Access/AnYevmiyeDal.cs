using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.DataAccess.Abstract;
using ScaleTransfer.Entities.Concrete;

namespace ScaleTransfer.DataAccess.Concrete.AdoNet.Access
{
    public class AnYevmiyeDal : IYevmiyeDal
    {
        private OleDbConnection _oleDbConnectionAccess = null;
        private OleDbConnection _oleDbConnectionExcel = null;

        public void AccessConnectionCheck(string databasePath)
        {
            if (_oleDbConnectionAccess == null)
            {
                _oleDbConnectionAccess =
                    new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" + databasePath + "'");
            }
        }

        public void ExcelConnectionCheck(string excelPath)
        {
            if (_oleDbConnectionExcel == null)
            {
                _oleDbConnectionExcel =
                    new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + excelPath +
                                        "'; Extended Properties='Excel 12.0; HDR=YES; IMEX = 1'");
            }
        }

        public DataTable GetAll(string excelPath)
        {
            ExcelConnectionCheck(excelPath);

            DataTable dataTable = new DataTable();
            new OleDbDataAdapter("select * from [Sayfa1$]", _oleDbConnectionExcel).Fill(dataTable);
            return dataTable;
        }

        public void Update(Yevmiye yevmiye, string databasePath)
        {
            AccessConnectionCheck(databasePath);

            _oleDbConnectionAccess.Open();
            OleDbCommand oleDbCommand =
                new OleDbCommand(
                    "update Yevmiye set Yevmiye=@Yevmiye where SabitId=@SabitId and GrupNo=@GrupNo and HizmetYili=@HizmetYili",
                    _oleDbConnectionAccess);
            oleDbCommand.Parameters.AddWithValue("@Yevmiye", yevmiye.GunlukCalismaBedeli);
            oleDbCommand.Parameters.AddWithValue("@SabitId", yevmiye.SabitId);
            oleDbCommand.Parameters.AddWithValue("@GrupNo", yevmiye.GrupNo);
            oleDbCommand.Parameters.AddWithValue("@HizmetYili", yevmiye.HizmetYili);
            oleDbCommand.ExecuteNonQuery();
            _oleDbConnectionAccess.Close();
        }
    }
}
