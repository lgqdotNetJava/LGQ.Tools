using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace OAModule
{
    internal static class OAConfig
    {
        static Dictionary<string, string> sqlCmds = new Dictionary<string, string>();

        static OAConfig()
        {
            InitSqlCmds();
        }

        static void InitSqlCmds()
        {
            string xmlPath = "Config";
            string[] xmlFilePaths = Directory.GetFiles(xmlPath);
            foreach (var xmlFilePath in xmlFilePaths)
            {
                if (xmlFilePath.EndsWith("SqlConfig.xml"))
                {
                    XElement xe = XElement.Load(xmlFilePath);
                    IEnumerable<XElement> cmdNodes = from ele in xe.Elements("sql-command") select ele;
                    foreach (var cmdNode in cmdNodes)
                    {
                        sqlCmds.Add(cmdNode.Attribute("name").Value, cmdNode.Element("text").Value);
                    }
                }
            }
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="id">ConnectStringName</param>
        /// <returns></returns>
        public static string LoadConnectString(string id = "sqlDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// 获取SqlCommand
        /// </summary>
        /// <param name="cmdName">SqlCommand key</param>
        /// <returns></returns>
        public static string GetSqlCmd(string cmdName)
        {
            string resultSqlCmd = string.Empty;
            sqlCmds.TryGetValue(cmdName, out resultSqlCmd);
            return resultSqlCmd;
        }
    }
}
