using Dapper;
using OAModule.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace OAModule.Access
{
    public static class WorkOrderAccess
    {
        private static string GetListSqlCommand { get; set; } = "SELECT ID,OA_ID,OrderName,OrderDesc,BeginDate,EndDate,OrderStatus,PublishStatus FROM WorkOrder";

        public static List<WorkOrder> GetList()
        {
            using (IDbConnection cnn = new SQLiteConnection(OAConfig.LoadConnectString()))
            {
                cnn.Open();
                var output = cnn.Query<WorkOrder>(GetListSqlCommand);
                return output.ToList();
            }
        }
    }
}
