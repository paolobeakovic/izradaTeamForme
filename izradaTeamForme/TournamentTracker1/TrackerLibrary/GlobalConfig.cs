using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {

            if (db == DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }

            if (db == DatabaseType.TextFile)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
