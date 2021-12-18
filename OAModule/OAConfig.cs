using System.Configuration;

namespace OAModule
{
    internal static class OAConfig
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="id">ConnectStringName</param>
        /// <returns></returns>
        public static string LoadConnectString(string id = "sqlDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
