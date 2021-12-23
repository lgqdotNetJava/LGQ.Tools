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
        private static string GetListSqlCommand { get; set; } = "WorkOrderAccess.GetList";

        public static List<WorkOrder> GetList()
        {
            using (IDbConnection cnn = new SQLiteConnection(OAConfig.LoadConnectString()))
            {
                cnn.Open();
                var output = cnn.Query<WorkOrder>(OAConfig.GetSqlCmd(GetListSqlCommand));
                return output.ToList();
            }
        }
    }
}
